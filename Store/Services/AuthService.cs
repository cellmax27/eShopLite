using DataEntities;

namespace Store.Services;

internal sealed class AuthService(HttpClient httpClient, ILogger<AuthService> logger)
{
    public async Task<List<User>> GetUsersAsync()
    {
        List<User>? users = null;

        try
        {
            var response = await httpClient.GetAsync("/auth/login/1");
            var responseText = await response.Content.ReadAsStringAsync();

            logger.LogInformation("Http status code: {StatusCode}", response.StatusCode);
            logger.LogInformation("Http response content: {ResponseText}", responseText);

            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadFromJsonAsync(UserSerializerContext.Default.ListUser);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error during GetAuthUsers.");
        }

        return users ?? [];
    }
}

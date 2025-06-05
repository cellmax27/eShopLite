using DataEntities;

namespace Store.Services;

internal sealed class UserService(HttpClient httpClient, ILogger<UserService> logger)
{
    public async Task<List<User>> GetUsersAsync()
    {
        List<User>? products = null;

        try
        {
            var response = await httpClient.GetAsync("/api/User");
            var responseText = await response.Content.ReadAsStringAsync();

            logger.LogInformation("Http status code: {StatusCode}", response.StatusCode);
            logger.LogInformation("Http response content: {ResponseText}", responseText);

            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadFromJsonAsync(UserSerializerContext.Default.ListUser);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error during GetUsers.");
        }

        return products ?? [];
    }
}

using System.Text.Json;
using DataEntities;

namespace Store.Services;

internal sealed class UserService(HttpClient httpClient, ILogger<UserService> logger)
{
    public async Task<List<User>> GetUsersAsync()
    {
        List<User>? users = null;

        try
        {
            var response = await httpClient.GetAsync("/api/User");
            var responseText = await response.Content.ReadAsStringAsync();

            logger.LogInformation("Http status code: {StatusCode}", response.StatusCode);
            logger.LogInformation("Http response content: {ResponseText}", responseText);

            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadFromJsonAsync<List<User>>(new JsonSerializerOptions
                {
                    TypeInfoResolver = new UserSerializerContext()
                });
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error during GetUsers.");
        }

        return users ?? [];
    }
}

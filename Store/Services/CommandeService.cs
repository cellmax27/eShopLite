using DataEntities;

namespace Store.Services;

internal sealed class CommandeService(HttpClient httpClient, ILogger<CommandeService> logger)
{
    public async Task<List<Commande>> GetCommandesAsync()
    {
        List<Commande>? commandes = null;

        try
        {
            var response = await httpClient.GetAsync("/api/Commande");
            var responseText = await response.Content.ReadAsStringAsync();

            logger.LogInformation("Http status code: {StatusCode}", response.StatusCode);
            logger.LogInformation("Http response content: {ResponseText}", responseText);

            if (response.IsSuccessStatusCode)
            {
                commandes = await response.Content.ReadFromJsonAsync(CommandeSerializerContext.Default.ListCommande);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error during GetCommandes.");
        }

        return commandes ?? [];
    }
}

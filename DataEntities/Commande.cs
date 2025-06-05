using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Commande
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("instock")]
    public bool Instock { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    //[JsonPropertyName("product")]
    public List<string>? Product { get; set; }

    //[JsonPropertyName("id")]
    //public string? User { get; set; }

    [JsonPropertyName("quantite")]
    public int Quantite { get; set; }
    
    [JsonPropertyName("prix")]
    public double Prix { get; set; }
}

[JsonSerializable(typeof(List<Commande>))]
public sealed partial class CommandeSerializerContext : JsonSerializerContext
{
}

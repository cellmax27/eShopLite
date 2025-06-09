using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Fruit
{
    [Key]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    [MaxLength(100)]
    public string? Name { get; set; }

    [JsonPropertyName("instock")]
    public bool Instock { get; set; }
    
}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class FruitSerializerContext : JsonSerializerContext
{
}

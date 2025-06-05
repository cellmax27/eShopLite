using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Fruit
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    //[JsonPropertyName("id")]
    public bool Instock { get; set; }
    
}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class FruitSerializerContext : JsonSerializerContext
{
}

using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Item
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    private string name { get; set; }
    [JsonPropertyName("description")]
    private string description { get; set; }
}

[JsonSerializable(typeof(List<Item>))]
public sealed partial class ItemSerializerContext : JsonSerializerContext
{
}
using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Item {
    //private Long id; //TOOD : useless with panache
    [JsonPropertyName("name")]
    private String name { get; set; }
    [JsonPropertyName("description")]
    private String description { get; set; }
}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class FruitSerializerContext : JsonSerializerContext
{
}
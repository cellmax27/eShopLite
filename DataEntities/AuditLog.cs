using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class AuditLog {
    [JsonPropertyName("username")]
    public String username { get; set; }

    [JsonPropertyName("action")]
    public String action { get; set; }

    [JsonPropertyName("timestamp")]
    public LocalDateTime timestamp { get; set; }

    [JsonPropertyName("details")]
    public String details { get; set; }
}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class FruitSerializerContext : JsonSerializerContext
{
}
using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class AuditLog
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string username { get; set; }

    [JsonPropertyName("action")]
    public string? action { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime timestamp { get; set; }

    [JsonPropertyName("details")]
    public string? details { get; set; }
}

[JsonSerializable(typeof(List<AuditLog>))]
public sealed partial class AuditLogSerializerContext : JsonSerializerContext
{
}
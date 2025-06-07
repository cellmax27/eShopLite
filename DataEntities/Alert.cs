using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Alert {
    [JsonPropertyName("title")]
    public String title { get; set; }

    [JsonPropertyName("description")]
    public String description { get; set; }

    [JsonPropertyName("severity")]
    public String severity { get; set; } // Ex: LOW, MEDIUM, HIGH, CRITICAL

    [JsonPropertyName("timestamp")]
    public LocalDateTime timestamp { get; set; }

    [JsonPropertyName("sourceIp")]
    public String sourceIp { get; set; }

    [JsonPropertyName("status")]
    public String status { get; set; }// Ex: NEW, IN_PROGRESS, CLOSED

}

[JsonSerializable(typeof(List<Alert>))]
public sealed partial class AlertSerializerContext : JsonSerializerContext
{
}
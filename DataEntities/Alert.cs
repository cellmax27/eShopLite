using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Alert
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? title { get; set; }

    [JsonPropertyName("description")]
    public string? description { get; set; }

    [JsonPropertyName("severity")]
    public string? severity { get; set; } // Ex: LOW, MEDIUM, HIGH, CRITICAL

    [JsonPropertyName("timestamp")]
    public DateTime timestamp { get; set; }

    [JsonPropertyName("sourceIp")]
    public string? sourceIp { get; set; }

    [JsonPropertyName("status")]
    public string? status { get; set; }// Ex: NEW, IN_PROGRESS, CLOSED

}

[JsonSerializable(typeof(List<Alert>))]
public sealed partial class AlertSerializerContext : JsonSerializerContext
{
}
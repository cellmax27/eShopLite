using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Incident
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string title { get; set; }

    [JsonPropertyName("description")]
    public string description { get; set; }

    [JsonPropertyName("status")]
    public string status { get; set; } // e.g., NEW, INVESTIGATING, RESOLVED, CLOSED

    [JsonPropertyName("severity")]
    public string severity { get; set; } // e.g., LOW, MEDIUM, HIGH, CRITICAL

    [JsonPropertyName("createdAt")]
    public DateTime createdAt { get; set; };

    [JsonPropertyName("updatedAt")]
    public DateTime updatedAt { get; set; };
    // Ajoutez d'autres champs : assigné à, source d'événements, etc.

}

[JsonSerializable(typeof(List<Incident>))]
public sealed partial class IncidentSerializerContext : JsonSerializerContext
{
}
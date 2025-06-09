using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DataEntities;

public sealed class Alert
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("severity")]
    public string? Severity { get; set; } // Ex: LOW, MEDIUM, HIGH, CRITICAL

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }// Ex: NEW, IN_PROGRESS, CLOSED

}

[JsonSerializable(typeof(List<Alert>))]
public sealed partial class AlertSerializerContext : JsonSerializerContext
{/*
    private readonly JsonSerializerOptions _options;

    // Fix for CS7036 and IDE0290: Use the base constructor and remove redundant field initialization
    public AlertSerializerContext(JsonSerializerOptions? options = null) : base(options ?? new JsonSerializerOptions())
    {
        _options = options ?? new JsonSerializerOptions();
    }

    protected override JsonSerializerOptions GeneratedSerializerOptions => _options;

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        if (type == typeof(List<User>))
        {
            return JsonTypeInfo.CreateJsonTypeInfo<List<User>>(_options);
        }

        return null;
    }

    public override string? ToString()
    {
        return base.ToString();
    }*/
}
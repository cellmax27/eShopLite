using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DataEntities;

public sealed class AuditLog
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("details")]
    public string? Details { get; set; }
}

[JsonSerializable(typeof(List<AuditLog>))]
public sealed partial class AuditLogSerializerContext : JsonSerializerContext
{/*
    private readonly JsonSerializerOptions _options;

    // Fix for CS7036 and IDE0290: Use the base constructor and remove redundant field initialization
    public AuditLogSerializerContext(JsonSerializerOptions? options = null) : base(options ?? new JsonSerializerOptions())
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
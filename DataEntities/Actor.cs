using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
namespace DataEntities;

public sealed class Actor
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("profile_path")]
    private string? Profile_path { get; set; }

    [JsonPropertyName("caracter")]
    private string? Caracter { get; set; }
}

[JsonSerializable(typeof(List<Actor>))]
public sealed partial class ActorSerializerContext : JsonSerializerContext
{/*
    private readonly JsonSerializerOptions _options;

    // Fix for CS7036 and IDE0290: Use the base constructor and remove redundant field initialization
    public ActorSerializerContext(JsonSerializerOptions? options = null) : base(options ?? new JsonSerializerOptions())
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
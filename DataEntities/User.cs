using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DataEntities;

public sealed class User
{
    [Key]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    [MaxLength(20)]
    public string? Name { get; set; }

    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("adresse")]
    public string? Adresse { get; set; }

    [JsonPropertyName("password")]
    public string? Password { get; set; }
}

[JsonSerializable(typeof(List<User>))]
public sealed partial class UserSerializerContext : JsonSerializerContext
{/*
    private readonly JsonSerializerOptions _options;

    // Fix for CS7036 and IDE0290: Use the base constructor and remove redundant field initialization
    public UserSerializerContext(JsonSerializerOptions? options = null) : base(options ?? new JsonSerializerOptions())
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
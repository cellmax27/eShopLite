using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Actor
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string? name { get; set; }

    [JsonPropertyName("profile_path")]
    private string? profile_path { get; set; }

    [JsonPropertyName("caracter")]
    private string? caracter { get; set; }
}

[JsonSerializable(typeof(List<Actor>))]
public sealed partial class ActorSerializerContext : JsonSerializerContext
{
}
using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Actor
{
    [JsonPropertyName("name")]
    private String name { get; set; }

    [JsonPropertyName("profile_path")]
    private String profile_path { get; set; }

    // In MySQL, CHARACTER is a reserved keyword
    [JsonPropertyName("caracter")]
    private String caracter { get; set; }
}

[JsonSerializable(typeof(List<Actor>))]
public sealed partial class ActorSerializerContext : JsonSerializerContext
{
}
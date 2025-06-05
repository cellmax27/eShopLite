using System.Text.Json.Serialization;

namespace DataEntities;

public class User
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
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
{
}
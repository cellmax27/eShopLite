using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Customer {
    [JsonPropertyName("id")]
    public long id { get; set; }

    [JsonPropertyName("name")]
    public string? name { get; set; }

    [JsonPropertyName("profile_path")]
    public string? profile_path { get; set; }

    [JsonPropertyName("caracter")]
    public string? caracter { get; set; }

    [JsonPropertyName("contactEmail")]
    public string? contactEmail { get; set; }
}

[JsonSerializable(typeof(List<Customer>))]
public sealed partial class CustomerSerializerContext : JsonSerializerContext
{
}
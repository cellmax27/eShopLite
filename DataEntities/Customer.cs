using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Customer {
    [JsonPropertyName("name")]
    public String name { get; set; }

    [JsonPropertyName("profile_path")]
    public String profile_path { get; set; }

    [JsonPropertyName("caracter")]
    public String caracter { get; set; }

    [JsonPropertyName("contactEmail")]
    public String contactEmail { get; set; }
}

[JsonSerializable(typeof(List<Customer>))]
public sealed partial class CustomerSerializerContext : JsonSerializerContext
{
}
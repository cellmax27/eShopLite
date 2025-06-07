using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Supplier {
    [JsonPropertyName("name")]
    public String name  { get; set; }

    [JsonPropertyName("profile_path")]
    public String profile_path  { get; set; }

    [JsonPropertyName("caracter")]
    public String caracter  { get; set; }

    [JsonPropertyName("idcontactEmail)]
    public String contactEmail { get; set; }

    [JsonPropertyName("phoneNumber")]
    public String phoneNumber { get; set; }

    [JsonPropertyName("address")]
    public String address { get; set; }
	
}

[JsonSerializable(typeof(List<Supplier>))]
public sealed partial class SupplierSerializerContext : JsonSerializerContext
{
}
using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Supplier
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string name  { get; set; }

    [JsonPropertyName("profile_path")]
    public string profile_path  { get; set; }

    [JsonPropertyName("caracter")]
    public string caracter  { get; set; }

    [JsonPropertyName("contactEmail")]
    public string contactEmail { get; set; }

    [JsonPropertyName("phoneNumber")]
    public string phoneNumber { get; set; }

    [JsonPropertyName("address")]
    public string address { get; set; }
	
}

[JsonSerializable(typeof(List<Supplier>))]
public sealed partial class SupplierSerializerContext : JsonSerializerContext
{
}
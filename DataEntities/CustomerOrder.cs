using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class CustomerOrder {
    [JsonPropertyName("id")]
    public string? name { get; set; }
    [JsonPropertyName("id")]
    public long petId { get; set; }
    [JsonPropertyName("id")]
    public int quantity { get; set; }
    [JsonPropertyName("id")]
    public DateTime shipDate { get; set; }
    [JsonPropertyName("id")]
    public DateTime date { get; set; }
    [JsonPropertyName("id")]
    public string? status { get; set; }
    [JsonPropertyName("id")]
    public bool complete { get; set; }
    [JsonPropertyName("id")]
    private Customer? customer { get; set; }

}

[JsonSerializable(typeof(List<CustomerOrder>))]
public sealed partial class CustomerOrderSerializerContext : JsonSerializerContext
{
}
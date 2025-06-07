using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class CustomerOrder {
    [JsonPropertyName("id")]
    public String name { get; set; }
    [JsonPropertyName("id")]
    public Long petId { get; set; }
    [JsonPropertyName("id")]
    public Integer quantity { get; set; }
    [JsonPropertyName("id")]
    public LocalDateTime shipDate { get; set; }
    [JsonPropertyName("id")]
    public LocalDateTime date { get; set; }
    [JsonPropertyName("id")]
    public String status { get; set; }
    [JsonPropertyName("id")]
    public Boolean complete { get; set; }
    [JsonPropertyName("id")]
    private Customer customer { get; set; }

}

[JsonSerializable(typeof(List<CustomerOrder>))]
public sealed partial class CustomerOrderSerializerContext : JsonSerializerContext
{
}
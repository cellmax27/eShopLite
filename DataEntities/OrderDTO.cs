using System.Text.Json.Serialization;

namespace DataEntities;

public class Order {
    [JsonPropertyName("id")]
    public int Id { get; set; }
    public string? name { get; set; }
    public long petId { get; set; }
    public int quantity { get; set; }
    public DateTime shipDate { get; set; }
}
[JsonSerializable(typeof(List<Order>))]
public sealed partial class OrderSerializerContext : JsonSerializerContext
{
}
using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Invoice
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("totalAmount")]
    public double TotalAmount { get; set; }

    [JsonPropertyName("issuedDate")]
    private DateTime IssuedDate { get; set; }

    [JsonPropertyName("appointments")]
    private List<Appointement>? Appointments { get; set; }

    [JsonPropertyName("client")]
    private string? Client { get; set; }

}

[JsonSerializable(typeof(List<Invoice>))]
public sealed partial class InvoiceSerializerContext : JsonSerializerContext
{
}
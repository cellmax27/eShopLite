using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Invoice
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("number")]
    public string? number { get; set; }

    [JsonPropertyName("status")]
    public string? status { get; set; }

    [JsonPropertyName("totalAmount")]
    public double totalAmount { get; set; }

    [JsonPropertyName("issuedDate")]
    private DateTime issuedDate { get; set; }

    [JsonPropertyName("appointments")]
    private List<Appointement> appointments { get; set; }

    [JsonPropertyName("client")]
    private string client { get; set; }

    //    id:
    //        type: string
    //    client:
    //        type: string

}

[JsonSerializable(typeof(List<Invoice>))]
public sealed partial class InvoiceSerializerContext : JsonSerializerContext
{
}
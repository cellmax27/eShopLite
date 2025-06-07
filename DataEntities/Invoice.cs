using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Invoice {
    [JsonPropertyName("number")]
    public String number { get; set; }

    [JsonPropertyName("status")]
    public String status { get; set; }

    [JsonPropertyName("totalAmount")]
    public double totalAmount { get; set; }

    [JsonPropertyName("issuedDate")]
    private LocalDateTime issuedDate { get; set; }

    [JsonPropertyName("appointments")]
    private List<Appointement> appointments { get; set; }

    [JsonPropertyName("client")]
    private String client { get; set; }

    //    id:
    //        type: string
    //    client:
    //        type: string

}

[JsonSerializable(typeof(List<Invoice>))]
public sealed partial class InvoiceSerializerContext : JsonSerializerContext
{
}
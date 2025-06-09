using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Appointement
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("start")]
    private DateTime start { get; set; }

    [JsonPropertyName("end")]
    private DateTime end { get; set; }

    [JsonPropertyName("canceledAt")]
    private DateTime canceledAt { get; set; }

//    @OneToOne
//    @JoinColumn(name = "id_canceler")
//private User canceler;
//

    private AppointementStatus status { get; set; }

    [JsonPropertyName("customer")]
    private Customer customer { get; set; }

    [JsonPropertyName("provider")]
    private Supplier provider { get; set; }

    [JsonPropertyName("work")]
    private Work work { get; set; }

    //[JsonPropertyName("profile_path")]
    //@OneToMany(mappedBy = "appointment")
    //private List<ChatMessage> chatMessages;

    [JsonPropertyName("invoice")]
    private Invoice invoice { get; set; }

    //[JsonPropertyName("profile_path")]
//@OneToOne(mappedBy = "requested", cascade = {CascadeType.ALL})
//private ExchangeRequest exchangeRequest;

}

[JsonSerializable(typeof(List<Appointement>))]
public sealed partial class AppointementSerializerContext : JsonSerializerContext
{
}
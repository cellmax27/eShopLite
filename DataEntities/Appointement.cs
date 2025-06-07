using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Appointement {
    [JsonPropertyName("profile_path")]
    private LocalDateTime start { get; set; }

    [JsonPropertyName("profile_path")]
    private LocalDateTime end { get; set; }

    [JsonPropertyName("profile_path")]
    private LocalDateTime canceledAt { get; set; }

//    @OneToOne
//    @JoinColumn(name = "id_canceler")
//private User canceler;
//

private AppointementStatus status { get; set; }

    [JsonPropertyName("profile_path")]
    private Customer customer { get; set; }

    [JsonPropertyName("profile_path")]
    private Supplier provider { get; set; }

    [JsonPropertyName("profile_path")]
    private Work work { get; set; }

    [JsonPropertyName("profile_path")]
    //@OneToMany(mappedBy = "appointment")
    //private List<ChatMessage> chatMessages;

    [JsonPropertyName("profile_path")]
    private Invoice invoice { get; set; }

    //[JsonPropertyName("profile_path")]
//@OneToOne(mappedBy = "requested", cascade = {CascadeType.ALL})
//private ExchangeRequest exchangeRequest;

}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class AccountSerializerContext : JsonSerializerContext
{
}
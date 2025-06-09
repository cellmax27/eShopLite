using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DataEntities;

public sealed class Appointement
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("start")]
    private DateTime Start { get; set; }

    [JsonPropertyName("end")]
    private DateTime End { get; set; }

    [JsonPropertyName("canceledAt")]
    private DateTime CanceledAt { get; set; }

//    @OneToOne
//    @JoinColumn(name = "id_canceler")
//private User canceler;
//

    private AppointementStatus Status { get; set; }

    [JsonPropertyName("customer")]
    private Customer? Customer { get; set; }

    [JsonPropertyName("provider")]
    private Supplier? Provider { get; set; }

    [JsonPropertyName("work")]
    private Work? Work { get; set; }

    //[JsonPropertyName("profile_path")]
    //@OneToMany(mappedBy = "appointment")
    //private List<ChatMessage> chatMessages;

    [JsonPropertyName("invoice")]
    private Invoice? Invoice { get; set; }

    //[JsonPropertyName("profile_path")]
//@OneToOne(mappedBy = "requested", cascade = {CascadeType.ALL})
//private ExchangeRequest exchangeRequest;

}

[JsonSerializable(typeof(List<Appointement>))]
public sealed partial class AppointementSerializerContext : JsonSerializerContext
{/*
    private readonly JsonSerializerOptions _options;

    // Fix for CS7036 and IDE0290: Use the base constructor and remove redundant field initialization
    public AppointementSerializerContext(JsonSerializerOptions? options = null) : base(options ?? new JsonSerializerOptions())
    {
        _options = options ?? new JsonSerializerOptions();
    }

    protected override JsonSerializerOptions GeneratedSerializerOptions => _options;

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        if (type == typeof(List<User>))
        {
            return JsonTypeInfo.CreateJsonTypeInfo<List<User>>(_options);
        }

        return null;
    }

    public override string? ToString()
    {
        return base.ToString();
    }*/
}
using System.Text.Json.Serialization;
using DataEntities;

namespace DataEntities;

public sealed class Account {
    [JsonPropertyName("accountNumber")]
    public String accountNumber { get; set; }

    [JsonPropertyName("balance")]
    public BigDecimal balance { get; set; }

    [JsonPropertyName("accountType")]
    public AccountType accountType { get; set; }

    [JsonPropertyName("id")]
    public String accountType { get; set; } // e.g., CHECKING, SAVINGS { get; set; }

    [JsonPropertyName("owner")]
    public User owner { get; set; }

    [JsonPropertyName("transactions")]
    public List<Transaction> transactions { get; set; }

    //[JsonPropertyName("id")]
    CustomerOrder { get; set; } 

}

[JsonSerializable(typeof(List<Account>))]
public sealed partial class AccountSerializerContext : JsonSerializerContext
{
}
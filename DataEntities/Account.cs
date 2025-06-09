using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Account
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("accountNumber")]
    public string? accountNumber { get; set; }

    [JsonPropertyName("balance")]
    public decimal balance { get; set; }

    [JsonPropertyName("accountType")]
    //public AccountType accountType { get; set; }
    public string? accountType { get; set; } // e.g., CHECKING, SAVINGS { get; set; }

    [JsonPropertyName("owner")]
    public User? owner { get; set; }

    [JsonPropertyName("transactions")]
    public List<Transaction>? transactions { get; set; }

    [JsonPropertyName("customerOrder")]
    CustomerOrder? customerOrder { get; set; } 

}

[JsonSerializable(typeof(List<Account>))]
public sealed partial class AccountSerializerContext : JsonSerializerContext
{
}
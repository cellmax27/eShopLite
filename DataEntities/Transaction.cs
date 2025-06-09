using DataEntities;

using System.Text.Json.Serialization;

namespace DataEntities;e;

public sealed class Transaction
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("id")]
    public DateTime transactionDate { get; set; }
    
    [JsonPropertyName("amount")]
    public decimal amount { get; set; }
    
    [JsonPropertyName("type")]
    public string type; // e.g., DEPOSIT, WITHDRAWAL, TRANSFER

    [JsonPropertyName("description")]
    public string description { get; set; }

    //@ManyToOne(fetch = FetchType.LAZY)
    /// <summary>
    /// @JoinColumn(name = "account_id", nullable = false)
    /// </summary>
     [JsonPropertyName("account")]
    public Account account { get; set; }

}

[JsonSerializable(typeof(List<Transaction>))]
public sealed partial class TransactionSerializerContext : JsonSerializerContext
{
}
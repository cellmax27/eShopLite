using DataEntities;

using System.Text.Json.Serialization;

namespace DataEntities;e;

public sealed class Transaction {
    
    [JsonPropertyName("id")]
    public LocalDateTime transactionDate { get; set; }
    
    [JsonPropertyName("amount")]
    public BigDecimal amount { get; set; }
    
    [JsonPropertyName("type")]
    public String type; // e.g., DEPOSIT, WITHDRAWAL, TRANSFER

    [JsonPropertyName("description")]
    public String description { get; set; }

    //@ManyToOne(fetch = FetchType.LAZY)
    /// <summary>
    /// @JoinColumn(name = "account_id", nullable = false)
    /// </summary>
    /// [JsonPropertyName("id")]
    public Account account { get; set; }

}

[JsonSerializable(typeof(List<Transaction>))]
public sealed partial class TransactionSerializerContext : JsonSerializerContext
{
}
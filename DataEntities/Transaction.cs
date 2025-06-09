using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using DataEntities;

namespace DataEntities;

public sealed class Transaction
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("id")]
    public DateTime TransactionDate { get; set; }
    
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type; // e.g., DEPOSIT, WITHDRAWAL, TRANSFER

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    //@ManyToOne(fetch = FetchType.LAZY)
    /// <summary>
    /// @JoinColumn(name = "account_id", nullable = false)
    /// </summary>
     [JsonPropertyName("account")]
    public Account? Account { get; set; }

}

[JsonSerializable(typeof(List<Transaction>))]
public sealed partial class TransactionSerializerContext : JsonSerializerContext
{/*
    private readonly JsonSerializerOptions _options;

    // Fix for CS7036 and IDE0290: Use the base constructor and remove redundant field initialization
    public TransactionSerializerContext(JsonSerializerOptions? options = null) : base(options ?? new JsonSerializerOptions())
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
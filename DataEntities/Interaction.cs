using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Interaction {

    // --- Champs Obligatoires ---
    [JsonPropertyName("UserId")]
    public long UserId { get; set; }

    [JsonPropertyName("ItemId")]
    public long ItemId { get; set; }

    [JsonPropertyName("Type")]
    //@Enumerated(EnumType.STRING) // Stocke le nom de l'enum ("VIEW", "CLICK", etc.) plutôt que son ordinal
    public InteractionType Type { get; set; }

    [JsonPropertyName("Timestamp")]
    public DateTime Timestamp { get; set; }

    // --- Champ Optionnel ---
    [JsonPropertyName("Value")]
    public double Value { get; set; }  // Pour les interactions avec une valeur (ex: note de 1 à 5)

    // --- Enum interne pour les types d'interaction ---
    public enum InteractionType {
        VIEW, 
        CLICK,
        RATING,
        PURCHASE,
        ADD_TO_CART
    }

}

[JsonSerializable(typeof(List<Interaction>))]
public sealed partial class InteractionSerializerContext : JsonSerializerContext
{
}
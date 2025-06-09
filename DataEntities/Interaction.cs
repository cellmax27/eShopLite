using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Interaction {

    // --- Champs Obligatoires ---
    [JsonPropertyName("id")]
    public long userId { get; set; }

    [JsonPropertyName("id")]
    public long itemId { get; set; }

    [JsonPropertyName("id")]
    //@Enumerated(EnumType.STRING) // Stocke le nom de l'enum ("VIEW", "CLICK", etc.) plutôt que son ordinal
    public InteractionType type { get; set; }

    [JsonPropertyName("id")]
    public DateTime timestamp { get; set; }

    // --- Champ Optionnel ---
    [JsonPropertyName("id")]
    public double value { get; set; }  // Pour les interactions avec une valeur (ex: note de 1 à 5)

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
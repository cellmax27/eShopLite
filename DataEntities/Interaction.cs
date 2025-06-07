using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Interaction {

    // --- Champs Obligatoires ---
    [JsonPropertyName("id")]
    public Long userId { get; set; }

    [JsonPropertyName("id")]
    public Long itemId { get; set; }

    [JsonPropertyName("id")]
    //@Enumerated(EnumType.STRING) // Stocke le nom de l'enum ("VIEW", "CLICK", etc.) plutôt que son ordinal
    public InteractionType type { get; set; }

    [JsonPropertyName("id")]
    public LocalDateTime timestamp { get; set; }

    // --- Champ Optionnel ---
    [JsonPropertyName("id")]
    public Double value { get; set; }  // Pour les interactions avec une valeur (ex: note de 1 à 5)

    // --- Enum interne pour les types d'interaction ---
    public enum InteractionType {
        VIEW, 
        CLICK,
        RATING,
        PURCHASE,
        ADD_TO_CART
    }

    // --- Méthode de cycle de vie JPA ---

    @PrePersist // Méthode appelée avant que l'entité ne soit persistée pour la première fois
    void onPrePersist() {
        if (this.timestamp == null) {
            this.timestamp = LocalDateTime.now(); // Définit le timestamp actuel si non fourni
        }
    }

    // --- Méthodes utilitaires (Optionnel) ---
    // Vous pouvez ajouter d'autres méthodes si besoin
    // Exemple: toString() pour le logging
    @Override
    public String toString() {
        return "Interaction{" +
               "id=" + id + // id vient de PanacheEntity
               ", userId=" + userId +
               ", itemId=" + itemId +
               ", type=" + type +
               ", timestamp=" + timestamp +
               ", value=" + value +
               '}';
    }
}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class AccountSerializerContext : JsonSerializerContext
{
}
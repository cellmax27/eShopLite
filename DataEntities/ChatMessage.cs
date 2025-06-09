

using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class ChatMessage
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; } // Ex: 'MESSAGE', 'USER_JOINED', 'USER_LEFT', 'ERROR'

    [JsonPropertyName("username")]
    public string? Username { get; set; } // Qui envoie le message

    [JsonPropertyName("recipient")] // Optionnel: pour messages directs (non utilisé dans cet ex. simple)\r\n")]
    public string? Recipient { get; set; } // Optionnel: pour messages directs (non utilisé dans cet ex. simple)

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; } //DateTime utcNow = DateTime.UtcNow; // Équivalent de Instant.now() en Java
//TODO DateTimeOffset offsetNow = DateTimeOffset.UtcNow; // Avec fuseau horaire

//using NodaTime;
//Instant now = SystemClock.Instance.GetCurrentInstant();

    /*
    public ChatMessage() {
        this.timestamp = DateTime.Now;
    }

    public ChatMessage(String type, String username, String content) {
        this(); // initialiser le timestamp
        this.type = type;
        this.username = username;
        this.content = content;
    }

     public ChatMessage(String type, String username, String content, String recipient) {
        this(type, username, content);
        this.recipient = recipient;
    }
    */
}
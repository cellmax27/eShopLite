

using System.Text.Json.Serialization;

public sealed class ChatMessage
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string type { get; set; } // Ex: 'MESSAGE', 'USER_JOINED', 'USER_LEFT', 'ERROR'

    [JsonPropertyName("username")]
    public string username { get; set; }; // Qui envoie le message

    [JsonPropertyName("recipient")] // Optionnel: pour messages directs (non utilisé dans cet ex. simple)\r\n")]
    public string recipient { get; set; } // Optionnel: pour messages directs (non utilisé dans cet ex. simple)

    [JsonPropertyName("content")]
    public string content { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime timestamp { get; set; } //DateTime utcNow = DateTime.UtcNow; // Équivalent de Instant.now() en Java
//TODO DateTimeOffset offsetNow = DateTimeOffset.UtcNow; // Avec fuseau horaire

//using NodaTime;
//Instant now = SystemClock.Instance.GetCurrentInstant();


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

    // Getters et Setters si nécessaires (Jackson/JSON-B les utilisent)
    // Ou rendre les champs publics si la simplicité prime pour l'exemple

    @Override
    public String toString() {
        return "ChatMessage{" +
               "type='" + type + '\'' +
               ", username='" + username + '\'' +
               ", recipient='" + recipient + '\'' +
               ", content='" + content + '\'' +
               ", timestamp=" + timestamp +
               '}';
    }
}
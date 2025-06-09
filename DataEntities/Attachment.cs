using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DataEntities;

public sealed class Attachment
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    [JsonPropertyName("data")]
    public byte[]? Data { get; set; }

    [JsonPropertyName("filename")]
    /*     @ManyToOne
        public Email email;  { get; set; }*/
    //private String id; // ID unique pour le téléchargement
    private string? Filename { get; set; }

    [JsonPropertyName("contentType")]
    private string? ContentType { get; set; }

    [JsonPropertyName("size")]
    private long Size { get; set; } // Taille en octets

}

[JsonSerializable(typeof(List<Attachment>))]
public sealed partial class AttachmentLogSerializerContext : JsonSerializerContext
{
}
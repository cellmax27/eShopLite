using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Attachment
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("fileName")]
    public string? fileName { get; set; }

    [JsonPropertyName("iddata)]
    public byte[]? data { get; set; }

    [JsonPropertyName("filename")]
    /*     @ManyToOne
        public Email email;  { get; set; }*/
    //private String id; // ID unique pour le téléchargement
    private string? filename { get; set; }

    [JsonPropertyName("contentType")]
    private string? contentType { get; set; }

    [JsonPropertyName("size")]
    private long size { get; set; } // Taille en octets

}

[JsonSerializable(typeof(List<Attachment>))]
public sealed partial class AttachmentSerializerContext : JsonSerializerContext
{
}
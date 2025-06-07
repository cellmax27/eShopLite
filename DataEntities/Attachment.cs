using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Attachment  {
    public String fileName; { get; set; }
    public byte[] data; { get; set; }
/*     @ManyToOne
    public Email email;  { get; set; }*/
//private String id; // ID unique pour le téléchargement
    private String filename { get; set; };
    private String contentType { get; set; };
    private long size { get; set; }; // Taille en octets

}

[JsonSerializable(typeof(List<Attachment>))]
public sealed partial class AttachmentSerializerContext : JsonSerializerContext
{
}
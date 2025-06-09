using System.Text.Json.Serialization;

namespace DataEntities;

public class CsvUploadMetadata
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("accountNumber")]
    public string? TableName { get; set; }

    [JsonPropertyName("accountNumber")]
    public DateTime UploadTime { get; set; }

    [JsonPropertyName("accountNumber")]
    public int RecordCount { get; set; }
}

[JsonSerializable(typeof(List<CsvUploadMetadata>))]
public sealed partial class CsvUploadMetadataSerializerContext : JsonSerializerContext
{
}
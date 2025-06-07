using System.Text.Json.Serialization;

namespace DataEntities;

public class CsvUploadMetadata {
    [JsonPropertyName("accountNumber")]
    public String tableName { get; set; }

    [JsonPropertyName("accountNumber")]
    public LocalDateTime uploadTime { get; set; }

    [JsonPropertyName("accountNumber")]
    public int recordCount { get; set; }
}

[JsonSerializable(typeof(List<CsvUploadMetadata>))]
public sealed partial class CsvUploadMetadataSerializerContext : JsonSerializerContext
{
}
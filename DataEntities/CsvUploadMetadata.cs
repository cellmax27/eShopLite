using System.Text.Json.Serialization;

namespace DataEntities;

public class CsvUploadMetadata
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("accountNumber")]
    public string tableName { get; set; }

    [JsonPropertyName("accountNumber")]
    public DateTime uploadTime { get; set; }

    [JsonPropertyName("accountNumber")]
    public int recordCount { get; set; }
}

[JsonSerializable(typeof(List<CsvUploadMetadata>))]
public sealed partial class CsvUploadMetadataSerializerContext : JsonSerializerContext
{
}
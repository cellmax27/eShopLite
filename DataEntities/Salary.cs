using DataEntities;

using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Salary {
    [JsonPropertyName("name")]
    public String name { get; set; }

    [JsonPropertyName("profile_path")]
    public String profile_path { get; set; }

    [JsonPropertyName("caracter")]
    public String caracter { get; set; }
}

[JsonSerializable(typeof(List<Salary>))]
public sealed partial class SalarySerializerContext : JsonSerializerContext
{
}
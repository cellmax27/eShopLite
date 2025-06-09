using DataEntities;

using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Salary
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("profile_path")]
    public string profile_path { get; set; }

    [JsonPropertyName("caracter")]
    public string caracter { get; set; }
}

[JsonSerializable(typeof(List<Salary>))]
public sealed partial class SalarySerializerContext : JsonSerializerContext
{
}
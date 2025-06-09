using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class DayPlan
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("profile_path")]
    public string profile_path { get; set; }
    // In MySQL, CHARACTER is a reserved keyword

    [JsonPropertyName("caracter")]
    public string caracter { get; set; }

    [JsonPropertyName("status")]
    public Status status{ get; set; }
	
	// put your custom logic here as instance methods

}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class FruitSerializerContext : JsonSerializerContext
{
}
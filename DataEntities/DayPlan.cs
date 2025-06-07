using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class DayPlan {
    [JsonPropertyName("name")]
    public String name { get; set; }

    [JsonPropertyName("profile_path")]
    public String profile_path { get; set; }
    // In MySQL, CHARACTER is a reserved keyword

    [JsonPropertyName("caracter")]
    public String caracter{ get; set; }

    [JsonPropertyName("status")]
    public Status status{ get; set; }
	
	// put your custom logic here as instance methods

}

[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class FruitSerializerContext : JsonSerializerContext
{
}
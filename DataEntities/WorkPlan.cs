using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class WorkPlan
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("id")]
    private Supplier provider { get; set; }

    [JsonPropertyName("monday")]
    private DayPlan monday { get; set; }

    [JsonPropertyName("tuesday")]
    private DayPlan tuesday { get; set; }

    [JsonPropertyName("wednesday")]
    private DayPlan wednesday { get; set; }

    [JsonPropertyName("thursday")]
    private DayPlan thursday;{ get; set; }

    [JsonPropertyName("friday")]
    private DayPlan friday { get; set; }

    [JsonPropertyName("saturday")]
    private DayPlan saturday { get; set; }

    [JsonPropertyName("sunday")]
    private DayPlan sunday { get; set; }

}

[JsonSerializable(typeof(List<WorkPlan>))]
public sealed partial class WorkPlanSerializerContext : JsonSerializerContext
{
}
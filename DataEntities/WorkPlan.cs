using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace DataEntities;

public sealed class WorkPlan
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("id")]
    private Supplier? Provider { get; set; }

    [JsonPropertyName("monday")]
    private DayPlan? Monday { get; set; }

    [JsonPropertyName("tuesday")]
    private DayPlan? Tuesday { get; set; }

    [JsonPropertyName("wednesday")]
    private DayPlan? Wednesday { get; set; }

    [JsonPropertyName("thursday")]
    private DayPlan? Thursday { get; set; }

    [JsonPropertyName("friday")]
    private DayPlan? Friday { get; set; }

    [JsonPropertyName("saturday")]
    private DayPlan? Saturday { get; set; }

    [JsonPropertyName("sunday")]
    private DayPlan? Sunday { get; set; }

}

[JsonSerializable(typeof(List<WorkPlan>))]
public sealed partial class WorkPlanSerializerContext : JsonSerializerContext
{/*
    private readonly JsonSerializerOptions _options;

    // Fix for CS7036 and IDE0290: Use the base constructor and remove redundant field initialization
    public WorkPlanSerializerContext(JsonSerializerOptions? options = null) : base(options ?? new JsonSerializerOptions())
    {
        _options = options ?? new JsonSerializerOptions();
    }

    protected override JsonSerializerOptions GeneratedSerializerOptions => _options;

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        if (type == typeof(List<User>))
        {
            return JsonTypeInfo.CreateJsonTypeInfo<List<User>>(_options);
        }

        return null;
    }

    public override string? ToString()
    {
        return base.ToString();
    }*/
}
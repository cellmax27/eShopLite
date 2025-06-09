using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Work
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    
    private string? Name { get; set; }
    [JsonPropertyName("description")]
    
    private string? Description { get; set; }

    [JsonPropertyName("price")]
    
    private double Price { get; set; }
    [JsonPropertyName("duration")]
    
    private int Duration { get; set; }
    [JsonPropertyName("editable")]
    
    private bool Editable { get; set; }
    [JsonPropertyName("targetCustomer")]
    
    private string? TargetCustomer { get; set; }

    //@ManyToMany
    //@JoinTable(name = "works_providers", joinColumns = @JoinColumn(name = "id_work"), inverseJoinColumns = @JoinColumn(name = "id_user"))
    //private List<User> providers;{ get; set; }
	
}

[JsonSerializable(typeof(List<Work>))]
public sealed partial class WorkSerializerContext : JsonSerializerContext
{
}
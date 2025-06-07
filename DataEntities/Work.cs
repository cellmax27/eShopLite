using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Work {
    [JsonPropertyName("name")]
    
    private String name { get; set; }
    [JsonPropertyName("description")]
    
    private String description { get; set; }
    [JsonPropertyName("price")]
    
    private double price { get; set; }
    [JsonPropertyName("duration")]
    
    private int duration { get; set; }
    [JsonPropertyName("editable")]
    
    private boolean editable { get; set; }
    [JsonPropertyName("targetCustomer")]
    
    private String targetCustomer { get; set; }

    //@ManyToMany
    //@JoinTable(name = "works_providers", joinColumns = @JoinColumn(name = "id_work"), inverseJoinColumns = @JoinColumn(name = "id_user"))
    //private List<User> providers;{ get; set; }
	
}

[JsonSerializable(typeof(List<Work>))]
public sealed partial class WorkSerializerContext : JsonSerializerContext
{
}
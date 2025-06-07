using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Movie {
    //@NotBlank(message = "Title cannot be blank")
    [JsonPropertyName("name")]
    public String name { get; set; }

    [JsonPropertyName("birth")]
    public LocalDate birth { get; set; }

    [JsonPropertyName("status")]
    public Status status { get; set; }

    // TODO maj API file
    [JsonPropertyName("adult")]
    public boolean adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public String backdrop_path { get; set; }

    [JsonPropertyName("genre_ids")]
    public Long[] genre_ids { get; set; }

    [JsonPropertyName("original_language")]
    public String original_language { get; set; }

    [JsonPropertyName("original_title")]
    public String original_title { get; set; }

    [JsonPropertyName("overview")]
    public String overview { get; set; }

    //@Min(message = "Author has been very lazy", value = 1)
    [JsonPropertyName("popularity")]
    public Long popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public String poster_path { get; set; }

    [JsonPropertyName("release_date")]
    public LocalDate release_date { get; set; }

    [JsonPropertyName("title")]
    public String title { get; set; }

    [JsonPropertyName("video")]
    public boolean video { get; set; }

    [JsonPropertyName("vote_average")]
    public Long vote_average { get; set; }

    [JsonPropertyName("vote_count")]
    public Long vote_count { get; set; }
//    public Long revenue?; //: number;
//    public String runtime?; //: string;

	// public Long[Genre] genres?; //: any[];

	// csharp
//    public string Director { get; set; }
//    public List<string> Actors { get; set; }
//    public double Rating { get; set; }
//    public string Description { get; set; }
//    public string Language { get; set; }
//    public int Duration { get; set; } // Duration in minutes
//    public string Country { get; set; }
//    public bool IsAvailableOnNetflix { get; set; }


}

[JsonSerializable(typeof(List<Movie>))]
public sealed partial class MovieSerializerContext : JsonSerializerContext
{
}
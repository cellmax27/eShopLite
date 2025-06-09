using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class Movie
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("birth")]
    public DateTime Birth { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("genre_ids")]
    public long[]? GenreIds { get; set; }

    [JsonPropertyName("original_language")]
    public string? OriginalLanguage { get; set; }

    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }

    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    [JsonPropertyName("popularity")]
    public long Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }

    [JsonPropertyName("release_date")]
    public DateTime ReleaseDate { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("video")]
    public bool Video { get; set; }

    [JsonPropertyName("vote_average")]
    public long VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public long VoteCount { get; set; }

    // Propriétés supplémentaires commentées pour référence future
    // public long? Revenue { get; set; }
    // public string Runtime { get; set; }
    // public List<Genre> Genres { get; set; }
    // public string Director { get; set; }
    // public List<string> Actors { get; set; }
    // public double Rating { get; set; }
    // public string Description { get; set; }
    // public string Language { get; set; }
    // public int Duration { get; set; }
    // public string Country { get; set; }
    // public bool IsAvailableOnNetflix { get; set; }
}

[JsonSerializable(typeof(List<Movie>))]
public sealed partial class MovieSerializerContext : JsonSerializerContext
{
}
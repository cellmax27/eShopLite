namespace EshopController;

    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using DataEntities;

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies =
        [
            new Movie
            {
                Id = 1,
                Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16),
                OriginalTitle = "Inception",
                OriginalLanguage = "en",
                Overview = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                VoteAverage = 88,
                VoteCount = 10000,
                Popularity = 1000,
                Status = Status.AVAILABLE,
                Adult = false,
                Video = false,
                BackdropPath = "/s3TBrRGB1iav7gFOCNx3H31MoES.jpg",
                PosterPath = "/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg",
                GenreIds = [878, 28, 12]
            }
        ];

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost]
        public ActionResult<Movie> CreateMovie(Movie movie)
        {
            movie.Id = movies.Count != 0 ? movies.Max(m => m.Id) + 1 : 1;
            movies.Add(movie);
            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, Movie updatedMovie)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            movie.Title = updatedMovie.Title;
            movie.ReleaseDate = updatedMovie.ReleaseDate;
            movie.OriginalTitle = updatedMovie.OriginalTitle;
            movie.OriginalLanguage = updatedMovie.OriginalLanguage;
            movie.Overview = updatedMovie.Overview;
            movie.VoteAverage = updatedMovie.VoteAverage;
            movie.VoteCount = updatedMovie.VoteCount;
            movie.Popularity = updatedMovie.Popularity;
            movie.Status = updatedMovie.Status;
            movie.Adult = updatedMovie.Adult;
            movie.Video = updatedMovie.Video;
            movie.BackdropPath = updatedMovie.BackdropPath;
            movie.PosterPath = updatedMovie.PosterPath;
            movie.GenreIds = updatedMovie.GenreIds;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            movies.Remove(movie);
            return NoContent();
        }
    }

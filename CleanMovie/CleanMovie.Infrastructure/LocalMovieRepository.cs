using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure
{
    public class LocalMovieRepository : IMovieRepository
    {
        private static List<Movie> _movies = new List<Movie>()
        {
            new Movie { MovieId = 1, MovieName = "Shutter Island", RentalCost = 0.99m },
            new Movie { MovieId = 2, MovieName = "Titanic", RentalCost = 0.49m },
        };

        public Movie CreateMovie(Movie movie)
        {
            _movies.Add(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movies;
        }
    }
}

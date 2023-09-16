using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private static List<Movie> _movies = new List<Movie>()
        {
            new Movie { Id = 1, Name = "Shutter Island", Cost = 0.99m },
            new Movie { Id = 2, Name = "Titanic", Cost = 0.49m },
        };

        public List<Movie> GetAllMovies()
        {
            return _movies;
        }
    }
}

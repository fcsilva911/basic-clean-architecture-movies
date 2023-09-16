using CleanMovie.Domain;

namespace CleanMovie.Application
{
    // This is the use-cases
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}

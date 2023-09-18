using CleanMovie.Domain;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            return _movieRepository.CreateMovie(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }
    }
}

using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/movies
        [Authorize(Roles = "ReadMovies")]
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }

        // POST: api/movies
        [Authorize(Roles = "CreateMovies")]
        [HttpPost]
        public ActionResult Post(Movie movie)
        {
            var createdMovie = _movieService.CreateMovie(movie);
            return Ok(createdMovie);
        }
    }
}

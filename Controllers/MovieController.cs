using Microsoft.AspNetCore.Mvc;
using modul10_103022300057.Models;

namespace modul10_103022300057.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> _movieList =
        [
            new Movie("The Shawshank Redemption", "Frank Darabont", ["RobbinsMorgan", "FreemanBob" , "Gunton"], "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", ["Marlon Brando", "Al Pacino", "James Caan"], "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", ["Christian Bale", "Heath Ledger", "Aaron Eckhart"], "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        ];

        // GET: api/Movie
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_movieList);
        }

        // GET: api/Movie/{index}
        [HttpGet("{index}")]
        public IActionResult Get(int index)
        {
            if (index < 0 || index >= _movieList.Count)
            {
                return NotFound("Movie not found");
            }

            return Ok(_movieList[index]);
        }

        // POST: api/Movie
        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            _movieList.Add(movie);
            return CreatedAtAction(nameof(Get), new { index = _movieList.Count - 1 }, movie);
        }

        // DELETE: api/Movie/{index}
        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= _movieList.Count)
            {
                return NotFound("Movie not found");
            }

            _movieList.RemoveAt(index);
            return NoContent();
        }
    }
}

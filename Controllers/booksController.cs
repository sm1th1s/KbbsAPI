using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace KbbsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class booksController : ControllerBase
    {
        private IConfiguration _configuration;

        public booksController(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        [HttpGet]
        [Route("getHelloWorld")] 
        public IActionResult getHelloWorld()
        {
            return Ok("hi");
        }

        [HttpGet]
        [Route("getBooks")]
        public IActionResult getBooks() {

            var books = new[]
            {
                new
                {
                    name="The Pychology of Money",
                    author = "Morgan Housel",
                    genre = "Finance",
                    blurb = "The Psychology of Money is a collection of short stories exploring the strange ways people think about money. The author presents related biases, flaws, behaviors, and attitudes that affect one's financial outcomes and shows how one's psychology can work for and against them."
                },
                new
                {
                    name = "Blue Planet",
                    author = "James Honeyborne",
                    genre = "Non-Fiction & Nature",
                    blurb = "Take a deep breath and dive into the mysteries of the Ocean as we discover a new world of hidden depths."
                },
                new
                {
                    name = "The Future of Making",
                    author = "Autodesk",
                    genre = "Technology",
                    blurb = "The Future of Making visits the frontline of innovation in how we make things, from sensors capturing the physical world in Bali in amazing detail to generative design algorithms that are providing us with new shapes to the new biological frontier of design"
                }

            };

            return Ok(books);
        }
        
    }
}

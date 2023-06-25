using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoCart.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "The Hitchikers Guide to The Galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "Ready Player One",
                Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 3,
                Title = "Nineteen Eighty-Four",
                Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                Price = 9.99m
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(Products);
        }
    }
}

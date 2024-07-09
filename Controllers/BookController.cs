using GestaoLivraria.Communication.Requests;
using GestaoLivraria.Communication.Responses;
using GestaoLivraria.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ResponseRegistredBookJson))]
        public IActionResult Create([FromBody] RequestRegisterBookJson request)
        {
            var response = new ResponseRegistredBookJson
            {
                Id = 1,
                Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                Price = request.Price,
                QuantityStock = request.QuantityStock,
            };

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Book>))]
        public IActionResult GetAll()
        {
            var response = new List<Book>()
            {
                new Book()
                {
                    Id= 1,
                    Title = "A Ilha Perdida",
                    Author = "Maria José Dupré",
                    Genre = Genre.Misterio,
                    Price = 65.99m,
                    QuantityStock = 15,
                    
                }, new Book()
                {
                    Id= 1,
                    Title = "A Turma da Rua Quinze",
                    Author = "Marçal Aquino",
                    Genre = Genre.Misterio,
                    Price = 52m,
                    QuantityStock = 43,
                    
                },
            };
            return Ok(response);
        }
        
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new Book
            {
                    Id = 1,
                    Title = "A Ilha Perdida",
                    Author = "Maria José Dupré",
                    Genre = Genre.Ficcao,
                    Price = 65.99m,
                    QuantityStock = 45,

            };
            return Ok(response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] RequestUpdateBookJson request)
        {
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteByid([FromRoute] int id) 
        { 
            return NoContent();
        }
    }
}

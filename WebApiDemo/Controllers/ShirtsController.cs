using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Filters;
using WebApiDemo.Models;
using WebApiDemo.Models.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShirtsController : ControllerBase
    {
       

        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok("Get all Shirts");
        }

        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
            //if (id <= 0) { 
            //    return BadRequest();
            //}

            //var shirt = ShirtRepository.GetShirtById(id);
            //if (shirt == null) { 
            //    return NotFound();
            //}

            //return Ok(shirt);
            
        }

        [HttpPost]
        public IActionResult CreateShirt([FromBody]Shirt shirt)
        {
            return Ok("Create Shirt");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok($"Update Shirt {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"Delete Shirt {id}");
        }
    }
}

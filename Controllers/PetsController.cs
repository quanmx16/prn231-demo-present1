using Microsoft.AspNetCore.Mvc;

namespace TestModelBinding.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PetsController : ControllerBase
    {
        //[HttpGet("{id}")]
        //public Task<string> GetById(int id, bool dogsOnly)
        //{
        //    string data = $"id: {id}, DogsOnly: {dogsOnly}";
        //    return Task.FromResult(data);
        //}   
        //[HttpGet("{id}")]
        //public Task<string> GetById([FromRoute(Name = "id")] int petId,
        //    [FromQuery(Name = "DogsOnly")] bool dogsOnly123,
        //    [FromQuery(Name = "CatsOnly")] bool catsOnly123)
        //{
        //    string data = $"id: {petId}, DogsOnly: {dogsOnly123}, CatsOnly: {catsOnly123}";
        //    return Task.FromResult(data);
        //}
        //[HttpGet("{id}")]
        //public Task<string> GetById(int id,
        //    [FromHeader(Name = "Accept")] string accept)
        //{
        //    string data = $"id: {id}, Accept: {accept}";
        //    return Task.FromResult(data);
        //}

        //[HttpPost]
        //public IActionResult ReflectPet([FromBody] Pet pet)
        //{
        //    return Ok(pet);
        //}
        [HttpPost]
        public IActionResult ReflectPet([FromForm] Pet pet)
        {
            return Ok(pet);
        }

    }
}

using Kids_Canvas.Core.Entities;
using Kids_Canvas.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api_Kids_Canvas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrowingsController : ControllerBase
    {
        // GET: api/<Drowings>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Drowings>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Drowings>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Drowings>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Drowings>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

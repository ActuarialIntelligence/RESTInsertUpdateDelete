using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AI.Web.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertUpdateReadController : ControllerBase
    {
        // GET: api/<InsertUpdateReadController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InsertUpdateReadController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InsertUpdateReadController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InsertUpdateReadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InsertUpdateReadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

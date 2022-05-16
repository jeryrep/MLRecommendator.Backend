using Microsoft.AspNetCore.Mvc;
using MLRecommendator.Modeling;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MLRecommendator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly MlService _mlService;
        public ModelController(MlService service) {
            _mlService = service;
        }
        // GET: api/<ModelController>
        [HttpGet]
        public IActionResult Get() {
            return Ok(_mlService.GetBias());
        }

        // GET api/<ModelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ModelController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ModelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

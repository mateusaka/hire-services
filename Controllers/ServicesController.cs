using HireServices.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HireServices.API.Controllers {

    [Route("api/services")]
    public class ServicesController : ControllerBase {
        [HttpGet]
        public IActionResult Get(string query) {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateServiceModel createService) {
            return CreatedAtAction(nameof(GetById), new { id = createService.Id }, createService);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateServiceModel updateService) {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComments(int id, [FromBody] CreateCommentModel createComment) {
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id) {
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id) {
            return NoContent();
        }
    }
}
using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FloatDoor.API.Controllers
{
    [Route("api/floats")]
    public class FloatsController : ControllerBase
    {
        private readonly IFloatService _floatService;
        public FloatsController(IFloatService floatService)
        {
            _floatService = floatService;
        }

        [HttpGet]
        public IActionResult GetAllFloats(string query)
        {
            var floats = _floatService.GetAllFloats();

            return Ok(floats);
        }

        [HttpGet("{id}")]
        public IActionResult GetFloatById(int id)
        {
            var getFloat = _floatService.GetFloatById(id);

            return Ok(getFloat);
        }

        [HttpPost]
        public IActionResult CreateFloat([FromBody] CreateFloatInputModel inputModel)
        {
            var createFloat = _floatService.CreateFloat(inputModel);

            return CreatedAtAction(nameof(GetFloatById), new { id = createFloat }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFloat(int id, [FromBody] UpdateFloatInputModel inputModel)
        {
            if(inputModel.FloatName.Length > 50)
            {
                return BadRequest();
            }

            _floatService.UpdateFloat(inputModel);

            return NoContent();
        }

        [HttpDelete("{id")]
        public IActionResult DeleteFloat(int id)
        {
            _floatService.DeleteFloat(id);

            return NoContent();
        }
    }
}

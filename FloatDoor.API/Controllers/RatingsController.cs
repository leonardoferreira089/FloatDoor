using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Implementations;
using FloatDoor.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FloatDoor.API.Controllers
{
    [Route("api/ratings")]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _service;
        public RatingsController(IRatingService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllRatings(string query)
        {
            var ratings = _service.GetAllRatings(query);

            return Ok(ratings);
        }

        [HttpGet("{id}")]
        public IActionResult GetRatingById(int id)
        {
            var rating = _service.GetRatingById(id);
            if (rating == null)
            {
                return NotFound();
            }

            return Ok(rating);
        }

        [HttpPost]
        public IActionResult CreateRating([FromBody] CreateRatingInputModel inputModel)
        {
            var rating = _service.CreateRating(inputModel);

            return CreatedAtAction(nameof(GetRatingById), new { id = rating }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRating(int id, [FromBody] UpdateRatingInputModel inputModel)
        {
            if (inputModel.ValuationNote < 1 || inputModel.ValuationNote > 5)
            {
                return BadRequest();
            }

            _service.UpdateRating(inputModel);

            return NoContent();
        }
    }
}

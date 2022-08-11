using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FloatDoor.API.Controllers
{
    [Route("api/requests")]
    public class RentRequestsController : ControllerBase
    {
        private readonly IRentRequestService _service;
        public RentRequestsController(IRentRequestService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetRequestById(int id)
        {
            var getRequest = _service.GetRequestById(id);
            if (getRequest == null)
            {
                return NotFound();
            }

            return Ok(getRequest);
        }

        [HttpPost]
        public IActionResult CreateRequest([FromBody] CreateRequestInputModel inputModel)
        {
            if(inputModel.Message.Length < 4)
            {
                return BadRequest();
            }
            var request = _service.CreateRequest(inputModel);

            return CreatedAtAction(nameof(GetRequestById), new { id = request }, inputModel);
        }

        [HttpPut]
        public IActionResult UpdateRequest(int id, [FromBody] UpdateRequestInputModel inputModel)
        {
            if (inputModel.Message.Length < 4)
            {
                return BadRequest();
            }
            _service.UpdateRequest(inputModel);

            return NoContent();
        }

        [HttpPut("{id}/reject")]
        public IActionResult RejectRequest(int id)
        {
            _service.RejectRequest(id);

            return NoContent();
        }

        [HttpPut("{id}/approve")]
        public IActionResult ApproveRequest(int id)
        {
            _service.ApproveRequest(id);

            return NoContent();
        }
    }
}

using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FloatDoor.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _service.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserInputModel inputModel)
        {
            var user = _service.CreateUser(inputModel);

            return CreatedAtAction(nameof(GetUserById), new { id = user }, inputModel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConDev.Logic;
using ConDev.Logic.CreateUser;
using Microsoft.AspNetCore.Mvc;

namespace ConDev.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICreateUserCommand _createUserCommand; 

        public UsersController(ICreateUserCommand createUserCommand)
        {
            _createUserCommand = createUserCommand;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserPayload payload)
        {
            var result = _createUserCommand.TryCreate(payload);
            if (result.ValidationFailed.HasValue && result.ValidationFailed.Value == CreateUserResult.ValidationFailedErrors.FailedDuplicateEmail)
                return Conflict(new { Error = "Duplicate email" });
            return Ok();
        }

        public class CreateUserPayload : ICreateUserCommandInput
        {
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}

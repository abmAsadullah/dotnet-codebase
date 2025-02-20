using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetUsers()
        {
            // Replace with your logic to get users
            return new string[] { "user1", "user2" };
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<string> GetUser(int id)
        {
            // Replace with your logic to get a user by id
            return "user" + id;
        }

        // POST: api/Users
        [HttpPost]
        public IActionResult PostUser([FromBody, Required] string value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Replace with your logic to create a new user
            return Ok();
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public IActionResult PutUser(int id, [FromBody, Required] string value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Replace with your logic to update a user by id
            return Ok();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            // Replace with your logic to delete a user by id
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entity;
using Repository;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        IUserService userService;
        public UsersController(IUserService userService)
        {
          this.userService = userService;

        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "Riki", "Zeava" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user = userService.GetUserById(id);
            if (user != null)
                return Ok(user);
            else
                return NotFound();
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            userService.Post(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        // POST api/<UsersController>
        [HttpPost("login")]
        public ActionResult<User> Post([FromBody] UserLogin userLogin)
        {
            User user = userService.Post(userLogin);
            if (user != null)
                return Ok(user);
            else
                return NoContent();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User userToUpdate)
        {
            userService.Put(id, userToUpdate);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


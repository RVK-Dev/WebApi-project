using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entity;
using Entity.Models;
using Repository;
using Service;
using System.Diagnostics.Eventing.Reader;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IPasswordService passwordService;
        IUserService userService;
        public UsersController(IUserService userService, IPasswordService passwordService)
        {
          this.userService = userService;
            this.passwordService = passwordService;

        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "Riki", "Zeava" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public  async Task<ActionResult<User>> Get(int id)
        {
            User user =  await userService.GetUserById(id);
            if (user != null)
                return Ok(user);
            else
                return NotFound();
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            
            int StrengthOfPassword = passwordService.Post(user.Password);
            if (StrengthOfPassword < 3)
                return BadRequest();

           await userService.Post(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        // POST api/<UsersController>
        [HttpPost("login")]
        public async Task<ActionResult<User>> Post([FromBody] UserLogin userLogin)
        {
            User user =await userService.Post(userLogin);
            if (user != null)
                return Ok(user);
            else
                return NoContent();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] User userToUpdate)
        {
            int strengthOfPassword = passwordService.Post(userToUpdate.Password);
            if (strengthOfPassword < 3)
                return BadRequest();

            await userService.Put(id, userToUpdate);
            return Ok();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


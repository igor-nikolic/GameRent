using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.DataTransfer;
using Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
using DataAccess;
namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {

        private readonly IRentGameCommand _rentGame;

        public RentsController(IRentGameCommand rentGame)
        {
            _rentGame = rentGame;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] RentGameDto dto)
        {
            try
            {
                _rentGame.Execute(dto);
                return StatusCode(201, "Game rented!");
            }
            catch (GameNotAvailableException e)
            {
                return StatusCode(409, "Game not available for renting!");
            }
            catch (UserDoesntExistException e)
            {
                return StatusCode(404, "User with provided ID doesn't exist!");
            }
            catch (GameDoesntExistException e)
            {
                return StatusCode(404, "Game with provided ID doesn't exist");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something is wrong on our server! Please try again later");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
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
    public class GamesController : ControllerBase
    {

        private readonly IAddGameCommand _addGame;

        public GamesController(IAddGameCommand addGame)
        {
            _addGame = addGame;
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
        public IActionResult Post([FromBody] AddGameDto dto)
        {
            try
            {
                _addGame.Execute(dto);
                return StatusCode(201);
            }
            catch (GameExistsException)
            {
                return StatusCode(409, "Game already exists");
            }
            catch (CompanyDoesntExistException)
            {
                return StatusCode(404, "Company doesn't exist");
            }
            catch (CategoryDoesntExistException)
            {
                return StatusCode(404, "Category doesn's exist");
            }
            catch (Exception)
            {
                return StatusCode(500, "Server error, try again later");
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
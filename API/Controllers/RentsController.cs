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
        private readonly IReturnGameCommand _returnGame;

        public RentsController(IRentGameCommand rentGame, IReturnGameCommand returnGame)
        {
            _rentGame = rentGame;
            _returnGame = returnGame;
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
            catch (GameNotAvailableException)
            {
                return StatusCode(409, "Game not available for renting!");
            }
            catch (UserDoesntExistException)
            {
                return StatusCode(404, "User with provided ID doesn't exist!");
            }
            catch (GameDoesntExistException)
            {
                return StatusCode(404, "Game with provided ID doesn't exist");
            }
            catch (ActiveRentException)
            {
                return StatusCode(409, "You have an active rent!");
            }
            catch(DeletedException)
            {
                return StatusCode(404, "Game has been deleted!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Something is wrong on our server! Please try again later");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] RentGameDto dto)
        {
            dto.Id = id;
            try
            {
                _returnGame.Execute(dto);
                return StatusCode(201, "Game returned!");
            }
            catch (GameDoesntExistException)
            {
                return StatusCode(404, "Game doesnt exists");
            }
            catch (UserDoesntExistException)
            {
                return StatusCode(404, "User doesnt exist");
            }
            catch (RentNotFoundException)
            {
                return StatusCode(404, "Rent with that Id not found");
            }
            catch (BadDataException)
            {
                return StatusCode(422, "Wrong data provided!");
            }
            catch (GameReturnedException)
            {
                return StatusCode(409, "You have already returned this game!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Something is wrong on our server! Please try again later");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
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
    public class CompaniesController : ControllerBase
    {

        private readonly IAddCompanyCommand _addCompany;

        public CompaniesController(IAddCompanyCommand addCompany)
        {
            _addCompany = addCompany;
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
        public IActionResult Post([FromBody] CompanyDto dto)
        {
            try
            {
                _addCompany.Execute(dto);
                return StatusCode(201);
            }
            catch (CompanyExistsException)
            {
                return StatusCode(409, "Company already exists");
            }
            catch (Exception)
            {
                return StatusCode(500,"Server error! Try again later");
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.DataTransfer;
using Microsoft.AspNetCore.Mvc;
using DataAccess;
namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly IAddCategoryCommand _addCategory;

        public CategoriesController(IAddCategoryCommand addCategory)
        {
            _addCategory = addCategory;
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
        public IActionResult Post([FromBody] CategoryDto dto)
        {
            try
            {
                _addCategory.Execute(dto);
                return StatusCode(201);
            }
            catch (Exception)
            {
                return StatusCode(500);
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
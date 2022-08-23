using Angular_test.DomainServices;
using Angular_test.Filters;
using Angular_test.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular_test.Controllers
{
    
    [Produces("application/json")]
    [Route("api/Category")]
    public class CategoryController : Controller
    {
       
        private readonly ICategoryCRUD categoryCRUD;


        public CategoryController(ICategoryCRUD xxx)
        {
            this.categoryCRUD = xxx;
            //xxxxx categoryCRUD = new CategoryCRUD()
        }


        // GET: api/Category
        [HttpGet]
        public IActionResult Get()
        {
        
            return Ok(categoryCRUD.GetAll());
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetById(int id)
        {
            return Ok(categoryCRUD.GetById(id));
        }

        // POST: api/Category
        [HttpPost]
        [ValidateModel]
        [MyException]
        public IActionResult Post([FromBody] CategoryModel model)
        {
            var category = categoryCRUD.Add(model); 
            return Ok(category);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        [ValidateModel]
        [MyException]
        public IActionResult Put(int id, [FromBody] CategoryModel model)
        {
            var cat = categoryCRUD.GetById(id);
            if (cat != null)
            {
                cat = categoryCRUD.Update(model);
            }
            else
            {
                BadRequest("Geçersiz id");
            }
            return Ok(cat);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            categoryCRUD.Delete(id);
            return Ok();
        }
    }
}
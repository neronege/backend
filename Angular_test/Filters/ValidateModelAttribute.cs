using Angular_test.Controllers;
using Angular_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace Angular_test.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ServiceResponse<Category> response = new ServiceResponse<Category>();

                response.Errors = context.ModelState.Values.SelectMany(m => m.Errors)
                     .Select(e => e.ErrorMessage).ToList();
                response.HasError = true;

                context.Result = new BadRequestObjectResult(response);
            }
        }
    }
}

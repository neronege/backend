using Angular_test.Controllers;
using Angular_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Angular_test.Filters
{
    
        public class MyExceptionAttribute : ExceptionFilterAttribute
        {
            public override void OnException(ExceptionContext context)
            {
                ServiceResponse<Category> response = new ServiceResponse<Category>();
                response.HasError = true;
                response.Errors.Add("Bir hata oluştu: " + context.Exception.Message);

                context.Result = new BadRequestObjectResult(response);
            }
        }
}

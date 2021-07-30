using Api_Login_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Login_Project.Filter
{
    public class ValidationModel : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var validation = new ErrorsModel(context.ModelState.SelectMany(e => e.Value.Errors).Select(a => a.ErrorMessage));
                context.Result = new BadRequestObjectResult(validation);
            }
        }
    }
}

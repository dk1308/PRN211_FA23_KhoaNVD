﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Demo_01.CustomActionFilter
{
    public class ValidateModelAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(!context.ModelState.IsValid) { 
                context.Result = new BadRequestResult();
            }
        }
    }
}
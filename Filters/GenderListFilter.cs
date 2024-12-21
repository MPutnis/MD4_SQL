using MD4_SQL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace MD4_SQL.Filters
{
    public class GenderListFilter : ActionFilterAttribute
    {
        // Copilot suggested this filter for adding Gender list ViewBag to 
        // the controllers where it is needed.
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = context.Controller as Controller;
            if (controller != null )
            {
                controller.ViewBag.GenderList = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            }
            base.OnActionExecuted(context);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Poliedro.Billing.Application.Common.Features;
using Microsoft.AspNetCore.Http;

namespace Poliedro.Billing.Application.Common.Exeptions;

public class ExceptionManager : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        context.Result = new ObjectResult(ResponseApiService.Response(
            StatusCodes.Status500InternalServerError, null, context.Exception.Message));

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
    }
}

using ContactsCL.Application.Exceptions;
using ContactsCL.Application.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace ContactsCL.Application.Filters
{
    public class ManageExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            if (exception is NotFoundException)
            {
                SetErrorDetail(context, (int)HttpStatusCode.NotFound, "NotFound", exception.Message);
            }

            if(exception is BadRequestException)
            {
                SetErrorDetail(context, (int)HttpStatusCode.BadRequest, "BadRequest", exception.Message);
            }
        }

        private void SetErrorDetail(ExceptionContext context, int status, string title, string detail)
        {
            context.HttpContext.Response.StatusCode = status;
            context.ExceptionHandled = true;

            var response = new
            {
                error = new ExceptionDetail
                {
                    Status = status,
                    Title = title,
                    Detail = detail

                }
            };

            context.Result = new JsonResult(response);
        }
    }
}

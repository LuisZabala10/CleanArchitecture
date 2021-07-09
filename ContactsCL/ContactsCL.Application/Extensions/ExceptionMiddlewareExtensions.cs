namespace ContactsCL.Application.Extensions
{
    using ContactsCL.Application.Model;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Diagnostics;
    using Microsoft.AspNetCore.Http;
    using System.Net;

    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(options =>
            {
                options.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.ContentType = "application/json";

                    var exception = context.Features.Get<IExceptionHandlerFeature>();

                    if (exception != null)
                    {
                        await context.Response.WriteAsync(new ExceptionDetail
                        {
                            Status = context.Response.StatusCode,
                            Title = "Internal Server Error",
                            Detail = exception.Error.Message
                        }.ToString());
                    }

                });
            });
        }
    }
}

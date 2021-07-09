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

                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";


                    var contentFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (contentFeature != null)
                    {
                        await context.Response.WriteAsync(
                            new ErrorDetail
                            {
                                Status = context.Response.StatusCode,
                                Title = "Internal Server Error"
                            }.ToString());
                    }

                });
            });
        }
    }
}

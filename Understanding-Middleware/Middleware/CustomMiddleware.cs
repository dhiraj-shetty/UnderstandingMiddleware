using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace understandingmiddleware.middleware
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from CustomMiddleware Class 1 \n");

            await next(context);

            await context.Response.WriteAsync("Hello from CustomMiddleware Class 2 \n");
        }
    }
}
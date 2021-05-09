using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using understandingmiddleware.middleware;

namespace my_books
{
    public class Startup
    {

        // ConfigureServices method gets called by the runtime. Use this method to add services to the container.
        // This method is Optional and is called by the host before the Configure method to configure the app's services.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<CustomMiddleware>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // The Configure method is used to specify how the app responds to HTTP requests
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use-1 1 \n");

                await next();

                await context.Response.WriteAsync("Hello from Use-1 2 \n");
            });

            app.UseMiddleware<CustomMiddleware>();

            app.Map("/testcustomcode", CutomCode);

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use-3 1 \n");

                await next();

                await context.Response.WriteAsync("Hello from Use-3 2 \n");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Last Reachable Middleware of HTTP Request Pipeline\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Unreachable Middleware \n");
            });
        }

        private void CutomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from CustomCode \n");
            });
        }
    }
}

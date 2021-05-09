using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace my_books
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The Main is where your Application Begins its execution
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Configure your App using the "Startup" Class
                    webBuilder.UseStartup<Startup>();
                });
    }
}

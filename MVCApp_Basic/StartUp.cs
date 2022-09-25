using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MVCApp_Basic
{
    public class StartUp
    {
        public void ConfigurationServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context,next) => {
                await context.Response.WriteAsync("Exceuting Middleware1");
                await next();
                await context.Response.WriteAsync("\nExceuted  Middleware1");
            });

            app.UseRouting();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("\nHello user From MVC App");
                });
            });
        }
    }
}

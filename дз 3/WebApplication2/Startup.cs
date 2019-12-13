using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            //((x^2)+(y^2)+2x)/(x^2)+(y^2)-2x))^(1/2)
            int a = 1000;
            int b = 1;
            int c = 100;
            app.Use(async (context, next) =>
            {
                c = ((-b - ((b ^ 2) - 4 * a * c)) ^ (1 / 2)) / (2 * a);
                await context.Response.WriteAsync($"(-b+((b)^2-4ac))^(1/2))/(2a) Result: {c}");
            });
        }
    }
}

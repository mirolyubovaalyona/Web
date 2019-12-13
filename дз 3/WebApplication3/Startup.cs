using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication3
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

            app.Map("/a", A);
            app.Map("/b", B);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("/a =(xy)/((x^2)+(y^2)+5)^(1/2) or /b =((x^2)+(y^2)+2x)/(x^2)+(y^2)-2x))");
            });
        }

        private static void A(IApplicationBuilder app)
        {
            int a = 1000;
            int b = 1;
            int c = 100;
            app.Run(async context =>
            {
                c = ((-b - ((b ^ 2) - 4 * a * c)) ^ (1 / 2)) / (2 * a);
                await context.Response.WriteAsync($"/a =(xy)/((x^2)+(y^2)+5)^(1/2)  Result: {c}");
            });
        }
        private static void B(IApplicationBuilder app)
        {
            int a = 223924;
            int b = 10;
            app.Run(async context =>
            {
                a = (((a ^ 2) + (b ^ 2) + 2 * a) / ((a ^ 2) + (b ^ 2) - 2 * a));
                await context.Response.WriteAsync($"/b =((x^2)+(y^2)+2x)/(x^2)+(y^2)-2x))  Result: {a}");
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApplication4
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;
        string pattern;
        public TokenMiddleware(RequestDelegate next, string pattern)
        {
            this._next = next;
            this.pattern = pattern;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var f = context.Request.Query["f"];
            if (f != pattern)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("/?f=1 to count the formulas");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}

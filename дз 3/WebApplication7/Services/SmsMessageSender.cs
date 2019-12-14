using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            app.Run(async (context) =>
            {
                if (context.Request.Cookies.ContainsKey("name"))
                {
                    string name = context.Request.Cookies["name"];
                    await context.Response.WriteAsync($"Hello {name}!");
                }
                else
                {
                    context.Response.Cookies.Append("name", "Tom");
                    await context.Response.WriteAsync("Hello World!");
                }
            });
            return "Sent by SMS";
        }
    }
}

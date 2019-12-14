using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Services;

namespace WebApplication7
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            app.UseSession();   // добавляем механизм работы с сессиями
            app.Run(async (context) =>
            {
                if (context.Session.Keys.Contains("name"))
                    await context.Response.WriteAsync($"Hello {context.Session.GetString("name")}!");
                else
                {
                    context.Session.SetString("name", "Tom");
                    await context.Response.WriteAsync("Hello World!");
                }
            });
            return "Sent by Email";
        }
    }
}

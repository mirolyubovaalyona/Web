using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Web3._7
{
    public class EmailMessageSender :IMessageSender
    {
        HttpContext context;
        public EmailMessageSender(HttpContext contextt)
        {
            context = contextt;
        }
        public async void Send()
        {
            if (context.Session.Keys.Contains("text"))
                await context.Response.WriteAsync($"{context.Session.GetString("text")}");
            else
            {
                context.Session.SetString("text", "tttttt1");
                await context.Response.WriteAsync("text empty");
            }
        }
    }
}
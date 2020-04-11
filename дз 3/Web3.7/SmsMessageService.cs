using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Web3._7
{
    public class SmsMessageSender : IMessageSender
    {
        HttpContext context;
        public SmsMessageSender(HttpContext contextt)
        {
            context = contextt;
        }

        public async void Send()
        {
            if (context.Request.Cookies.ContainsKey("text"))
            {
                string text = context.Request.Cookies["text"];
                await context.Response.WriteAsync($"{text}");
            }
            else
            {
                context.Response.Cookies.Append("name", "Totearm");
                await context.Response.WriteAsync("text empty");
            }
        }
    }
}
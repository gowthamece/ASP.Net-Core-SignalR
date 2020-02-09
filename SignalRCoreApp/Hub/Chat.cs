using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace SignalRCoreApp.Hub
{
    [Authorize]
    public class Chat: Microsoft.AspNetCore.SignalR.Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",Context.User.Identity.Name?? "anonymous", message);
        }
    }
}

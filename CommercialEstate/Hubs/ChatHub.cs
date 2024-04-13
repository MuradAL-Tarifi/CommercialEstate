using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialEstate.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string fromUser, string message, string photo)
        {
            await Clients.All.SendAsync("ReceiveMessage", fromUser, message, photo);
        }
    }
}

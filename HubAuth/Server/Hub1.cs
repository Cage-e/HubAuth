using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace HubAuth.Server
{
    [Authorize]
    public class Hub1 : Hub
    {
        public async Task SendMessage(int clientUpdate) => await Clients.All.SendAsync("ReceiveMessage", clientUpdate + 5);

    }
}

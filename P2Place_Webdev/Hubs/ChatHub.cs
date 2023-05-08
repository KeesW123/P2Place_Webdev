using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);

            return base.OnConnectedAsync();
        }

        public Task SendToUserGroupMessage(string receiver, string message)
        {
            return Clients.Group(receiver).SendAsync("ReceiveMessage", Context.User.Identity.Name, message);
        }
    }
}
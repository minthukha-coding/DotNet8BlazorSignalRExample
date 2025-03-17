namespace DotNet8BlazorSignalRExample;

using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public async Task NotifyTyping(string user)
    {
        await Clients.Others.SendAsync("UserTyping", user);
    }
}
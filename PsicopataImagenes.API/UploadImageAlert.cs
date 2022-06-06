using Microsoft.AspNetCore.SignalR;

namespace PsicopataImagenes.API
{
    public class UploadImageAlert : Hub
    {
        public async Task SendMessage(string imagePath)
        {
            await Clients.All.SendAsync("ReceiveMessage", imagePath);
        }
    }
}

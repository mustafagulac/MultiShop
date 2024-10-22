using Microsoft.AspNetCore.SignalR;
using MultiShop.SignalRRealTimeApi.Services.SignalRCommentServices;
using MultiShop.SignalRRealTimeApi.Services.SignalRMessageServices;

namespace MultiShop.SignalRRealTimeApi.Hubs
{
    public class SignalRHub : Hub
    {        
        private readonly ISignalRCommentService _commentService;
        //private readonly ISignalRMessageService _messageService;

        public SignalRHub(ISignalRCommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task SendStatisticCount()
        {
            var getTotalCommentCount = await _commentService.GetTotalCommentCount();
            await Clients.All.SendAsync("ReceiveCommentCount", getTotalCommentCount);
        }
    }
}

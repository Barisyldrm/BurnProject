using Burn.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace BurnApi.Hubs
{
	public class SignalRHub : Hub
	{
		BurnContext context = new BurnContext();
		public async Task SendCategoryCount()
		{
			var value = context.Categories.Count();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);
		}

	}
}

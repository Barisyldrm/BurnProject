using Microsoft.AspNetCore.Mvc;

namespace BurnWebUI.Controllers
{
	public class SignalRDefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

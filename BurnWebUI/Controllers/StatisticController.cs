using Microsoft.AspNetCore.Mvc;

namespace BurnWebUI.Controllers
{
	public class StatisticController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

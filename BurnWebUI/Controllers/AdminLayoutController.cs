using Microsoft.AspNetCore.Mvc;

namespace BurnWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

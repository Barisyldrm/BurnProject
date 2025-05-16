using Microsoft.AspNetCore.Mvc;

namespace BurnWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutSideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

﻿using Microsoft.AspNetCore.Mvc;

namespace BurnWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View();
		}
	}
}

﻿using Microsoft.AspNetCore.Mvc;

namespace BurnWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}

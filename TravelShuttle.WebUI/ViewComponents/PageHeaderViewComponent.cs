using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.ViewComponents
{
    public class PageHeaderViewComponent:ViewComponent
    {
        public PageHeaderViewComponent()
        {

        }

        public ViewViewComponentResult Invoke(string linkUp, string linkPage)
        {
            var model = new PageHeaderModel
            {
                linkUp = linkUp,
                linkPage = linkPage
            };
            return View(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.Entities.Enums;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private IPageService _pageService;
        public MenuViewComponent(IPageService pageService)
        {
            _pageService = pageService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new WebSiteModel
            {
                services = _pageService.GetAll(PageType.Services),
                tours = _pageService.GetAll(PageType.Tour)
            };
            return View(model);
        }
    }
}

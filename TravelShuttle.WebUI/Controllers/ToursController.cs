using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.Entities.Enums;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.Controllers
{
    public class ToursController : Controller
    {
        private IPageService _pageService;

        public ToursController(IPageService pageService)
        {
            _pageService = pageService;
        }
        public IActionResult Index()
        {
            ViewBag.CurrentPage = "Tours";

            var model = new ToursModel()
            {
                TourPages = _pageService.GetAll(PageType.Tour)
            };
            return View(model);
        }
    }
}


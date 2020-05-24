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
    public class HomeController:Controller
    {
        private ICarService _CarService;
        private IPageService _pageService;

        public HomeController(ICarService carService,IPageService pageService)
        {
            _CarService = carService;
            _pageService = pageService;
        }
        public IActionResult Index()
        {
            ViewBag.CurrentPage = "Home";
            HomeModel model = new HomeModel
            {
                Cars = _CarService.GetAll(),

                BlogsPages = _pageService.GetAll(PageType.Blog).Take(2).ToList()
            };
            return View(model);
        }

        public ActionResult Robots()
        {
            Response.ContentType = "text/plain";
            return View();
        }

        public ActionResult SiteMap()
        {
            var model = new WebSiteModel
            {
                services = _pageService.GetAll(PageType.Services),
                tours = _pageService.GetAll(PageType.Tour)
            };
            Response.ContentType = "xml";
            return View(model);
        }
    }
}

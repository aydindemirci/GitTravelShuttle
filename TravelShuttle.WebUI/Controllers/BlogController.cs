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
    public class BlogController : Controller
    {
        private IPageService _pageService;
        public BlogController(IPageService pageService)
        {
            _pageService = pageService;
        }
        public IActionResult Index()
        {
            ViewBag.CurrentPage = "Blog";


            var model = new BlogModel
            {
                blogPages = _pageService.GetAll(PageType.Blog)
            };
            return View(model);
        }
    }
}
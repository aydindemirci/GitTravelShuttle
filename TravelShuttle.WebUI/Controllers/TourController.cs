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
    public class TourController:Controller
    {
        private IPageService _pageService;
        private ITagService _tagService;
        public TourController(IPageService pageService,ITagService tagService)
        {
            _pageService = pageService;
            _tagService = tagService;
        }

        [Route("Tour/{tourUrlName?}")]
        public IActionResult Index(string tourUrlName)
        {
            if (tourUrlName == null)
              return Redirect("/Tours");

            ViewBag.CurrentPage = "Tours";

            var tourPages = _pageService.GetAll(PageType.Tour);
            var tourPage = tourPages.Find(p => p.UrlName == tourUrlName);

            var model = new TourModel
            {
                TourPage = tourPage,
                TourPages =  tourPages,
                Tags =  _tagService.GetAll(tourPage.Id)
            };
            return View(model);
        }
    }
}

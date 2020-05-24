using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.Entities.Enums;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.Controllers
{
    public class ServicesController : Controller
    {
        private List<Page> _services;
        private ITagService _tagService;
        public ServicesController(IPageService pageService,ITagService tagService)
        {
            _services = pageService.GetAll(PageType.Services);
            _tagService = tagService;
        }

        [Route("Services/{categoryName?}")]
        public IActionResult Index(string categoryName)
        {
            ViewBag.CurrentPage = "Services";

            Page currentService;
            ServicesModel model = new ServicesModel();
            model.services = _services;

            if (categoryName != null)
                currentService = _services.Find(x => x.UrlName == categoryName);
            else
            {
                try
                {
                    currentService = _services[0];
                }
                catch
                {
                    currentService =new Page();
                }
            }

            model.currentService = currentService;
            model.tags = _tagService.GetAll(currentService.Id);



            return View(model);
        }
    }
}
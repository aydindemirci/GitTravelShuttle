using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.Controllers
{
    public class AboutUsController : Controller
    {
        private IDefinitionService _definitionService;
        private ICustomerService _customerService;

        public AboutUsController(IDefinitionService definitionService,ICustomerService customerService)
        {
            _definitionService = definitionService;
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentPage = "AboutUs";
            var model = new AboutUsModel
            {
                definition = _definitionService.GetDefinition(),
                customers = _customerService.GetAll()
            };
            return View(model);
        }

    }
}
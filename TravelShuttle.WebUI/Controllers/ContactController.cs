using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelShuttle.Business.Abstract;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private IDefinitionService _definitionService;
        public ContactController(IDefinitionService definitionService)
        {
            _definitionService = definitionService;
        }
        public ActionResult Index()
        {
            ViewBag.CurrentPage = "Contact";

            var model = new ContactModel
            {
                Definition = _definitionService.GetDefinition()
            };
            return View(model);
        }
    }
}
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
    public class FooterViewComponent:ViewComponent
    {
        private Definition _definition;
        private List<Page> _services;
        public FooterViewComponent(IDefinitionService definitionService,IPageService pageService)
        {
            _definition = definitionService.GetDefinition();
            _services = pageService.GetAll(PageType.Services);
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new WebSiteModel
            {
                definition = _definition,
                services = _services
            };
            return View(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Options;
using TravelShuttle.Business.Abstract;
using TravelShuttle.Entities.Concrete;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private Definition _definition;

        public HeaderViewComponent(IDefinitionService definitionService)
        {
            _definition = definitionService.GetDefinition();
        }


        public ViewViewComponentResult Invoke()
        {
            var model = new WebSiteModel {definition = _definition};
            return View(model);

        }
    }

}

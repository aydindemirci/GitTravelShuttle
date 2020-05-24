using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelShuttle.Business.Abstract;
using TravelShuttle.WebUI.Models;

namespace TravelShuttle.WebUI.Controllers
{
    public class FaqController : Controller
    {
        private IQuestionService _questionService;
        public FaqController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentPage = "Faq";

            var model = new FaqModel
                {
                    Questions = _questionService.GetAll()
                }
                ;
            return View(model);
        }
    }
}
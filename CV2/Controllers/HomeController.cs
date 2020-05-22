using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CV2.Models;
using CV2.BLL;
using Microsoft.Extensions.Logging;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public async Task<IActionResult> Index(EmailModel model)
        {
            if (ModelState.IsValid)
            {
                Email email = new Email();
                await email.SendEmailAsync(model.FromMessage, model.Subject,model.Text);
                ViewBag.Message = "Message send!";
            }
            //return "sdfgsdg";
            return View(model); //View( model);
        }

        public IActionResult Menu()
        {
            return PartialView("Menu");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

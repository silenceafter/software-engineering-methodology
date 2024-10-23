using abstract_factory.Factories;
using abstract_factory.Interfaces;
using abstract_factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace abstract_factory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserInterfaceFactory _factory;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string lang = "ru")
        {
            switch (lang)
            {
                case "fr":
                    _factory = new FrenchUserInterfaceFactory();
                    break;
                case "it":
                    _factory = new ItalianUserInterfaceFactory();
                    break;
                default:
                    _factory = new RussianUserInterfaceFactory();
                    break;
            }

            var model = new UserInterfaceViewModel
            {
                Text = _factory.CreateText().GetText(),
                Image = _factory.CreateImage().GetImagePath(),
                /*HelpContent = _factory.CreateHelp().GetHelpContent()*/
            };
            return View(model);
        }

        public IActionResult Help()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

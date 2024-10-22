using abstract_factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace abstract_factory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IText _textProvider;

        public HomeController(ILogger<HomeController> logger, IText textProvider)
        {
            _logger = logger;
            _textProvider = textProvider;
        }

        public IActionResult Index()
        {
            var culture = HttpContext.Items["Culture"]?.ToString() ?? "ru";

            ViewBag.HeaderMenu = _textProvider.GetHeaderMenu(culture);
            ViewBag.FooterMenu = _textProvider.GetFooterMenu(culture);
            return View();
        }

        public IActionResult Privacy()
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

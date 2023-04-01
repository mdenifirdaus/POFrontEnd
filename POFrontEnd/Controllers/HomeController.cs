using Microsoft.AspNetCore.Mvc;
using POFrontEnd.Helpers;
using POFrontEnd.Models;
using RestSharp;
using System.Diagnostics;

namespace POFrontEnd.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult OnSubmitPO(POViewModels models)
        {

            var api = new ReqAPI();
            var res = api.GetAPIResponse("https://localhost:44371/api/po/insert/po", Method.Post,models);

            return View(models);
        }

    }
}
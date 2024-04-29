using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp2ByKrisha.Models;
using WebApp2ByKrisha.Services;

namespace WebApp2ByKrisha.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAll());
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

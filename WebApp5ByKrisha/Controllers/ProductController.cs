using Microsoft.AspNetCore.Mvc;
using WebApp5ByKrisha.Models;

namespace WebApp5ByKrisha.Controllers
{
    public class ProductController : Controller
    {
        private readonly NcclabkrishaContext context;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger, NcclabkrishaContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var data = context.Products.ToList();
            return View(data);
        }
    }
}

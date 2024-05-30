using Microsoft.AspNetCore.Mvc;
using WebApp5byKrisha.Models;

namespace WebApp5byKrisha.Controllers
{
    public class ProductController : Controller
    {
        private readonly NcclabkrishaContext _context;
        public ProductController(NcclabkrishaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
    }
}

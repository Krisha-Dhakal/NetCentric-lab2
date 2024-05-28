using Microsoft.AspNetCore.Mvc;

namespace WebApp6ByKrisha.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(2);
            //Response.Cookies.Append(key, value, option);
            Response.Cookies.Append("userKey", "Krisha Dhakal hello@123", option);
            return View();
        }
        public IActionResult ReadCookies()
        {
            string cookieValue = Request.Cookies["userKey"];
            ViewBag.myCookie = cookieValue;
            return View();
        }
    }
}

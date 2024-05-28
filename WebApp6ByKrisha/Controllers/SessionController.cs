﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp6ByKrisha.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("uname", "Krisha");
            HttpContext.Session.SetString("pw", "hello@123");
            return View();
        }
        public IActionResult SessionPage()
        {
            string uname = HttpContext.Session.GetString("uname").ToString();
            string pw = HttpContext.Session.GetString("pw").ToString();
            ViewBag.username = uname;
            ViewBag.password = pw;
            return View();
        }
    }
}

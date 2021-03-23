using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace NewsUI.Controllers
{
    public class NewsDetailController : Controller
    {
        private readonly IConfiguration _config;

        public NewsDetailController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index(string title,string id)
        {
            ViewBag.NewsService = _config.GetValue<string>("newsService");
            return View();
        }
    }
}

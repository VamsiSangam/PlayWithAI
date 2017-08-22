using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayWithAI.Models;

namespace PlayWithAI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String size, String difficulty)
        {
            Session["size"] = Int32.Parse(size);
            Session["difficulty"] = Int32.Parse(difficulty);

            return RedirectToAction("Index", "Game");
        }
    }
}
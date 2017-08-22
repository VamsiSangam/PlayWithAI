using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayWithAI.Models;

namespace PlayWithAI.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            if (Session["size"] == null)
            {
                return RedirectToAction("Home", "Index");
            }
            else
            {
                int size = (Int32) Session["size"];
                GameViewModel model = new GameViewModel(size);

                return View(model);
            }
        }
    }
}
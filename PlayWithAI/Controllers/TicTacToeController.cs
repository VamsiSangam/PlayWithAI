using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayWithAI.Models;

namespace PlayWithAI.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: TicTacToe
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

                // put game state in session
                // Game begins with O
                Session["state"] = new TicTacToeGameState(size, false);

                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Index(int row, int col)
        {

            TicTacToeGameState state = (TicTacToeGameState) Session["state"];

            state.addMove(row, col);

            return null;
        }
    }
}
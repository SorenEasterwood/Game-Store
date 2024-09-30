using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Game_Store.Models;

namespace GameList.Controllers
{
    public class MovieController : Controller
    {
        private GameContext context { get; set; }

        public MovieController(GameContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Game());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var movie = context.Games.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                if (game.GameId == 0)
                    context.Games.Add(game);
                else
                    context.Games.Update(game);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (game.GameId == 0) ? "Add" : "Edit";
                return View(game);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Games.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RobofestWTECore.Data;

namespace RobofestWTECore.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameContext db;

        public HomeController(GameContext db)
        {
            this.db = db;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HiMegan()
        {
            return View();
        }



        public ActionResult MatchManager()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
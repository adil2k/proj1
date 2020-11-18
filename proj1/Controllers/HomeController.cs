using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proj1.Models;

namespace proj1.Controllers
{
    public class HomeController : Controller
    {
        PlayerContext db = new PlayerContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Player
            IEnumerable<Player> players = db.Players;
            // передаем все объекты в динамическое свойство Players в ViewBag
            ViewBag.Players = players;
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.PlayerId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Transfer transfer)
        {
            transfer.Date = getToday();
            db.Transfers.Add(transfer);
            db.SaveChanges();
            return "Спасибо, " + transfer.TransferTeam + ", за покупку!";
        }
        private DateTime getToday()
        {
            return DateTime.Now;
        }

    }



}

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
            transfer.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Transfers.Add(transfer);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + transfer.TransferTeam+ ", за покупку!";
        }

    }



}

using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext context;

        public PlayerController(ApplicationDbContext _context)
        {
            context = _context;
        }


        public IActionResult List()
        {
            return View();

        }
        public IActionResult Find(int id)
        {
            var data=context.Players.Find(id);
            return View(data);
        }
        public IActionResult Add(Player p)
        {
            if(ModelState.IsValid)
            {
                Player Plr=new Player();
                Plr.Name=p.Name;
                Plr.Category=p.Category;
                Plr.BiddingPrice=p.BiddingPrice;
                Plr.Team.TeamId=p.TeamId;

                context.Teams.Add(Plr);
                context.SaveChanges();
                return RedirectToAction();
            }
            return View();

            

        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}


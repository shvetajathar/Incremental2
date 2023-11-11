using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    
    public class TeamController : Controller
    {
        
        private readonly ApplicationDbContext context;

        public TeamController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult List()
        {
            var data=context.Teams.ToList();
            return View(data);
        }
        
        public IActionResult Add()
        {
            
            return View();

        }
        [HttpPost]

        public IActionResult Add(Team t)
        {
            context.Teams.Add(t);
            context.SaveChanges();
            return RedirectToAction();
        }
        public IActionResult Delete()
        {
            
            return View();

        }
    [HttpPost]
     public IActionResult Delete(int id)
        {
            var data=context.Teams.Find(id);
            context.Teams.Remove(data);
            context.SaveChanges();
            
            return RedirectToAction("List");

        }


        
    }
}


﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlayerController(ApplicationDbContext context)
        {
            _context = context;
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
        public IActionResult Add()
        {
            
        }
        public IActionResult Edit()
        {
            
        }
        public IActionResult Delete()
        {
            
        }
    }
}


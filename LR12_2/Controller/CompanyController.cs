﻿using Microsoft.AspNetCore.Mvc;
using LR12_2.Data;
using System.Linq;

namespace LR12_2.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AppDbContext _context;

        public CompanyController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var companies = _context.Companies.ToList();
            return View(companies);
        }
    }
}
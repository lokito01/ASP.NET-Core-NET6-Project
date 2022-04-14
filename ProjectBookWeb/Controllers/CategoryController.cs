﻿using Microsoft.AspNetCore.Mvc;
using ProjectBookWeb.Data;
using ProjectBookWeb.Models;

namespace ProjectBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
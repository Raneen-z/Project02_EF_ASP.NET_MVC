﻿using EF_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly AppDbContext _db;

        public ProfilesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbProfiles = _db.Profiles.ToList();
            ViewBag.Profiles = DbProfiles;
            return View();
        }
    }
}

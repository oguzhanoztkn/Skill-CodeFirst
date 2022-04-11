﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirst.Models.Siniflar;

namespace Skill_CodeFirst.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var degerler = c.Yeteneklers.ToList();
            return View(degerler);
        }
    }
}
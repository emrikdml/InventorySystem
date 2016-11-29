﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Inventory System";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact no: 6605280208";

            return View();
        }
    }
}
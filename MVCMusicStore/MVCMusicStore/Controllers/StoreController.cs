﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        //         // GET: /Store/Browse  
        public ActionResult Browse()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

    }
}
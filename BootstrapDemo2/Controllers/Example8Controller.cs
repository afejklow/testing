﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo2.Controllers
{
    public class Example8Controller : Controller
    {
        // GET: Example8
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CodeView()
        {
            return View();

            //lets see if this works.  I am confused why my comment from the previous version is not showing here?  Did we finally figure this out?  I hope so!!  Arek, can you see this comment?
        }
    }
}

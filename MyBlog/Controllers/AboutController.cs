﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult AboutMe()
        {
            return View();
        }
    }
}
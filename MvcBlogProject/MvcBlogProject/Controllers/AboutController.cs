﻿using BusinessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager();
        // GET: About
        public ActionResult Index()
        {
            var abautcontent = abm.GetAll();
            return View(abautcontent);
        }
        public PartialViewResult Footer()
        {

            var aboutcontentlist = abm.GetAll();
            return PartialView(aboutcontentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManager authman = new AuthorManager();
            var authorlist = authman.GetAll();
            return PartialView(authorlist);
        }
        [HttpGet]
        public ActionResult UpdateAbout()
        {
            var adminabout = abm.GetAll();
            return View(adminabout);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.UpdateAboutBM(p);
            return RedirectToAction("UpdateAbout"); 
        }
        
         
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW1c.Models;
using HW1c.Backend;

namespace HW1c.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.TopNavType = "Visitor";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string id)
        {
            ViewBag.TopNavType = "Admin";
            return View();
        }

        public ActionResult Library()
        {
            var myViewModel = new LibViewModel();
            ViewBag.TopNavType = "Admin";

            myViewModel.PhotoViewModel = PhotoBackend.Instance.Index();

            return View(myViewModel);
        }

        public ActionResult PhotoPass()
        {
            var myViewModel = new LibViewModel();
            ViewBag.TopNavType = "Admin";

            myViewModel.PhotoViewModel = PhotoBackend.Instance.Pass();

            return View(myViewModel);
        }

        public ActionResult PhotoFail()
        {
            var myViewModel = new LibViewModel();
            ViewBag.TopNavType = "Admin";

            myViewModel.PhotoViewModel = PhotoBackend.Instance.Fail();

            return View(myViewModel);
        }


        /// <summary>
        /// Look up the record passed in
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Read(string id = null)
        {
            ViewBag.TopNavType = "Admin";
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = PhotoBackend.Instance.Read(id);
            return View(myData);
        }

        public ActionResult ReadPass(string id = null)
        {
            ViewBag.TopNavType = "Admin";
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = PhotoBackend.Instance.Read(id);
            return View(myData);
        }

        public ActionResult ReadFail(string id = null)
        {
            ViewBag.TopNavType = "Admin";
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = PhotoBackend.Instance.Read(id);
            return View(myData);
        }
    }
}
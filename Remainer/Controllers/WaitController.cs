using Remainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Remainer.Controllers
{
    public class WaitController : Controller
    {
        // GET: Wait
        public ActionResult Index()
        {
            return View();
        }

        // GET: Wait/Details
        public ActionResult Details()
        {
            var wait = new Wait { CurrentCount = "20"};
            return View(wait);
        }

        // GET: Wait/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wait/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wait/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wait/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wait/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wait/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

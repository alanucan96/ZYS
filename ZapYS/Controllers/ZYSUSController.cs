using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZapYS.Controllers
{
    public class ZYSUSController : Controller
    {
        // GET: ZYSUS
        public ActionResult List()
        {
            return View();
        }

        // GET: ZYSUS/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZYSUS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZYSUS/Create
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

        // GET: ZYSUS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZYSUS/Edit/5
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

        // GET: ZYSUS/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZYSUS/Delete/5
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

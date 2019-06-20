using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZapYS.Controllers
{
    public class ZYSController : Controller
    {
        // GET: ZYS
        public ActionResult Index()
        {
            return View();
        }

        // GET: ZYS/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZYS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZYS/Create
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

        // GET: ZYS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZYS/Edit/5
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

        // GET: ZYS/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZYS/Delete/5
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

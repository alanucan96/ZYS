using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapYS.Models;

namespace ZapYS.Controllers
{
    public class ZYSADController : Controller
    {
        private const string V = "user";
        ZapatosDAL ZapatosDAL = new ZapatosDAL();

        // GET: ZYSAD
        public ActionResult List()
        {
            if (Session[V] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                List<Zapatos> lstZapatos = new List<Zapatos>();
                lstZapatos = ZapatosDAL.ListarZapatos().ToList();
                return View(lstZapatos);
            }
        }

        // GET: ZYSAD/Details/5
        public ActionResult Details(int id)
        {
            if (Session[V] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        // GET: ZYSAD/Create
        public ActionResult Create()
        {
            if (Session[V] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        // POST: ZYSAD/Create
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

        // GET: ZYSAD/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session[V] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        // POST: ZYSAD/Edit/5
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

        // GET: ZYSAD/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session[V] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        // POST: ZYSAD/Delete/5
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

        UsersDAL UsersDAL = new UsersDAL();

        public ActionResult Logout()
        {
            Session[V] = null;
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            if (Session[V] != null)
            {
                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users u)
        {
            if (Session[V] == null)
            {
                List<Users> ListaUsuarios = UsersDAL.Login(u.correo, u.password).ToList();
                if (ListaUsuarios.Count != 0)
                {
                    Session[V] = u.correo;
                    return RedirectToAction("List", "ZYSAD");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("List", "ZYSAD");
            }
        }
    }
}

using System;
using Lab0_1223319_1003519.Helpers;
using Lab0_1223319_1003519.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab0_1223319_1003519.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View(Storage.Instance.clienteList);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var cliente = new Cliente
                {
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Telefono = int.Parse(collection["Telefono"]),
                    Descripcion = collection["Descripcion"],
                };
                if (cliente.Save())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(cliente);
                }
            }
            catch
            {
                return View();
            }
        }
        Helpers.MetododeOrdenamiento obj= new MetododeOrdenamiento(); 
        public ActionResult ordenarN(FormCollection collection)
        {

                obj.OrdenarNombre(Storage.Instance.clienteList);
                return RedirectToAction("Index");

        }
        public ActionResult ordenarA(FormCollection collection)
        {

            obj.OrdenarNombre(Storage.Instance.clienteList);
            return RedirectToAction("Index");

        }


        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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

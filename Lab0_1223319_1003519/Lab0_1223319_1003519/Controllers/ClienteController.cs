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

        public ActionResult OrdenarNombre()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < Storage.Instance.clienteList.Count - 1; i++)
                {
                    if (Storage.Instance.clienteList[i].Nombre.ToLower().CompareTo(Storage.Instance.clienteList[i + 1].Nombre.ToLower()) > 0)
                    {
                        Cliente aux = Storage.Instance.clienteList[i];
                        Storage.Instance.clienteList[i] = Storage.Instance.clienteList[i + 1];
                        Storage.Instance.clienteList[i + 1] = aux;
                        swap = true;
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult OrdenarApellido()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < Storage.Instance.clienteList.Count - 1; i++)
                {
                    if (Storage.Instance.clienteList[i].Apellido.ToLower().CompareTo(Storage.Instance.clienteList[i + 1].Apellido.ToLower()) > 0)
                    {
                        Cliente aux = Storage.Instance.clienteList[i];
                        Storage.Instance.clienteList[i] = Storage.Instance.clienteList[i + 1];
                        Storage.Instance.clienteList[i + 1] = aux;
                        swap = true;
                    }
                }
            }
            return RedirectToAction("Index");
        }
    }
}

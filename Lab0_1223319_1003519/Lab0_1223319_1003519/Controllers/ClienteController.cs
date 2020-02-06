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
                    //return Ordenar(true);
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
            for (int i = 1; i < Storage.Instance.clienteList.Count; i++)
            {
                for (int j = 0; j < Storage.Instance.clienteList.Count - i; j++)
                {
                    if (Storage.Instance.clienteList[j].Nombre.ToLower().CompareTo(Storage.Instance.clienteList[j + 1].Nombre.ToLower()) > 0)
                    {
                        Cliente aux = Storage.Instance.clienteList[j];
                        Storage.Instance.clienteList[j] = Storage.Instance.clienteList[j + 1];
                        Storage.Instance.clienteList[j + 1] = aux;
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult OrdenarApellido()
        {
            for (int i = 1; i < Storage.Instance.clienteList.Count; i++)
            {
                for (int j = 0; j < Storage.Instance.clienteList.Count - i; j++)
                {
                    if (Storage.Instance.clienteList[j].Apellido.ToLower().CompareTo(Storage.Instance.clienteList[j + 1].Apellido.ToLower()) > 0)
                    {
                        Cliente aux = Storage.Instance.clienteList[j];
                        Storage.Instance.clienteList[j] = Storage.Instance.clienteList[j + 1];
                        Storage.Instance.clienteList[j + 1] = aux;
                    }
                }
            }
            return RedirectToAction("Index");
        }
    }
}

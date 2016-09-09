using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prueba.Models;
namespace Prueba
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persona/Create
        public ActionResult Persona()
        {
            PersonaModel p = new PersonaModel();
            p.Nombre = "Pepe";
            p.Apellido = "Lopez";
            p.Id = 1;
            Contexto cont = new Contexto();
            cont.persona.Add(p);
            cont.SaveChanges();
            return View(p);
        }

        // POST: Persona/Create

        public ActionResult Create()
        {
            return View("Create");
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
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

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
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

        public void Crear(PersonaModel p)
        { 
           
        }
    }
}

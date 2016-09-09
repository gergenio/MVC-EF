using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void PruebaPost(PersonaModel p)
        {
            PersonaModel per = new PersonaModel();
            per.Nombre = p.Nombre;
        }

        public ActionResult Persona()
        {
            PersonaModel p = new PersonaModel();
            p.Nombre = "Pepe";
            p.Apellido = "Lopez";
            p.Id = 1;
            Contexto ct = new Contexto();
            ct.persona.Add(p);
            ct.SaveChanges();
            return View(p);
        }
        public void Vuelta(PersonaModel per)
        {
            Response.Write(per.Nombre);
            Response.Write(per.Apellido);
        }

        public ActionResult View()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Alumno()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Jose";
            alumno.Apellido = "Martinez";
            alumno.Edad = 30;
            Contexto dbcon = new Contexto();
            dbcon.alumno.Add(alumno);
            dbcon.SaveChanges();
            return View(alumno);
        }
    }
}
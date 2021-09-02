using first_aspnetcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first_aspnetcore.Controllers
{
    public class AsignaturaController : Controller
    {
        public ActionResult Index()
        {
            var asignaturas = new List<Asignatura>()
            {
                new Asignatura(){ Nombre = "Matemáticas"},
                new Asignatura(){ Nombre = "Educación Física"},
                new Asignatura(){ Nombre = "Castellano"},
                new Asignatura(){ Nombre = "Ciencias Naturales"},
                new Asignatura(){ Nombre = "Programacion"},
            };

            return View(asignaturas);
        }
    }
}

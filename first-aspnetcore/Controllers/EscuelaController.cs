using first_aspnetcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first_aspnetcore.Controllers
{
    public class EscuelaController : Controller
    {
        public ActionResult Index()
        {
            var escuela = new Escuela()
            {
                Nombre = "UCAB Guayana",
                Fundacion = DateTime.Now,
                Dirección = "Av. Atlántico",
                Ciudad = "Guayana",
                Pais = "Venezuela",
                TipoEscuela = TiposEscuela.Universidad,
            };

            return View(escuela);
        }
    }
}

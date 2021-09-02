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
                Id = Guid.NewGuid().ToString(),
                Nombre = "UCAB Guayana",
                Fundacion = DateTime.Now,
            };

            return View(escuela);
        }
    }
}

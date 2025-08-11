using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netdemo20252.Models;

namespace netdemo20252.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Mascota());
        }

        [HttpPost]
        public IActionResult Index(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = $"Registro exitoso de {mascota.Nombre}";
                return View("RegistroExitoso", mascota);
            }
            return View(mascota);
        }
    }
}


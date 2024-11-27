using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PIA_PROGRAMACIONWEB.Controllers
{
    public class UsuarioNoRegistradoController : Controller
    {
        public IActionResult IniciarSesion()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Historia()
        {
            return View();
        }

        public IActionResult Mision()
        {
            return View();
        }
        public IActionResult NuestroEquipo()
        {
            return View();
        }
        public IActionResult EventosEstatales()
        {
            return View();
        }
        public IActionResult EventosNacionales()
        {
            return View();
        }
        public IActionResult EventosInternacionales()
        {
            return View();
        }
        public IActionResult ProximosEventos()
        {
            return View();
        }
        public IActionResult Audiciones()
        {
            return View();
        }
    }
}

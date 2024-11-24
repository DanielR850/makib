using Microsoft.AspNetCore.Mvc;

namespace PIA_PROGRAMACIONWEB.Controllers
{
    public class UsuarioNoRegistradoController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Historia()
        {
            return View();
        }
    }
}

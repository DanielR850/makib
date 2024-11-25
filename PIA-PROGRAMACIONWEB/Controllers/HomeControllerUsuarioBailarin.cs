using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PIA_PROGRAMACIONWEB.Controllers
{
    [Authorize(Roles = "Bailarín")]
    public class UsuarioBailarinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PantallaHomeBailarin()
        {
            return View();
        }
        public IActionResult PantallaAsistenciaEnsayos()
        {
            return View();
        }
        public IActionResult PantallaAsistenciaEventos()
        {
        return View();
        }
        public IActionResult PantallaHistorialEnsayos()
        {
            return View();
        }        
        public IActionResult PantallaHistorialEventos()
        {
            return View();
        }

    }
}

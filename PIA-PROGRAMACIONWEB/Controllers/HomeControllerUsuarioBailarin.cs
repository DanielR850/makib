﻿using Microsoft.AspNetCore.Mvc;

namespace PIA_PROGRAMACIONWEB.Controllers
{
    public class UsuarioBailarinController : Controller
    {
        // Acción para la página Index
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
    }
}

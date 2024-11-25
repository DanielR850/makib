using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PIA_PROGRAMACIONWEB.Models;
using PIA_PROGRAMACIONWEB.Models.dbModels;

namespace PIA_PROGRAMACIONWEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoginController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.Usuario);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Usuario o contraseña incorrectos.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Usuario, model.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                if (await _userManager.IsInRoleAsync(user, "Administrador"))
                {
                    return RedirectToAction("Index", "UsuarioAdministrador");
                }
                else if (await _userManager.IsInRoleAsync(user, "Bailarín"))
                {
                    return RedirectToAction("Index", "UsuarioBailarin");
                }
            }

            ModelState.AddModelError(string.Empty, "Usuario o contraseña incorrectos.");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

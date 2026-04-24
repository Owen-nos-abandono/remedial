using Microsoft.AspNetCore.Mvc;
using ArroyoSecoGastronomia.Models;

namespace ArroyoSecoGastronomia.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            // Si ya hay sesión, redirigir al dashboard
            if (HttpContext.Session.GetString("UserName") != null)
                return RedirectToAction("Index", "Dashboard");

            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Usuarios hardcoded para demo (en producción usar BD + hash)
            var users = new[]
            {
                new { Email = "oferente@gastronomia.com", Password = "password123", Name = "Oferente Gastronomía" },
                new { Email = "admin@arroyoseco.com",     Password = "admin123",     Name = "Administrador" },
                new { Email = "2022371117@uteq.edu.mx",  Password = "password123",  Name = "Estudiante UTEQ" },
            };

            var user = users.FirstOrDefault(u =>
                u.Email.Equals(model.Email.Trim(), StringComparison.OrdinalIgnoreCase) &&
                u.Password == model.Password);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Correo o contraseña incorrectos.");
                return View(model);
            }

            // Guardar sesión
            HttpContext.Session.SetString("UserName", user.Name);
            HttpContext.Session.SetString("UserEmail", user.Email);

            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}

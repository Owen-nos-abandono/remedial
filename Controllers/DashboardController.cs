using Microsoft.AspNetCore.Mvc;
using ArroyoSecoGastronomia.Models;

namespace ArroyoSecoGastronomia.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var userName = HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(userName))
                return RedirectToAction("Login", "Account");

            var model = new DashboardViewModel
            {
                UserName = userName,
                RestaurantCount = 4,
                ActiveReservations = 0,
                PendingCount = 0,
                Restaurants = new List<Restaurant>
                {
                    new Restaurant
                    {
                        Id = 1,
                        Name = "Ruta 69 Gorditas y Quesadillas",
                        Address = "76400 Arroyo Seco, Qro",
                        ImageUrl = "https://images.unsplash.com/photo-1565299585323-38d6b0865b47?w=400&q=80"
                    },
                    new Restaurant
                    {
                        Id = 2,
                        Name = "DESVELADOS",
                        Address = "Cam. a Concá, del Sabino, 76410 El Crucero, Qro.",
                        ImageUrl = "https://images.unsplash.com/photo-1414235077428-338989a2e8c0?w=400&q=80"
                    },
                    new Restaurant
                    {
                        Id = 3,
                        Name = "Doña Juanita",
                        Address = "Rio Verde, Carretera Federal Jalpan KM. 12.5, Barrio El Calvario, 76440 Purísima de Arista, Qro.",
                        ImageUrl = "https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?w=400&q=80"
                    },
                    new Restaurant
                    {
                        Id = 4,
                        Name = "El Rincón Serrano",
                        Address = "Arroyo Seco, Querétaro",
                        ImageUrl = "https://images.unsplash.com/photo-1555396273-367ea4eb4db5?w=400&q=80"
                    }
                }
            };

            return View(model);
        }

        // Acción stub para las demás secciones
        public IActionResult MisRestaurantes()
        {
            if (HttpContext.Session.GetString("UserName") == null)
                return RedirectToAction("Login", "Account");
            return View("Placeholder", "Mis Restaurantes");
        }

        public IActionResult Reservas()
        {
            if (HttpContext.Session.GetString("UserName") == null)
                return RedirectToAction("Login", "Account");
            return View("Placeholder", "Reservas");
        }

        public IActionResult Reseñas()
        {
            if (HttpContext.Session.GetString("UserName") == null)
                return RedirectToAction("Login", "Account");
            return View("Placeholder", "Reseñas");
        }

        public IActionResult Notificaciones()
        {
            if (HttpContext.Session.GetString("UserName") == null)
                return RedirectToAction("Login", "Account");
            return View("Placeholder", "Notificaciones");
        }

        public IActionResult Configuracion()
        {
            if (HttpContext.Session.GetString("UserName") == null)
                return RedirectToAction("Login", "Account");
            return View("Placeholder", "Configuración");
        }
    }
}

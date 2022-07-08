using Microsoft.AspNetCore.Mvc;

namespace cp202201_voto_MVC_v1.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearProcesoVotacion()
        {
            return View();
        }
    }
}

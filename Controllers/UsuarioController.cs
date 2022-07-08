using Microsoft.AspNetCore.Mvc;

namespace cp202201_voto_MVC_v1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistroVotacion()
        {
            return View();
        }
    }
}

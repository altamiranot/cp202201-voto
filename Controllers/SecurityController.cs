using cp202201_voto_MVC_v1.Service;
using Microsoft.AspNetCore.Mvc;

namespace cp202201_voto_MVC_v1.Controllers
{
    public class SecurityController : Controller
    {
        public async Task <IActionResult> signUp()
        {
            var usuarios = await UsuarioService.Post();

            return View(usuarios);
        }

        public IActionResult login()
        {
            return View();
        }
    }
}

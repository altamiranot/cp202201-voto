using Microsoft.AspNetCore.Mvc;

namespace cp202201_voto_MVC_v1.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult signUp()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }
    }
}

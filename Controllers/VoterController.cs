using Microsoft.AspNetCore.Mvc;

namespace cp202201_voto_MVC_v1.Controllers
{
    public class VoterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Results()
        {
            return View();
        }

        public IActionResult newVote()
        {
            return View();
        }

        public IActionResult createPeriod()
        {
            return View();
        }


    }
}

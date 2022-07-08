using cp202201_voto_MVC_v1.Models;
using cp202201_voto_MVC_v1.Service;
using Microsoft.AspNetCore.Mvc;

namespace cp202201_voto_MVC_v1.Controllers
{
    public class SecurityController : Controller
    {
        public async Task <IActionResult> signUp()
        {
            //var usuarios = await UsuarioService.Post();

            return View();
        }

        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Autenticarse(IFormCollection form)
        {
            var correo = form["correo"];
            var clave = form["clave"];

            //Enviar al endpoint para validar si el correo y clave existe


            return RedirectToAction("RegistroVotacion", "Usuario");
        }

        [HttpPost]
        public async Task<IActionResult> login(IFormCollection form)
        {
            var usuario = new UsuarioModel();
            usuario.Paterno = form["paterno"];
            usuario.Materno = form["materno"];
            usuario.Nombres = form["nombres"];
            usuario.Correo = form["correo"];
            usuario.NumeroDocumento = form["dni"];
            usuario.Telefono = form["telefono"];
            usuario.FechaNacimiento = Convert.ToDateTime(form["fechaNacimiento"]);
            usuario.Dirección = form["direccion"];
            usuario.Password = form["clave"];
            //var paterno = form["paterno"];
            var result = await UsuarioService.Create(usuario);

            if (result>0)
                return RedirectToAction("login");
            else
                return RedirectToAction("signUp");

        }
    }
}

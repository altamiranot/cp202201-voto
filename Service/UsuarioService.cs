using cp202201_voto_MVC_v1.Models;
using Newtonsoft.Json;

namespace cp202201_voto_MVC_v1.Service
{
    public class UsuarioService
    {
        public static async Task<UsuarioModel> Post()
        { 
            string url = "http://localhost:5158/api/Usuario/Create";

            var client = new HttpClient();
            var response = await client.PostAsync(url + "Create", null);

            string result = await response.Content.ReadAsStringAsync();

            var usuarios = JsonConvert.DeserializeObject<UsuarioModel>(result);

            return usuarios;
        }
    }
}

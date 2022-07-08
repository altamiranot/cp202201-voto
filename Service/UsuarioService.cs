using System.Text;
using cp202201_voto_MVC_v1.Models;
using Newtonsoft.Json;

namespace cp202201_voto_MVC_v1.Service
{
    public class UsuarioService
    {
        //public static async Task<UsuarioModel> Post()
        //{ 
        //    string url = "http://localhost:5158/api/Usuario/Create";

        //    var client = new HttpClient();
        //    var response = await client.PostAsync(url + "Create", null);

        //    string result = await response.Content.ReadAsStringAsync();

        //    var usuarios = JsonConvert.DeserializeObject<UsuarioModel>(result);

        //    return usuarios;
        //}

        public static async Task<int> Create(UsuarioModel usuario)
        {
            string urlBase = "http://localhost:5158/api/Usuario/Create";

            var json = JsonConvert.SerializeObject(usuario);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var httpClient = new HttpClient();
            using var response = await httpClient.PostAsync(urlBase, data);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var userId = JsonConvert.DeserializeObject<int>(apiResponse);

            return userId;
        }


    }
}

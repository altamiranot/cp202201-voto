namespace cp202201_voto_MVC_v1.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Paterno { get; set; }
        public string? Materno { get; set; }
        public string? Nombres { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Telefono { get; set; }
        public string? Dirección { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Password { get; set; }
        public string? Correo { get; set; }
        public bool? EsAdmin { get; set; }
    }
}

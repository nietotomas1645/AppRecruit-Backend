namespace BackendApi.Models
{
    public class FileModel
    {
        public IFormFile MyFile { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}

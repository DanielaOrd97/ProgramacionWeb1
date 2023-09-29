namespace Act1_U1.Models.ViewModels
{
    public class PerfilViewModel
    {
        public string Materia { get; set; } = null!;
        public int Semestre { get; set; }
        public string Periodo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string NumControl { get; set; } = null!;
        public string Carrera { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string?  Correo { get; set; } 
    }
}

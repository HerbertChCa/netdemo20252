using System.ComponentModel.DataAnnotations;

namespace netdemo20252.Models
{
    public class Mascota
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La raza es obligatoria")]
        public string? Raza { get; set; }
        [Range(0, 30, ErrorMessage = "La edad debe estar entre 0 y 30 años")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El propietario es obligatorio")]
        public string? Propietario { get; set; }
    }
}

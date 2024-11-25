using System.ComponentModel.DataAnnotations;

namespace PIA_PROGRAMACIONWEB.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

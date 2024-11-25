using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PIA_PROGRAMACIONWEB.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {

        public string Usuario { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;




        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<AsistenciaEnsayo> AsistenciaEnsayos { get; set; } = new List<AsistenciaEnsayo>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<AsistenciaEvento> AsistenciaEventos { get; set; } = new List<AsistenciaEvento>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Audicione> Audiciones { get; set; } = new List<Audicione>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Carrusel> Carrusels { get; set; } = new List<Carrusel>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Contactano> Contactanos { get; set; } = new List<Contactano>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<SeccionAcercaNosotrosYportafolio> SeccionAcercaNosotrosYportafolios { get; set; } = new List<SeccionAcercaNosotrosYportafolio>();
    }
}

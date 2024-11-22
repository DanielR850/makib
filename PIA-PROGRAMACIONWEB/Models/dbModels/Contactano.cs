using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

public partial class Contactano
{
    [Key]
    public int IdContacto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RedSocial { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Link { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    public int IdUsuario { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Contactanos")]
    public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

[Table("Carrusel")]
public partial class Carrusel
{
    [Key]
    public int IdImagen { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string RutaImagen { get; set; } = null!;

    public int IdUsuario { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string TextoAlternativo { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("Carrusels")]
    public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
}

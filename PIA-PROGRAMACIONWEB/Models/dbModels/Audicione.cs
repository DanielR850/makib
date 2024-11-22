using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

public partial class Audicione
{
    [Key]
    public int IdAudicion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Titulo { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Link { get; set; } = null!;

    public int IdUsuario { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Audiciones")]
    public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
}

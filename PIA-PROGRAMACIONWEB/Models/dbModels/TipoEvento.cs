using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

[Table("TipoEvento")]
public partial class TipoEvento
{
    [Key]
    public int IdTipoEvento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NombreTipo { get; set; } = null!;

    [InverseProperty("IdTipoEventoNavigation")]
    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}

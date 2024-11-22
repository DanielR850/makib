using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

public partial class Ensayo
{
    [Key]
    public int IdEnsayo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NombreEnsayo { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public TimeOnly Hora { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Lugar { get; set; } = null!;

    [InverseProperty("IdEnsayoNavigation")]
    public virtual ICollection<AsistenciaEnsayo> AsistenciaEnsayos { get; set; } = new List<AsistenciaEnsayo>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

public partial class Evento
{
    [Key]
    public int IdEvento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NombreEvento { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public TimeOnly Hora { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Lugar { get; set; } = null!;

    public int IdTipoEvento { get; set; }

    [InverseProperty("IdEventoNavigation")]
    public virtual ICollection<AsistenciaEvento> AsistenciaEventos { get; set; } = new List<AsistenciaEvento>();

    [ForeignKey("IdTipoEvento")]
    [InverseProperty("Eventos")]
    public virtual TipoEvento IdTipoEventoNavigation { get; set; } = null!;

    [InverseProperty("IdEventoNavigation")]
    public virtual ICollection<ReporteAsistenciaEvento> ReporteAsistenciaEventos { get; set; } = new List<ReporteAsistenciaEvento>();
}

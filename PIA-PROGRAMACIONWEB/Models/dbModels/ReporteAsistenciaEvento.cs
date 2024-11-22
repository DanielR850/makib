using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

public partial class ReporteAsistenciaEvento
{
    [Key]
    public int IdReporte { get; set; }

    public int IdEvento { get; set; }

    public int TotalConfirmados { get; set; }

    public int TotalAsistentes { get; set; }

    public DateOnly? FechaReporte { get; set; }

    [ForeignKey("IdEvento")]
    [InverseProperty("ReporteAsistenciaEventos")]
    public virtual Evento IdEventoNavigation { get; set; } = null!;
}

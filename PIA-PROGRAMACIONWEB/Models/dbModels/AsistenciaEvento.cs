using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

[PrimaryKey("IdEvento", "IdUsuario")]
public partial class AsistenciaEvento
{
    [Key]
    public int IdEvento { get; set; }

    [Key]
    public int IdUsuario { get; set; }

    public bool ConfirmoAsistencia { get; set; }

    public DateOnly FechaRespuesta { get; set; }

    [ForeignKey("IdEvento")]
    [InverseProperty("AsistenciaEventos")]
    public virtual Evento IdEventoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("AsistenciaEventos")]
    public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

[PrimaryKey("IdEnsayo", "IdUsuario")]
public partial class AsistenciaEnsayo
{
    [Key]
    public int IdEnsayo { get; set; }

    [Key]
    public int IdUsuario { get; set; }

    public bool ConfirmoAsistencia { get; set; }

    public DateOnly FechaRespuesta { get; set; }

    [ForeignKey("IdEnsayo")]
    [InverseProperty("AsistenciaEnsayos")]
    public virtual Ensayo IdEnsayoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("AsistenciaEnsayos")]
    public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

[Table("SeccionAcercaNosotrosYPortafolio")]
public partial class SeccionAcercaNosotrosYportafolio
{
    [Key]
    public int IdSeccion { get; set; }

    public int IdCatalogo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Titulo { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string ContenidoTexto { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Imagen { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string TextoAlternativo { get; set; } = null!;

    public int IdUsuario { get; set; }

    public int Orden { get; set; }

    [ForeignKey("IdCatalogo")]
    [InverseProperty("SeccionAcercaNosotrosYportafolios")]
    public virtual CatalogoSeccione IdCatalogoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("SeccionAcercaNosotrosYportafolios")]
    public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
}

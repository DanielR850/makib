using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

public partial class CatalogoSeccione
{
    [Key]
    public int IdCatalogo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdCatalogoNavigation")]
    public virtual ICollection<SeccionAcercaNosotrosYportafolio> SeccionAcercaNosotrosYportafolios { get; set; } = new List<SeccionAcercaNosotrosYportafolio>();
}

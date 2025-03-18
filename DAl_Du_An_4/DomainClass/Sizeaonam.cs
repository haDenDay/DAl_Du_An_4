using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("SIZEAONAM")]
public partial class Sizeaonam
{
    [Key]
    [Column("MASIZE")]
    [StringLength(30)]
    [Unicode(false)]
    public string Masize { get; set; } = null!;

    [Column("SIZE")]
    [StringLength(50)]
    public string? Size { get; set; }

    [Column("TRANGTH")]
    public bool? Trangth { get; set; }

    [InverseProperty("MasizeNavigation")]
    public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; } = new List<Chitietsanpham>();
}

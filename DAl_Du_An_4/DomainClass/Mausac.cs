using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("MAUSAC")]
public partial class Mausac
{
    [Key]
    [Column("MAMAU")]
    [StringLength(30)]
    [Unicode(false)]
    public string Mamau { get; set; } = null!;

    [Column("TENMAU")]
    [StringLength(50)]
    public string? Tenmau { get; set; }

    [Column("TRGTHAI")]
    public bool? Trgthai { get; set; }

    [InverseProperty("MamauNavigation")]
    public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; } = new List<Chitietsanpham>();
}

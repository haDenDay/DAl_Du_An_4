using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("THELOAI")]
public partial class Theloai
{
    [Key]
    [Column("MATL")]
    [StringLength(30)]
    [Unicode(false)]
    public string Matl { get; set; } = null!;

    [Column("TENTL")]
    [StringLength(50)]
    public string? Tentl { get; set; }

    [Column("TRAGTHAI")]
    public bool? Tragthai { get; set; }

    [InverseProperty("MatlNavigation")]
    public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; } = new List<Chitietsanpham>();
}

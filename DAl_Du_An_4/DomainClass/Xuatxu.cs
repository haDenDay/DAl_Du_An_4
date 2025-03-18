using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("XUATXU")]
public partial class Xuatxu
{
    [Key]
    [Column("MAXX")]
    [StringLength(30)]
    [Unicode(false)]
    public string Maxx { get; set; } = null!;

    [Column("DIACHI")]
    [StringLength(50)]
    public string? Diachi { get; set; }

    [Column("TRNGTHAI")]
    public bool? Trngthai { get; set; }

    [InverseProperty("MaxxNavigation")]
    public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; } = new List<Chitietsanpham>();
}

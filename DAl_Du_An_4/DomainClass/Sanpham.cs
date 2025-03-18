using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("SANPHAM")]
public partial class Sanpham
{
    [Key]
    [Column("MASP")]
    [StringLength(30)]
    [Unicode(false)]
    public string Masp { get; set; } = null!;

    [Column("TENSP")]
    [StringLength(50)]
    public string? Tensp { get; set; }

    [Column("SOLUONG")]
    public int? Soluong { get; set; }

    [Column("GIA", TypeName = "money")]
    public decimal? Gia { get; set; }

    [Column("MOTA")]
    [StringLength(100)]
    public string? Mota { get; set; }

    [Column("NGAYSUA")]
    public DateOnly? Ngaysua { get; set; }

    [Column("NGAYNHAN")]
    public DateOnly? Ngaynhan { get; set; }

    [Column("NGUOINHAN")]
    [StringLength(50)]
    public string? Nguoinhan { get; set; }

    [Column("NGUOISUA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nguoisua { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [InverseProperty("MaspNavigation")]
    public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; } = new List<Chitietsanpham>();

    [InverseProperty("MaspNavigation")]
    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();
}

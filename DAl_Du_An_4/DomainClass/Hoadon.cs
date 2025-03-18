using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("HOADON")]
public partial class Hoadon
{
    [Key]
    [Column("MAHD")]
    [StringLength(30)]
    [Unicode(false)]
    public string Mahd { get; set; } = null!;

    [Column("MANV")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Manv { get; set; }

    [Column("XUATXU")]
    [StringLength(100)]
    public string? Xuatxu { get; set; }

    [Column("THANHTIEN", TypeName = "money")]
    public decimal? Thanhtien { get; set; }

    [Column("NGAYSUA")]
    public DateOnly? Ngaysua { get; set; }

    [Column("NGAYTAO")]
    public DateOnly? Ngaytao { get; set; }

    [Column("NGUOITAO")]
    [StringLength(50)]
    public string? Nguoitao { get; set; }

    [Column("NGUOISUA")]
    [StringLength(50)]
    public string? Nguoisua { get; set; }

    [Column("TRAGTH")]
    public bool? Tragth { get; set; }

    [InverseProperty("MahdNavigation")]
    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    [ForeignKey("Manv")]
    [InverseProperty("Hoadons")]
    public virtual Nhanvien? ManvNavigation { get; set; }
}

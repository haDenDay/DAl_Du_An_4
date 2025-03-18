using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("KHACHHANG")]
public partial class Khachhang
{
    [Key]
    [Column("MAKH")]
    [StringLength(30)]
    [Unicode(false)]
    public string Makh { get; set; } = null!;

    [Column("TENKH")]
    [StringLength(50)]
    public string? Tenkh { get; set; }

    [Column("SDT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [Column("DIACHI")]
    [StringLength(100)]
    public string? Diachi { get; set; }

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

    [Column("TRATHAI")]
    public bool? Trathai { get; set; }

    [InverseProperty("MakhNavigation")]
    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("KHUYENMAI")]
public partial class Khuyenmai
{
    [Key]
    [Column("MAKM")]
    [StringLength(30)]
    [Unicode(false)]
    public string Makm { get; set; } = null!;

    [Column("TENKM")]
    [StringLength(50)]
    public string? Tenkm { get; set; }

    [Column("SOLUONG")]
    public int? Soluong { get; set; }

    [Column("HSD")]
    public DateOnly? Hsd { get; set; }

    [Column("XUATXU")]
    [StringLength(100)]
    public string? Xuatxu { get; set; }

    [Column("NGAYSUA")]
    public DateOnly? Ngaysua { get; set; }

    [Column("NGAYTAO")]
    public DateOnly? Ngaytao { get; set; }

    [Column("NGUOITAO")]
    [StringLength(50)]
    public string? Nguoitao { get; set; }

    [Column("NGUOISUA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nguoisua { get; set; }

    [Column("TGTHAI")]
    public bool? Tgthai { get; set; }

    [InverseProperty("MakmNavigation")]
    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();
}

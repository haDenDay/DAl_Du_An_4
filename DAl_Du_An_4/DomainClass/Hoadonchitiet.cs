using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("HOADONCHITIET")]
public partial class Hoadonchitiet
{
    [Key]
    [Column("MAHDCT")]
    [StringLength(30)]
    [Unicode(false)]
    public string Mahdct { get; set; } = null!;

    [Column("MAHD")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Mahd { get; set; }

    [Column("MASP")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Masp { get; set; }

    [Column("MAKH")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Makh { get; set; }

    [Column("MAKM")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Makm { get; set; }

    [Column("SOLUONG")]
    public int? Soluong { get; set; }

    [Column("PTTT")]
    [StringLength(30)]
    public string? Pttt { get; set; }

    [Column("XUATXUHOADON")]
    [StringLength(100)]
    public string? Xuatxuhoadon { get; set; }

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

    [Column("TRTHAI")]
    public bool? Trthai { get; set; }

    [ForeignKey("Mahd")]
    [InverseProperty("Hoadonchitiets")]
    public virtual Hoadon? MahdNavigation { get; set; }

    [ForeignKey("Makh")]
    [InverseProperty("Hoadonchitiets")]
    public virtual Khachhang? MakhNavigation { get; set; }

    [ForeignKey("Makm")]
    [InverseProperty("Hoadonchitiets")]
    public virtual Khuyenmai? MakmNavigation { get; set; }

    [ForeignKey("Masp")]
    [InverseProperty("Hoadonchitiets")]
    public virtual Sanpham? MaspNavigation { get; set; }
}

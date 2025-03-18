using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("TAIKHOAN")]
public partial class Taikhoan
{
    [Key]
    [Column("MATK")]
    [StringLength(30)]
    [Unicode(false)]
    public string Matk { get; set; } = null!;

    [Column("TENTK")]
    [StringLength(50)]
    public string? Tentk { get; set; }

    [Column("MATKHAU")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Matkhau { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

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

    [Column("PHANLOAITK")]
    [StringLength(50)]
    public string? Phanloaitk { get; set; }

    [InverseProperty("MatkNavigation")]
    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("NHANVIEN")]
public partial class Nhanvien
{
    [Key]
    [Column("MANV")]
    [StringLength(30)]
    [Unicode(false)]
    public string Manv { get; set; } = null!;

    [Column("MATK")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Matk { get; set; }

    [Column("TENNV")]
    [StringLength(50)]
    public string? Tennv { get; set; }

    [Column("NGAYSINH")]
    public DateOnly? Ngaysinh { get; set; }

    [Column("GIOITINH")]
    [StringLength(10)]
    public string? Gioitinh { get; set; }

    [Column("DIACHI")]
    [StringLength(100)]
    public string? Diachi { get; set; }

    [Column("QUOCTICH")]
    [StringLength(20)]
    public string? Quoctich { get; set; }

    [Column("NOITHUONGCHU")]
    [StringLength(200)]
    public string? Noithuongchu { get; set; }

    [Column("SOCCCD")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Socccd { get; set; }

    [Column("CHUCVU")]
    [StringLength(100)]
    public string? Chucvu { get; set; }

    [Column("NGAYSUA")]
    public DateOnly? Ngaysua { get; set; }

    [Column("NGAYNHAN")]
    public DateOnly? Ngaynhan { get; set; }

    [Column("NGUOINHAN")]
    [StringLength(50)]
    public string? Nguoinhan { get; set; }

    [Column("NGUOISUA")]
    [StringLength(50)]
    public string? Nguoisua { get; set; }

    [Column("TRNGTHAI")]
    public bool? Trngthai { get; set; }

    [InverseProperty("ManvNavigation")]
    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    [ForeignKey("Matk")]
    [InverseProperty("Nhanviens")]
    public virtual Taikhoan? MatkNavigation { get; set; }
}

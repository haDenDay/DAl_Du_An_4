using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.DomainClass;

[Table("CHITIETSANPHAM")]
public partial class Chitietsanpham
{
    [Key]
    [Column("MACTSP")]
    [StringLength(30)]
    [Unicode(false)]
    public string Mactsp { get; set; } = null!;

    [Column("MASP")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Masp { get; set; }

    [Column("MATL")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Matl { get; set; }

    [Column("MAMAU")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Mamau { get; set; }

    [Column("MAXX")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Maxx { get; set; }

    [Column("MASIZE")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Masize { get; set; }

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

    [Column("TRNGTHAI")]
    public bool? Trngthai { get; set; }

    [ForeignKey("Mamau")]
    [InverseProperty("Chitietsanphams")]
    public virtual Mausac? MamauNavigation { get; set; }

    [ForeignKey("Masize")]
    [InverseProperty("Chitietsanphams")]
    public virtual Sizeaonam? MasizeNavigation { get; set; }

    [ForeignKey("Masp")]
    [InverseProperty("Chitietsanphams")]
    public virtual Sanpham? MaspNavigation { get; set; }

    [ForeignKey("Matl")]
    [InverseProperty("Chitietsanphams")]
    public virtual Theloai? MatlNavigation { get; set; }

    [ForeignKey("Maxx")]
    [InverseProperty("Chitietsanphams")]
    public virtual Xuatxu? MaxxNavigation { get; set; }
}

using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Du_An_4
{
    public partial class BANHANG : Form
    {
        CTSP_Service ct_se = new CTSP_Service();
        Use_Service use_ser = new Use_Service();
        Hoadon_Service hd_se = new Hoadon_Service();
        KH_KM_Service kk_se = new KH_KM_Service();
        NhanVien_Service nv_se = new NhanVien_Service();
        public string Click;
        public string Clickhd;
        private string ClickHDCT;
        string infor_use;
        decimal? Thanhtien;
        string _IDHdDaThanhToan;
        public BANHANG(string taikhoan)
        {
            InitializeComponent();
            txt_nhanvien.Text = taikhoan;
            txt_nhanvien.Enabled = false;
            txt_thanhtien.Enabled = false;
            infor_use = taikhoan;
            txt_mahoadon.Enabled = false;
            LoadDataSP();
        }

        public void LoadHD()
        {
            dtg_hd.ColumnCount = 5;

            dtg_hd.Columns[0].Name = "Mã hóa đơn";
            dtg_hd.Columns[1].Name = "Mã nhân viên";
            dtg_hd.Columns[2].Name = "Thành tiền";
            dtg_hd.Columns[3].Name = "Ngày tạo";
            dtg_hd.Columns[4].Name = "Trạng thái";

            dtg_hd.Rows.Clear();

            foreach (var hd in hd_se.GetHoadons())
            {
                dtg_hd.Rows.Add(hd.Mahd, hd.Manv, hd.Thanhtien == null ? 0 + " " + "VND" : hd.Thanhtien + " " + "VND", hd.Ngaytao, hd.Tragth == true ? "Còn hạn" : "Hết hạn");
            }
        }

        private void LoadDataSP()
        {
            dtg_sp.ColumnCount = 12;

            dtg_sp.Columns[0].Name = "Mã chi tiết sản phẩm";
            dtg_sp.Columns[1].Name = "Tên Sản phẩm";
            dtg_sp.Columns[2].Name = "Giá";
            dtg_sp.Columns[3].Name = "Tên thể loại";
            dtg_sp.Columns[4].Name = "Tên màu";
            dtg_sp.Columns[5].Name = "Xuất xứ";
            dtg_sp.Columns[6].Name = "Size";
            dtg_sp.Columns[7].Name = "Ngày sửa";
            dtg_sp.Columns[8].Name = "Ngày nhận";
            dtg_sp.Columns[9].Name = "Người nhận";
            dtg_sp.Columns[10].Name = "Người sửa";
            dtg_sp.Columns[11].Name = "Trạng thái";

            dtg_sp.Rows.Clear();


            var ltctsp = ct_se.GetChitietsanphams();
            var ltsp = ct_se.GetSanpham();
            var lttl = ct_se.GetTheloais();
            var ltm = ct_se.GetMausacs();
            var lts = ct_se.GetSizes();
            var ltxx = ct_se.GetXuatxus();

            var datajon = ltctsp.Join(ltsp,
                                      ctsp => ctsp.Masp,
                                      sp => sp.Masp,
                                      (ctsp, sp) => new
                                      {
                                          Mactsp = ctsp.Mactsp,
                                          Tensp = sp.Tensp,
                                          Gia = sp.Gia,
                                          Matl = ctsp.Matl,
                                          Mamau = ctsp.Mamau,
                                          Maxx = ctsp.Maxx,
                                          Masize = ctsp.Masize,
                                          Ngaysua = ctsp.Ngaysua,
                                          Ngaynhan = ctsp.Ngaynhan,
                                          Nguoinhan = ctsp.Nguoinhan,
                                          Nguoisua = ctsp.Nguoisua,
                                          Trangthai = ctsp.Trngthai
                                      })
                                       .Join(lttl,
                                       s => s.Matl,
                                       tl => tl.Matl,
                                       (s, tl) => new
                                       {
                                           Mactsp = s.Mactsp,
                                           Tensp = s.Tensp,
                                           Gia = s.Gia,
                                           Tentl = tl.Tentl,
                                           Mamau = s.Mamau,
                                           Maxx = s.Maxx,
                                           Masize = s.Masize,
                                           Ngaysua = s.Ngaysua,
                                           Ngaynhan = s.Ngaynhan,
                                           Nguoinhan = s.Nguoinhan,
                                           Nguoisua = s.Nguoisua,
                                           Trangthai = s.Trangthai
                                       })
                                       .Join(ltm,
                                       b => b.Mamau,
                                       m => m.Mamau,
                                       (b, m) => new
                                       {
                                           Mactsp = b.Mactsp,
                                           Tensp = b.Tensp,
                                           Gia = b.Gia,
                                           Tentl = b.Tentl,
                                           Mau = m.Tenmau,
                                           Maxx = b.Maxx,
                                           Masize = b.Masize,
                                           Ngaysua = b.Ngaysua,
                                           Ngaynhan = b.Ngaynhan,
                                           Nguoinhan = b.Nguoinhan,
                                           Nguoisua = b.Nguoisua,
                                           Trangthai = b.Trangthai
                                       })
                                       .Join(ltxx,
                                       c => c.Maxx,
                                       x => x.Maxx,
                                       (c, x) => new
                                       {
                                           Mactsp = c.Mactsp,
                                           Tensp = c.Tensp,
                                           Gia = c.Gia,
                                           Tentl = c.Tentl,
                                           Mau = c.Mau,
                                           DiaChi = x.Diachi,
                                           Masize = c.Masize,
                                           Ngaysua = c.Ngaysua,
                                           Ngaynhan = c.Ngaynhan,
                                           Nguoinhan = c.Nguoinhan,
                                           Nguoisua = c.Nguoisua,
                                           Trangthai = c.Trangthai
                                       })
                                       .Join(lts,
                                       d => d.Masize,
                                       k => k.Masize,
                                       (d, k) => new
                                       {
                                           Mactsp = d.Mactsp,
                                           Tensp = d.Tensp,
                                           Gia = d.Gia,
                                           Tentl = d.Tentl,
                                           Mau = d.Mau,
                                           DiaChi = d.DiaChi,
                                           Size = k.Size,
                                           Ngaysua = d.Ngaysua,
                                           Ngaynhan = d.Ngaynhan,
                                           Nguoinhan = d.Nguoinhan,
                                           Nguoisua = d.Nguoisua,
                                           Trangthai = d.Trangthai
                                       }).ToList();
            foreach (var item in datajon)
            {
                dtg_sp.Rows.Add(item.Mactsp, item.Tensp, item.Gia, item.Tentl, item.Mau, item.DiaChi, item.Size,
                                item.Ngaysua, item.Ngaynhan, item.Nguoinhan, item.Nguoisua, item.Trangthai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private string GetPathAnh(string tenSanPham)
        {
            if (pathAnhSanPham.ContainsKey(tenSanPham))
            {
                return pathAnhSanPham[tenSanPham];
            }
            else
            {
                return "C:\\Images\\default.jpg";
            }
        }

        private Dictionary<string, string> pathAnhSanPham = new Dictionary<string, string>
{
            { "CT001", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\AoSomiTrang.jpg" },
            { "CT002", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aoSoMiTrang2.jpg" },
            { "CT003", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aoThunden1.jpg" },
            { "CT004", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\demi1.jpg" },
            { "CT005", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh dbg\\aothundenTrang.jpg" },
            { "CT006", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\demi2.jpg" },
            { "CT007", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\z5678984228519_7cea90677c0d72fadb4db1a9c4ebc504.jpg" },
            { "CT008", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aoSoMiTrang2.jpg" },
            { "CT009", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\z5678987824550_e6889af633c8a103e52946ddc838c739.jpg" },
        };

        private void dtg_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong < 0 || dong >= ct_se.GetChitietsanphams().Count)
            {
                return;
            }
            Click = dtg_sp.Rows[dong].Cells[0].Value.ToString();
            BindatSp();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy thông tin về sản phẩm từ hàng được chọn
                string tenSanPham = dtg_sp.Rows[e.RowIndex].Cells[0].Value.ToString();
                string pathAnh = GetPathAnh(tenSanPham); // Hàm lấy đường dẫn ảnh tương ứng với tên sản phẩm

                // Hiển thị ảnh lên PictureBox
                pcb_anhsp.Image = Image.FromFile(pathAnh);
            }
        }

        private void BindatSp()
        {

            var ltctsp = ct_se.GetChitietsanphams();
            var ltsp = ct_se.GetSanpham();
            var lttl = ct_se.GetTheloais();
            var ltm = ct_se.GetMausacs();
            var lts = ct_se.GetSizes();
            var ltxx = ct_se.GetXuatxus();

            var datajon = ltctsp.Join(ltsp,
                                      ctsp => ctsp.Masp,
                                      sp => sp.Masp,
                                      (ctsp, sp) => new
                                      {
                                          Mactsp = ctsp.Mactsp,
                                          Tensp = sp.Tensp,
                                          Gia = sp.Gia,
                                          Soluong = sp.Soluong,
                                          Matl = ctsp.Matl,
                                          Mamau = ctsp.Mamau,
                                          Maxx = ctsp.Maxx,
                                          Masize = ctsp.Masize,
                                          Ngaysua = ctsp.Ngaysua,
                                          Ngaynhan = ctsp.Ngaynhan,
                                          Nguoinhan = ctsp.Nguoinhan,
                                          Nguoisua = ctsp.Nguoisua,
                                          Trangthai = ctsp.Trngthai
                                      })
                                       .Join(lttl,
                                       s => s.Matl,
                                       tl => tl.Matl,
                                       (s, tl) => new
                                       {
                                           Mactsp = s.Mactsp,
                                           Tensp = s.Tensp,
                                           Gia = s.Gia,
                                           Soluong = s.Soluong,
                                           Tentl = tl.Tentl,
                                           Mamau = s.Mamau,
                                           Maxx = s.Maxx,
                                           Masize = s.Masize,
                                           Ngaysua = s.Ngaysua,
                                           Ngaynhan = s.Ngaynhan,
                                           Nguoinhan = s.Nguoinhan,
                                           Nguoisua = s.Nguoisua,
                                           Trangthai = s.Trangthai
                                       })
                                       .Join(ltm,
                                       b => b.Mamau,
                                       m => m.Mamau,
                                       (b, m) => new
                                       {
                                           Mactsp = b.Mactsp,
                                           Tensp = b.Tensp,
                                           Gia = b.Gia,
                                           Soluong = b.Soluong,
                                           Tentl = b.Tentl,
                                           Mau = m.Tenmau,
                                           Maxx = b.Maxx,
                                           Masize = b.Masize,
                                           Ngaysua = b.Ngaysua,
                                           Ngaynhan = b.Ngaynhan,
                                           Nguoinhan = b.Nguoinhan,
                                           Nguoisua = b.Nguoisua,
                                           Trangthai = b.Trangthai
                                       })
                                       .Join(ltxx,
                                       c => c.Maxx,
                                       x => x.Maxx,
                                       (c, x) => new
                                       {
                                           Mactsp = c.Mactsp,
                                           Tensp = c.Tensp,
                                           Gia = c.Gia,
                                           Soluong = c.Soluong,
                                           Tentl = c.Tentl,
                                           Mau = c.Mau,
                                           DiaChi = x.Diachi,
                                           Masize = c.Masize,
                                           Ngaysua = c.Ngaysua,
                                           Ngaynhan = c.Ngaynhan,
                                           Nguoinhan = c.Nguoinhan,
                                           Nguoisua = c.Nguoisua,
                                           Trangthai = c.Trangthai
                                       })
                                       .Join(lts,
                                       d => d.Masize,
                                       k => k.Masize,
                                       (d, k) => new
                                       {
                                           Mactsp = d.Mactsp,
                                           Tensp = d.Tensp,
                                           Gia = d.Gia,
                                           Soluong = d.Soluong,
                                           Tentl = d.Tentl,
                                           Mau = d.Mau,
                                           DiaChi = d.DiaChi,
                                           Size = k.Size,
                                           Ngaysua = d.Ngaysua,
                                           Ngaynhan = d.Ngaynhan,
                                           Nguoinhan = d.Nguoinhan,
                                           Nguoisua = d.Nguoisua,
                                           Trangthai = d.Trangthai
                                       }).ToList();
            var ct = datajon.Where(x => x.Mactsp == Click).FirstOrDefault();
            txt_masanpham.Text = ct.Mactsp;
            txt_tensp.Text = ct.Tensp;
            txt_soluong.Text = ct.Soluong.ToString();
            txt_gia.Text = ct.Gia.ToString();
            txt_theLoai.Text = ct.Tentl;
            txt_size.Text = ct.Size;
            if (ct.Trangthai == true)
            {
                rbtn_conhang.Checked = true;
            }
            else
            {
                rbtn_hetHang.Checked = true;
            }
        }

        private void dtg_hd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0 || row >= hd_se.GetHoadons().Count)
            {
                return;
            }
            Clickhd = dtg_hd.Rows[row].Cells[0].Value.ToString();
            txt_mahoadon.Text = Clickhd.ToString();
            //txt_thanhtien.Text = hd_se.GetHoadons().FirstOrDefault(x => x.Mahd == Click).Thanhtien.ToString();
            LoadHDCT();
        }

        public void ThongTin()
        {
            //var nhanvien = nv_se.GetNhanviens(null).FirstOrDefault(x => x.Matk.Equals(infor_use));
            //if (nhanvien == null)
            //{
            //    MessageBox.Show("Không tìm thấy nhân viên.");
            //    return;
            //}

            //string manv = use_ser.GetMatk(infor_use);
            //if (string.IsNullOrEmpty(manv))
            //{
            //    MessageBox.Show("Không tìm thấy mã tài khoản.");
            //    return;
            //}

            Hoadon hd = new Hoadon();
            hd.Manv = use_ser.GetMatk(infor_use);
            DateTime time = DateTime.Now;
            hd.Ngaytao = DateOnly.FromDateTime(time);
            hd.Tragth = false;

            string result = hd_se.Them_HD(hd);
            if (result == "Thêm thành công")
            {
                var hoadons = hd_se.GetHoadons();

                string maHD = hoadons.FirstOrDefault(x => x.Manv == hd.Manv && x.Ngaytao == hd.Ngaytao).Mahd;
                if (!string.IsNullOrEmpty(maHD))
                {
                    txt_mahoadon.Text = maHD;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn sau khi thêm.");
                }
            }
            else
            {
                MessageBox.Show(result);
            }
        }
        private void btn_taoHoadon_Click(object sender, EventArgs e)
        {
            ThongTin();
            LoadHD();
        }

        public void LoadHDCT()
        {
            dtg_cthd.ColumnCount = 9;


            dtg_cthd.Columns[0].Name = "Mã chi tiết sản phẩm";
            dtg_cthd.Columns[1].Name = "Mã hóa đơn";
            dtg_cthd.Columns[2].Name = "Tên Sản phẩm";
            dtg_cthd.Columns[3].Name = "Size";
            dtg_cthd.Columns[4].Name = "Tên thể loại";
            dtg_cthd.Columns[5].Name = "Tên màu";
            dtg_cthd.Columns[6].Name = "Xuất xứ";
            dtg_cthd.Columns[7].Name = "Số lượng";
            dtg_cthd.Columns[8].Name = "Thành tiền";
            //dtg_cthd.Columns[9].Name = "Ngày nhận";
            //dtg_cthd.Columns[10].Name = "Người nhận";
            //dtg_cthd.Columns[11].Name = "Người sửa";
            //dtg_cthd.Columns[12].Name = "Trạng thái";

            dtg_cthd.Rows.Clear();

            var ltctsp = ct_se.GetChitietsanphams();
            var ltsp = ct_se.GetSanpham();
            var lttl = ct_se.GetTheloais();
            var ltm = ct_se.GetMausacs();
            var lts = ct_se.GetSizes();
            var ltxx = ct_se.GetXuatxus();
            var lthd = hd_se.GetHoadons();
            var lthdct = hd_se.GetHoadonchitiets();
            decimal? thanhtien = 0;
            var query1 = from hdtc in lthdct
                         join hd in lthd on hdtc.Mahd equals hd.Mahd
                         select new { MaHDCT = hdtc.Mahdct, MaHD = hd.Mahd, ThanhTien = hd.Thanhtien, MaSP = hdtc.Masp, Soluong = hdtc.Soluong };
            var query2 = from sp in ltsp
                         join ctsp in ltctsp on sp.Masp equals ctsp.Masp
                         join tl in lttl on ctsp.Matl equals tl.Matl
                         join xx in ltxx on ctsp.Maxx equals xx.Maxx
                         join s in lts on ctsp.Masize equals s.Masize
                         join m in ltm on ctsp.Mamau equals m.Mamau
                         select new
                         {
                             MaSP = sp.Masp,
                             Tensp = sp.Tensp,
                             Dongia = sp.Gia,
                             Trangthai = sp.Trangthai,
                             MaCTSP = ctsp.Mactsp,
                             Matl = tl.Matl,
                             Tentl = tl.Tentl,
                             Mamau = m.Mamau,
                             Tenmau = m.Tenmau,
                             Maxx = xx.Maxx,
                             Diachi = xx.Diachi,
                             MaSize = s.Masize,
                             TeSize = s.Size,
                         };
            var data = from q1 in query1
                       join q2 in query2 on q1.MaSP equals q2.MaSP
                       select new
                       {
                           MaHDCT = q1.MaHDCT,
                           MaHD = q1.MaHD,
                           ThanhTien = q1.ThanhTien,
                           MaSP = q1.MaSP,
                           Soluong = q1.Soluong,
                           Tensp = q2.Tensp,
                           Dongia = q2.Dongia,
                           Trangthai = q2.Trangthai,
                           MaCTSP = q2.MaCTSP,
                           Matl = q2.Matl,
                           Tentl = q2.Tentl,
                           Mamau = q2.Mamau,
                           Tenmau = q2.Tenmau,
                           Maxx = q2.Maxx,
                           Diachi = q2.Diachi,
                           MaSize = q2.MaSize,
                           TenSize = q2.TeSize,

                       };
            foreach (var ql in data)
            {
                dtg_cthd.Rows.Add(ql.MaCTSP, ql.MaHD, ql.Tensp, ql.TenSize, ql.Tentl, ql.Tenmau, ql.Diachi, ql.Soluong, ql.Soluong * ql.Dongia + "VND");
                thanhtien += (ql.Soluong * ql.Dongia);
            }
            txt_thanhtien.Text = thanhtien.ToString();
        }

        private void btn_themvhd_Click(object sender, EventArgs e)
        {
            var ctsp = ct_se.GetChitietsanphams().FirstOrDefault(x => x.Mactsp == Click);
            var hd = hd_se.GetHoadons().SingleOrDefault(x => x.Mahd == Clickhd);

            Hoadonchitiet hdct = new Hoadonchitiet();
            hdct.Masp = ctsp.Masp;
            hdct.Mahd = hd.Mahd;

            hd_se.Them_HDCT(hdct);
            UpdateThanhTien();
            LoadHDCT();
            LoadHD();
        }

        private void UpdateThanhTien()
        {
            var ltctsp = ct_se.GetChitietsanphams();
            var ltsp = ct_se.GetSanpham();
            var lthd = hd_se.GetHoadons().Where(x => x.Mahd == Clickhd);
            var lthdct = hd_se.GetHoadonchitiets().Where(x => x.Mahd == Clickhd);
            var query1 = from hdtc in lthdct
                         join hd in lthd on hdtc.Mahd equals hd.Mahd
                         select new { MaHDCT = hdtc.Mahdct, MaHD = hd.Mahd, ThanhTien = hd.Thanhtien, MaSP = hdtc.Masp, Soluong = hdtc.Soluong };
            var query2 = from sp in ltsp
                         join cstp in ltctsp on sp.Masp equals cstp.Masp
                         select new { MaSP = sp.Masp, MaCTSP = cstp.Mactsp, Dongia = sp.Gia };
            var datajoin = from q1 in query1
                           join q2 in query2 on q1.MaSP equals q2.MaSP
                           select new { MaHDCT = q1.MaHDCT, MaHD = q1.MaHD, ThanhTien = q1.ThanhTien, MaSP = q1.MaSP, Soluong = q1.Soluong, Dongia = q2.Dongia };
            decimal? tienHD = 0;
            foreach (var item in datajoin)
            {
                tienHD += item.Soluong * item.Dongia;
            }
            var updateHD = hd_se.GetHoadons().First(x => x.Mahd == Clickhd);
            updateHD.Thanhtien = tienHD;
            hd_se.CapNhap_HD(updateHD);
        }

        private void btn_suaHD_Click(object sender, EventArgs e)
        {
            var removeHDCT = hd_se.GetHoadonchitiets().Where(x => x.Mahd == Clickhd);
            foreach (var item in removeHDCT)
            {
                hd_se.Remove_HDCT(item);
            }
            var removerHD = hd_se.GetHoadons().FirstOrDefault(x => x.Mahd == Clickhd);

            MessageBox.Show(hd_se.Xoa_HD(removerHD));
            LoadHD();
            LoadHDCT();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //xoa
            var removeHDCT = hd_se.GetHoadonchitiets().FirstOrDefault(x => x.Mahd == ClickHDCT);
            hd_se.Remove_HDCT(removeHDCT);
            UpdateThanhTien();
            LoadHDCT();
            LoadHD();
        }

        private void dtg_cthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0 || row >= hd_se.GetHoadonchitiets().Count)
            {
                return;
            }
            ClickHDCT = dtg_cthd.Rows[row].Cells[1].Value.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void txt_tienKhachdua_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d$");
            //Tien Nhap vao ko dc la chu so
            if (Regex.IsMatch(txt_tienKhachdua.Text, "^(0|[1-9][0-9]*)$"))
            {
                txt_tienthua.Text = (decimal.Parse(txt_tienKhachdua.Text) - decimal.Parse(txt_thanhtien.Text)).ToString();
                if (decimal.Parse(txt_tienKhachdua.Text) < decimal.Parse(txt_thanhtien.Text)) //khachs chua dua du tien
                {
                    btn_thanhToan.Enabled = false;
                }
                else
                {
                    btn_thanhToan.Enabled = true;
                }
            }
            else
            {
                btn_thanhToan.Enabled = false;
                return;
            }

        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            var hdThanhToan = hd_se.GetHoadons().FirstOrDefault(x => x.Mahd == Clickhd);
            if (hdThanhToan != null)
            {
                hdThanhToan.Tragth = true; //chuyển sang trạng thái đã thanh toán
                hd_se.CapNhap_HD(hdThanhToan);
                Thanhtien = hdThanhToan.Thanhtien;
                MessageBox.Show("Thanh Toán Thành Công");
                _IDHdDaThanhToan = Clickhd;
                LoadHD();
                Clickhd = "0"; // Hoặc giá trị phù hợp để chỉ rằng không có hóa đơn nào đang được chọn
                LoadHDCT();
                txt_mahoadon.Text = "";
                txt_thanhtien.Text = "";
                txt_tienKhachdua.Text = "";
                txt_tienthua.Text = "";
                btn_xuathoadon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn để thanh toán.");
            }
        }

        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_IDHdDaThanhToan))
            {
                MessageBox.Show("Bạn chưa thanh toán hóa đơn nào");
                return;
            }
            // ID Hóa đơn, IDCTSP, ID SP, ID Hang, ID TheTich, soluong, Giá
            var ltctsp = ct_se.GetChitietsanphams();
            var ltsp = ct_se.GetSanpham();
            var lttl = ct_se.GetTheloais();
            var ltm = ct_se.GetMausacs();
            var lts = ct_se.GetSizes();
            var ltxx = ct_se.GetXuatxus();
            var lthd = hd_se.GetHoadons();
            var lthdct = hd_se.GetHoadonchitiets();
            decimal? thanhtien = 0;
            var query1 = from hdtc in lthdct
                         join hd in lthd on hdtc.Mahd equals hd.Mahd
                         select new { MaHDCT = hdtc.Mahdct, MaHD = hd.Mahd, ThanhTien = hd.Thanhtien, MaSP = hdtc.Masp, Soluong = hdtc.Soluong };
            var query2 = from sp in ltsp
                         join ctsp in ltctsp on sp.Masp equals ctsp.Masp
                         join tl in lttl on ctsp.Matl equals tl.Matl
                         join xx in ltxx on ctsp.Maxx equals xx.Maxx
                         join s in lts on ctsp.Masize equals s.Masize
                         join m in ltm on ctsp.Mamau equals m.Mamau
                         select new
                         {
                             MaSP = sp.Masp,
                             Tensp = sp.Tensp,
                             Dongia = sp.Gia,
                             Trangthai = sp.Trangthai,
                             MaCTSP = ctsp.Mactsp,
                             Matl = tl.Matl,
                             Tentl = tl.Tentl,
                             Mamau = m.Mamau,
                             Tenmau = m.Tenmau,
                             Maxx = xx.Maxx,
                             Diachi = xx.Diachi,
                             MaSize = s.Masize,
                             TeSize = s.Size,
                         };
            var data = from q1 in query1
                       join q2 in query2 on q1.MaSP equals q2.MaSP
                       select new
                       {
                           MaHDCT = q1.MaHDCT,
                           MaHD = q1.MaHD,
                           ThanhTien = q1.ThanhTien,
                           MaSP = q1.MaSP,
                           Soluong = q1.Soluong,
                           Tensp = q2.Tensp,
                           Dongia = q2.Dongia,
                           Trangthai = q2.Trangthai,
                           MaCTSP = q2.MaCTSP,
                           Matl = q2.Matl,
                           Tentl = q2.Tentl,
                           Mamau = q2.Mamau,
                           Tenmau = q2.Tenmau,
                           Maxx = q2.Maxx,
                           Diachi = q2.Diachi,
                           MaSize = q2.MaSize,
                           TenSize = q2.TeSize,

                       };
            //using (StringWriter sw = new StringWriter())
            //{
            //    using (HtmlTextWriter writer = new HtmlTextWriter(sw))
            //    {
            //        StringBuilder sb = new StringBuilder();
            //        sb.Append("<div class=\"card\">");      
            //        sb.Append("<div class=\"card-body mx-4\">");
            //        sb.Append("<div class=\"container\">");
            //        sb.Append("<p class=\"my-5 mx-5\" style=\"font-size: 30px;\">Thank for your purchase</p>");
            //        sb.Append("<div class=\"row\">");
            //        sb.Append("<ul class=\"list-unstyled\">");
            //        sb.Append("<li class=\"text-black\">");
            //        sb.Append(info_user);
            //        sb.Append("</li>");
            //        sb.Append("<li class=\"text-muted mt-1\"><span class=\"text-black\">Invoice</span>");
            //        sb.Append(_IDHdDaThanhToan);
            //        sb.Append("</li>");
            //        sb.Append("<li class=\"text-black mt-1\">");
            //        sb.Append(DateTime.Now); //điền biến của hóa đơn đã lưu vào
            //        sb.Append("</li>");
            //        sb.Append("</ul>");
                    //foreach (var item in data)
                    //{
                    //    sb.Append("<hr>");
                    //    sb.Append("<div class=\"col-xl-10\">");
                    //    sb.Append("<p>");
                    //    sb.Append(item.Tensp);
                    //    sb.Append(item.Tentl);
                    //    sb.Append(item.TenSize);
                    //    sb.Append(" ml");
                    //    sb.Append("     x");
                    //    sb.Append(item.Soluong);
                    //    sb.Append("</p>");
                    //    sb.Append("</div>");
                    //    sb.Append("<div class=\"col-xl-2\">");
                    //    sb.Append("<p class=\"float-end\">{{data.gia}}");
                    //    sb.Append(item.Dongia * item.Soluong);
                    //    sb.Append("</p>");
                    //    sb.Append("</div>");
                    //    sb.Append("<hr>");
                    //}

                    //sb.Append("</div>");
                    //sb.Append("<hr style=\"border: 2px solid black;\">");
                    //sb.Append("</div>");
                    //sb.Append("<div class=\"row text-black\">");
                    //sb.Append("<div class=\"col-xl-12\">");
                    //sb.Append("<p class=\"float-end fw-bold\">Total: ");
                    //sb.Append(thanhtien);
                    //sb.Append("</p>");
                    //sb.Append("</div>");
                    //sb.Append("<hr style=\"border: 2px solid black;\">");
                    //sb.Append("</div>");
                    //sb.Append("<div class=\"text-center\" style=\"margin-top: 90px;\">");
                    //sb.Append("<a><u class=\"text-info\">View in browser</u></a>");
                    //sb.Append("<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. </p>");
                    //sb.Append("</div>");
                    //sb.Append("</div>");
                    //sb.Append("</div>");
                    //sb.Append("</div>");

                    //Export HTML String as PDF.
                    //StringReader sr = new StringReader(sb.ToString());
                    //Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    //HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    //PdfWriter pdfwriter = PdfWriter.GetInstance(pdfDoc, HttpResponse.FromValue);
                    //pdfDoc.Open();
                    //htmlparser.Parse(sr);
                    //pdfDoc.Close();
                    //Response.ContentType = "application/pdf";
                    //Response.AddHeader("content-disposition", "attachment;filename=Invoice_" + orderNo + ".pdf");
                    //Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    //Response.Write(pdfDoc);
                    //Response.End();
            //    }
            //}
        }
    }
}

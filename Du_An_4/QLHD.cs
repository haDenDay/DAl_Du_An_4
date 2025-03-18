using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_An_4
{
    public partial class QLHD : Form
    {
        Hoadon_Service hd_se = new Hoadon_Service();
        NhanVien_Service nv_se = new NhanVien_Service();
        CTSP_Service ctsp_se = new CTSP_Service();
        KH_KM_Service kk_se = new KH_KM_Service();
        private bool? tthd = true;
        private bool? tthdct = true;
        private string Click;

        public QLHD()
        {
            InitializeComponent();
        }
        public void LoadHD()
        {
            dtg_hd.ColumnCount = 9;

            dtg_hd.Columns[0].Name = "Mã hóa đơn";
            dtg_hd.Columns[1].Name = "Tên nhận viên";
            dtg_hd.Columns[2].Name = "Xuất xứ";
            dtg_hd.Columns[3].Name = "Thành tiền";
            dtg_hd.Columns[4].Name = "Ngày sửa";
            dtg_hd.Columns[5].Name = "Ngày tạo";
            dtg_hd.Columns[6].Name = "Người sửa";
            dtg_hd.Columns[7].Name = "Người tạo";
            dtg_hd.Columns[8].Name = "Trạng thái";

            dtg_hd.Rows.Clear();

            var lthd = hd_se.GetHoadons();
            var ltnv = nv_se.GetNhanviens(txt_tim.Text);

            var datahd = lthd.Join(ltnv,
                                  hd => hd.Manv,
                                  nv => nv.Manv,
                                  (hd, nv) => new
                                  {
                                      Mahd = hd.Mahd,
                                      Tennv = nv.Tennv,
                                      Xuatxu = hd.Xuatxu,
                                      Thanhtien = hd.Thanhtien,
                                      Ngaysua = hd.Ngaysua,
                                      Ngaytao = hd.Ngaytao,
                                      Nguoisua = hd.Nguoisua,
                                      Nguoitao = hd.Nguoitao,
                                      Trangthai = hd.Tragth
                                  }).ToList();
            foreach (var item in datahd.Where(x => x.Trangthai == tthd))
            {
                dtg_hd.Rows.Add(item.Mahd, item.Tennv, item.Xuatxu, item.Thanhtien == null ? 0 + " " + "VND" : item.Thanhtien + " " + "VND", item.Ngaysua, item.Ngaytao, item.Nguoisua, item.Nguoitao, item.Trangthai);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_trangthai.SelectedIndex == 0)
            {
                tthd = true;
                tthdct = true;
            }
            else if (cmb_trangthai.SelectedIndex == 1)
            {
                tthd = false;
                tthdct = false;
            }
            LoadHD();
            LoadHDCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadHD();
            LoadHDCT();
        }

        public void LoadHDCT()
        {
            dtg_hdct.ColumnCount = 13;

            dtg_hdct.Columns[0].Name = "Mã hóa đơn chi tiết";
            dtg_hdct.Columns[1].Name = "Mã hóa đơn";
            dtg_hdct.Columns[2].Name = "Tên sản phẩm";
            dtg_hdct.Columns[3].Name = "Tên khách hàng";
            dtg_hdct.Columns[4].Name = "Khuyến mại";
            dtg_hdct.Columns[5].Name = "Số lượng";
            dtg_hdct.Columns[6].Name = "Phương thức thanh toán";
            dtg_hdct.Columns[7].Name = "Xuất xứ";
            dtg_hdct.Columns[8].Name = "Ngày tạo";
            dtg_hdct.Columns[9].Name = "Ngày sửa";
            dtg_hdct.Columns[10].Name = "Người sửa";
            dtg_hdct.Columns[11].Name = "Người tạo";
            dtg_hdct.Columns[12].Name = "Trạng thái";

            dtg_hdct.Rows.Clear();

            var lshd = hd_se.GetHoadons();
            var lsdtct = hd_se.GetHoadonchitiets();
            var lssp = ctsp_se.GetSanpham();
            var lskm = kk_se.GetKhuyenmais();
            var lskh = kk_se.GetKhachhangs();

            var joinhdct = lsdtct.Join(lshd,
                                       hdct => hdct.Mahd,
                                       hd => hd.Mahd,
                                       (hdct, hd) => new
                                       {
                                           Mahdct = hdct.Mahdct,
                                           Mahd = hd.Mahd,
                                           Masp = hdct.Masp,
                                           Makm = hdct.Makm,
                                           MaKh = hdct.Makh,
                                           Soluong = hdct.Soluong,
                                           Pttt = hdct.Pttt,
                                           Xuaxu = hdct.Xuatxuhoadon,
                                           Ngaytao = hdct.Ngaytao,
                                           Ngaysua = hdct.Ngaysua,
                                           Nguoisua = hdct.Nguoisua,
                                           Nguoitao = hdct.Nguoitao,
                                           Trangthai = hdct.Trthai
                                       })
                                        .Join(lssp,
                                              hdct => hdct.Masp,
                                              sp => sp.Masp,
                                              (hdct, sp) => new
                                              {
                                                  Mahdct = hdct.Mahdct,
                                                  Mahd = hdct.Mahd,
                                                  Tensp = sp.Tensp,
                                                  Makm = hdct.Makm,
                                                  MaKh = hdct.MaKh,
                                                  Soluong = hdct.Soluong,
                                                  Pttt = hdct.Pttt,
                                                  Xuaxu = hdct.Xuaxu,
                                                  Ngaytao = hdct.Ngaytao,
                                                  Ngaysua = hdct.Ngaysua,
                                                  Nguoisua = hdct.Nguoisua,
                                                  Nguoitao = hdct.Nguoitao,
                                                  Trangthai = hdct.Trangthai,
                                              })
                                        .Join(lskh,
                                              hdct => hdct.MaKh,
                                              kh => kh.Makh,
                                              (hdct, kh) => new
                                              {
                                                  Mahdct = hdct.Mahdct,
                                                  Mahd = hdct.Mahd,
                                                  Tensp = hdct.Tensp,
                                                  Makm = hdct.Makm,
                                                  TenKh = kh.Tenkh,
                                                  Soluong = hdct.Soluong,
                                                  Pttt = hdct.Pttt,
                                                  Xuaxu = hdct.Xuaxu,
                                                  Ngaytao = hdct.Ngaytao,
                                                  Ngaysua = hdct.Ngaysua,
                                                  Nguoisua = hdct.Nguoisua,
                                                  Nguoitao = hdct.Nguoitao,
                                                  Trangthai = hdct.Trangthai,
                                              })
                                        .Join(lskm,
                                              hdct => hdct.Makm,
                                              km => km.Makm,
                                              (hdct, km) => new
                                              {
                                                  Mahdct = hdct.Mahdct,
                                                  Mahd = hdct.Mahd,
                                                  Tensp = hdct.Tensp,
                                                  Tenkm = km.Tenkm,
                                                  TenKh = hdct.TenKh,
                                                  Soluong = hdct.Soluong,
                                                  Pttt = hdct.Pttt,
                                                  Xuaxu = hdct.Xuaxu,
                                                  Ngaytao = hdct.Ngaytao,
                                                  Ngaysua = hdct.Ngaysua,
                                                  Nguoisua = hdct.Nguoisua,
                                                  Nguoitao = hdct.Nguoitao,
                                                  Trangthai = hdct.Trangthai,
                                              }).ToList();

            foreach (var hdct in joinhdct.Where(x => x.Trangthai == tthdct))
            {
                dtg_hdct.Rows.Add(hdct.Mahdct, hdct.Mahd, hdct.Tensp, hdct.TenKh, hdct.Tenkm, hdct.Soluong, hdct.Pttt,
                                  hdct.Xuaxu, hdct.Ngaytao, hdct.Ngaysua, hdct.Nguoisua, hdct.Nguoitao, hdct.Trangthai == true ? "Còn hạn" : "Hết hạn");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Hoadon hd = new Hoadon();
            hd.Mahd = txt_mahd.Text;
            hd.Manv = txt_manv.Text;
            hd.Xuatxu = txt_xx.Text;
            hd.Thanhtien = Decimal.Parse(txt_thanhtien.Text);
            hd.Ngaysua = DateOnly.Parse(txt_ngaysua.Text);
            hd.Ngaysua = DateOnly.Parse(txt_ngaytao.Text);
            hd.Nguoisua = txt_nguoisua.Text;
            hd.Nguoitao = txt_nguoitao.Text;
            if (rbtn_conhan.Checked == true)
            {
                hd.Tragth = true;
            }
            else
            {
                hd.Tragth = false;
            }

            MessageBox.Show(hd_se.Them_HD(hd));
            LoadHD();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var hd = hd_se.GetHoadons().Where(x => x.Mahd == Click).FirstOrDefault();
            hd.Mahd = txt_mahd.Text;
            hd.Manv = txt_manv.Text;
            hd.Xuatxu = txt_xx.Text;
            hd.Thanhtien = Decimal.Parse(txt_thanhtien.Text);
            hd.Ngaysua = DateOnly.Parse(txt_ngaysua.Text);
            hd.Ngaysua = DateOnly.Parse(txt_ngaytao.Text);
            hd.Nguoisua = txt_nguoisua.Text;
            hd.Nguoitao = txt_nguoitao.Text;
            if (rbtn_conhan.Checked == true)
            {
                hd.Tragth = true;
            }
            else
            {
                hd.Tragth = false;
            }

            MessageBox.Show(hd_se.CapNhap_HD(hd));
            LoadHD();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            LoadHD();
        }
    }
}

using DAl_Du_An_4.Context;
using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Service;
using Microsoft.EntityFrameworkCore;
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
    public partial class QLTK : Form
    {
        Use_Service use_se = new Use_Service();
        private bool? tttk = true;
        private string click;
        public QLTK()
        {
            InitializeComponent();
        }

        public void LoadTK(string seacher)
        {
            dtg_tkhoan.ColumnCount = 9;

            dtg_tkhoan.Columns[0].Name = "Mã tài khoản";
            dtg_tkhoan.Columns[1].Name = "Tên tài khoản";
            dtg_tkhoan.Columns[2].Name = "Mật khẩu";
            dtg_tkhoan.Columns[3].Name = "Ngày sửa";
            dtg_tkhoan.Columns[4].Name = "Ngày nhận";
            dtg_tkhoan.Columns[5].Name = "Người sửa";
            dtg_tkhoan.Columns[6].Name = "Người nhận";
            dtg_tkhoan.Columns[7].Name = "Phân loại";
            dtg_tkhoan.Columns[8].Name = "Trạng thái";

            dtg_tkhoan.Rows.Clear();

            foreach (var tk in use_se.GetTaikhoans(seacher).Where(x => x.Trangthai == tttk))
            {
                dtg_tkhoan.Rows.Add(tk.Matk, tk.Tentk, tk.Matkhau, tk.Ngaysua, tk.Ngaytao, tk.Nguoisua, tk.Nguoitao, tk.Phanloaitk, tk.Trangthai == true ? "Hoạt động" : "Ngừng hoạt động");
            }
        }
        MyContext dbcontext= new MyContext();
        private void btn_themTK_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn thêm chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_matk.Text) || string.IsNullOrWhiteSpace(txt_tentk.Text) || string.IsNullOrWhiteSpace(txt_mk.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var checkTrung = dbcontext.Taikhoans.FirstOrDefault(t => t.Tentk == txt_tentk.Text || t.Matk == txt_matk.Text);
                if (checkTrung != null)
                {
                    MessageBox.Show("Tên tài khoản hoặc mã tài khoản đã tồn tại. Vui lòng chọn tên tài khoản mã tài khoản khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Taikhoan tk = new Taikhoan();
                tk.Matk = txt_matk.Text;
                tk.Tentk = txt_tentk.Text;
                tk.Matkhau = txt_mk.Text;
                tk.Ngaysua = DateOnly.Parse(txt_ngaySua.Text);
                tk.Ngaytao = DateOnly.Parse(txt_ngayNhan.Text);
                tk.Nguoisua = txt_nguoiSua.Text;
                tk.Nguoitao = txt_nguoiNhan.Text;
                if (cmb_PhanLoai.SelectedIndex == 0)
                {
                    tk.Phanloaitk = "Nhân viên";
                }
                else if (cmb_PhanLoai.SelectedIndex == 1)
                {
                    tk.Phanloaitk = "Admin";
                }
                else
                {
                    tk.Phanloaitk = "Khách hàng";
                }
                if (rbtn_hoatDong.Checked == true)
                {
                    tk.Trangthai = true;
                }
                else
                {
                    tk.Trangthai = false;
                }
                MessageBox.Show(use_se.Them_TK(tk));
                LoadTK(txt_tim.Text);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn sửa chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(txt_matk.Text) || string.IsNullOrWhiteSpace(txt_tentk.Text) || string.IsNullOrWhiteSpace(txt_mk.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dangsua = dbcontext.Taikhoans.FirstOrDefault(p => p.Matk == txt_matk.Text);
                if (dangsua == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại, không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var tk = use_se.GetTaikhoans(txt_tim.Text).Where(x => x.Matk == click).FirstOrDefault();
                tk.Matk = txt_matk.Text;
                tk.Tentk = txt_tentk.Text;
                tk.Matkhau = txt_mk.Text;
                tk.Ngaysua = DateOnly.Parse(txt_ngaySua.Text);
                tk.Ngaytao = DateOnly.Parse(txt_ngayNhan.Text);
                tk.Nguoisua = txt_nguoiSua.Text;
                tk.Nguoitao = txt_nguoiNhan.Text;
                if (cmb_PhanLoai.SelectedIndex == 0)
                {
                    tk.Phanloaitk = "Nhân viên";
                }
                else if (cmb_PhanLoai.SelectedIndex == 1)
                {
                    tk.Phanloaitk = "Admin";
                }
                else
                {
                    tk.Phanloaitk = "Khách hàng";
                }
                if (rbtn_hoatDong.Checked == true)
                {
                    tk.Trangthai = true;
                }
                else
                {
                    tk.Trangthai = false;
                }

                MessageBox.Show(use_se.CapNhat_TK(tk));
                LoadTK(txt_tim.Text);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            LoadTK(txt_tim.Text);
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadTK(null);
        }

        private void cmb_theoTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_theoTrangThai.SelectedIndex == 0)
            {
                tttk = true;
            }
            else if (cmb_theoTrangThai.SelectedIndex == 1)
            {
                tttk = false;
            }
            LoadTK(txt_tim.Text);
        }

        private void dtg_tkhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0 || row >= use_se.GetTaikhoans(txt_tim.Text).Count)
            {
                return;
            }
            click = dtg_tkhoan.Rows[row].Cells[0].Value.ToString();
            bindata();
        }

        private void bindata()
        {
            var nhay = use_se.GetTaikhoans(txt_tim.Text).Find(x => x.Matk == click);
            txt_matk.Text = nhay.Matk;
            txt_tentk.Text = nhay.Tentk;
            txt_mk.Text = nhay.Matkhau;
            if (nhay.Trangthai == true)
            {
                rbtn_hoatDong.Checked = true;
            }
            else
            {
                rbtn_ngungHD.Checked = true;
            }
            txt_ngaySua.Text = nhay.Ngaysua.ToString();
            txt_ngayNhan.Text = nhay.Ngaytao.ToString();
            txt_nguoiSua.Text = nhay.Nguoisua;
            txt_nguoiNhan.Text = nhay.Nguoitao;
            if (nhay.Phanloaitk == "Nhân viên")
            {
                cmb_PhanLoai.SelectedIndex = 0;
            }
            else if (nhay.Phanloaitk == "admin" || nhay.Phanloaitk == "Admin")
            {
                cmb_PhanLoai.SelectedIndex = 1;
            }
            else
            {
                cmb_PhanLoai.SelectedIndex = 2;
            }
        }

        private void QLTK_Load(object sender, EventArgs e)
        {

        }
    }
}

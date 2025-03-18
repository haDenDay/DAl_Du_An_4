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
    public partial class QLNV : Form
    {
        NhanVien_Service nv_se = new NhanVien_Service();
        private string Click;
        private Dictionary<string, string> productImageMap = new Dictionary<string, string>();
        private bool? ttnv = true;
        public QLNV()
        {
            InitializeComponent();
        }
        public void LoadData(string seacher)
        {
            dtg_nv.ColumnCount = 15;

            dtg_nv.Columns[0].Name = "Mã nhân viên";
            dtg_nv.Columns[1].Name = "Mã tài khoản";
            dtg_nv.Columns[2].Name = "Tên nhân viên";
            dtg_nv.Columns[3].Name = "Giới tính";
            dtg_nv.Columns[4].Name = "Địa chỉ";
            dtg_nv.Columns[5].Name = "Quốc tịch";
            dtg_nv.Columns[6].Name = "Nơi thường chú";
            dtg_nv.Columns[7].Name = "Số CCCD";
            dtg_nv.Columns[8].Name = "Chức vụ";
            dtg_nv.Columns[9].Name = "Ngày sửa";
            dtg_nv.Columns[10].Name = "Ngày nhận";
            dtg_nv.Columns[11].Name = "Người nhận";
            dtg_nv.Columns[12].Name = "Người sửa";
            dtg_nv.Columns[13].Name = "Trạng thái";
            dtg_nv.Columns[14].Name = "Ngày sinh ";

            dtg_nv.Rows.Clear();

            foreach (var nv in nv_se.GetNhanviens(seacher).Where(x => x.Trngthai == ttnv))
            {
                dtg_nv.Rows.Add(nv.Manv, nv.Matk, nv.Tennv, nv.Gioitinh, nv.Diachi, nv.Quoctich,
                                nv.Noithuongchu, nv.Socccd, nv.Chucvu, nv.Ngaysua,
                                nv.Ngaynhan, nv.Nguoinhan, nv.Nguoisua, nv.Trngthai == true ? "Hoạt động" : "Nghỉ", nv.Ngaysinh);
            }
        }
        MyContext dbcontext = new MyContext();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn thêm chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_cccd.Text) || string.IsNullOrWhiteSpace(txt_maNV.Text) || string.IsNullOrWhiteSpace(txt_QuocTich.Text) ||  string.IsNullOrWhiteSpace(txt_Chucvu.Text) || string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var checkTrung = dbcontext.Nhanviens.FirstOrDefault(p => p.Manv == txt_maNV.Text || p.Socccd == txt_cccd.Text);
                if (checkTrung != null)
                {
                    MessageBox.Show("Thông tin về mã nhân viên và CCCD có thể bị trùng ,  Không thể thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Nhanvien nv = new Nhanvien();
                nv.Manv = txt_maNV.Text;
                nv.Ngaysinh = DateOnly.Parse(txt_Ngaysinh.Text);
                nv.Tennv = txt_Ten.Text;
                if (rbtn_nam.Checked == true)
                {
                    nv.Gioitinh = "Nam";
                }
                else
                {
                    nv.Gioitinh = "Nữ";
                }
                if (nv.Gioitinh == "Nam")
                {
                    rbtn_nam.Checked = true;
                }
                else
                {
                    rbtn_nu.Checked = true;
                }
                nv.Diachi = txt_Diachi.Text;
                nv.Quoctich = txt_QuocTich.Text;
                nv.Noithuongchu = rbtn_noiThuongchu.Text;
                nv.Socccd = txt_cccd.Text;
                nv.Chucvu = txt_Chucvu.Text;
                nv.Ngaysua = DateOnly.Parse(txt_NgaySua.Text);
                nv.Ngaynhan = DateOnly.Parse(txt_ngayNhan.Text);
                nv.Nguoinhan = txt_Nguoinhan.Text;
                nv.Nguoisua = txt_NguoiSua.Text;
                nv.Matk = txt_MaTK.Text;
                if (rbtn_hoatdong.Checked == true)
                {
                    nv.Trngthai = true;
                }
                else
                {
                    nv.Trngthai = false;
                }

                MessageBox.Show(nv_se.ThemNV(nv));
                LoadData(txt_tim.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn sửa chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_cccd.Text) || string.IsNullOrWhiteSpace(txt_maNV.Text) || string.IsNullOrWhiteSpace(txt_QuocTich.Text) || string.IsNullOrWhiteSpace(txt_Chucvu.Text) || string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết của nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var dangsua = dbcontext.Nhanviens.FirstOrDefault(p => p.Manv == txt_maNV.Text);
                if (dangsua == null)
                {
                    MessageBox.Show("Mã không tồn tại, không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var data = nv_se.GetNhanviens(txt_tim.Text).Where(x => x.Manv == Click).FirstOrDefault();
                data.Manv = txt_maNV.Text;
                data.Matk = txt_MaTK.Text;
                data.Ngaysinh = DateOnly.Parse(txt_Ngaysinh.Text);
                data.Tennv = txt_Ten.Text;
                if (rbtn_nam.Checked == true)
                {
                    data.Gioitinh = "Nam";
                }
                else
                {
                    data.Gioitinh = "Nữ";
                }
                data.Diachi = txt_Diachi.Text;
                data.Quoctich = txt_QuocTich.Text;
                data.Noithuongchu = rbtn_noiThuongchu.Text;
                data.Socccd = txt_cccd.Text;
                data.Chucvu = txt_Chucvu.Text;
                data.Ngaysua = DateOnly.Parse(txt_NgaySua.Text);
                data.Ngaynhan = DateOnly.Parse(txt_ngayNhan.Text);
                data.Nguoinhan = txt_Nguoinhan.Text;
                data.Nguoisua = txt_NguoiSua.Text;
                if (rbtn_hoatdong.Checked == true)
                {
                    data.Trngthai = true;
                }
                else
                {
                    data.Trngthai = false;
                }

                MessageBox.Show(nv_se.CapNhapNV(data));
                LoadData(txt_tim.Text);
            }
        }
        public void InitializeProductImageMap()
        {
            productImageMap.Add("NV001", "C:\\Users\\ADMIN\\OneDrive\\Máy tính\\Học tập\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Dự Án Bán Áo Nam\\Du_An_Lam_Lai\\img\\Admin.jpg");
        }

        private void dtg_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0 || row >= nv_se.GetNhanviens(txt_tim.Text).Count)
            {
                return;
            }
            Click = dtg_nv.Rows[row].Cells[0].Value.ToString();
            bindata();
            if (e.RowIndex >= 0 || e.RowIndex == dtg_nv.Columns[0].Index)
            {
                string productCode = dtg_nv.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (productImageMap.ContainsKey(productCode))
                {
                    pcb_nhanvien.ImageLocation = productImageMap[productCode];
                    pcb_nhanvien.Image = Image.FromFile(pcb_nhanvien.ImageLocation);
                }
                else
                {
                    pcb_nhanvien.ImageLocation = "path/to/default-AoSomiTrang.jpg";
                }
            }
        }

        private void bindata()
        {
            var data = nv_se.GetNhanviens(txt_tim.Text).Find(x => x.Manv == Click);
            txt_maNV.Text = data.Manv;
            txt_MaTK.Text = data.Matk;
            txt_Ten.Text = data.Tennv;
            if (data.Gioitinh == "Nam")
            {
                rbtn_nam.Checked = true;
            }
            else
            {
                rbtn_nu.Checked = true;
            }
            txt_Diachi.Text = data.Diachi;
            txt_QuocTich.Text = data.Quoctich;
            rbtn_noiThuongchu.Text = data.Noithuongchu;
            txt_cccd.Text = data.Socccd;
            txt_Chucvu.Text = data.Chucvu;
            txt_NgaySua.Text = data.Ngaysua.ToString();
            txt_ngayNhan.Text = data.Ngaynhan.ToString();
            txt_Nguoinhan.Text = data.Nguoinhan;
            txt_NguoiSua.Text = data.Nguoisua;
            txt_Ngaysinh.Text = data.Ngaysinh.ToString();
            if (data.Trngthai == true)
            {
                rbtn_hoatdong.Checked = true;
            }
            else
            {
                rbtn_nghi.Checked = true;
            }
        }

        private void cmb_trangthaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_trangthaiNV.SelectedIndex == 0)
            {
                ttnv = true;
            }
            else if (cmb_trangthaiNV.SelectedIndex == 1)
            {
                ttnv = false;
            }
            LoadData(txt_tim.Text);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData(txt_tim.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void QLNV_Load(object sender, EventArgs e)
        {

        }
    }
}

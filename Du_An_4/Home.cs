using DAl_Du_An_4.Context;
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
    public partial class Home : Form
    {
        Use_Service ue_se = new Use_Service();
        public string taikhoan;
        public Home()
        {
            InitializeComponent();

        }

        MyContext dbcontext = new MyContext();
        public List<Taikhoan> getAdmin(string pltk)// hàm lấy thông tin tài khoản trong db
        {
            var ListTaiKhoan = dbcontext.Taikhoans.Where(p => p.Phanloaitk.Equals(pltk)).ToList();

            return ListTaiKhoan;
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            QLSP sp = new QLSP() { TopLevel = false, TopMost = true };
            sp.FormBorderStyle = FormBorderStyle.None; // không hiện viền
            if (p_home.Controls.Count > 0)
            {
                p_home.Controls.RemoveAt(0);
            }
            p_home.Controls.Add(sp);
            sp.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Home home = new Home();
            home.Close();
            this.Hide();
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            var tkList = getAdmin(taikhoan);

            bool isValidUser = false;

            foreach (var account in tkList)
            {
                if (account.Phanloaitk == "Admin")
                {
                    isValidUser = true;
                    break;
                }
            }

            if (isValidUser == true)
            {
                QLNV qlnv = new QLNV() { TopLevel = false, TopMost = true };
                qlnv.FormBorderStyle = FormBorderStyle.None;
                if (p_home.Controls.Count > 0)
                {
                    p_home.Controls.RemoveAt(0);
                }
                p_home.Controls.Add((qlnv));
                qlnv.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tkList = getAdmin(taikhoan);

            bool isValidUser = false;

            foreach (var account in tkList)
            {
                if (account.Phanloaitk == "Admin")
                {
                    isValidUser = true;
                    break;
                }
            }

            if (isValidUser == true)
            {
                QLTK qltk = new QLTK() { TopLevel = false, TopMost = true };
                qltk.FormBorderStyle = FormBorderStyle.None;
                if (p_home.Controls.Count > 0)
                {
                    p_home.Controls.RemoveAt(0);
                }
                p_home.Controls.Add(qltk);
                qltk.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLHD hd = new QLHD() { TopLevel = false, TopMost = true };
            hd.FormBorderStyle = FormBorderStyle.None;
            if (p_home.Controls.Count > 0)
            {
                p_home.Controls.RemoveAt(0);
            }
            p_home.Controls.Add(hd);
            hd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BANHANG banhang = new BANHANG(taikhoan) { TopLevel = false, TopMost = true };
            banhang.FormBorderStyle = FormBorderStyle.None;
            if (p_home.Controls.Count > 0)
            {
                p_home.Controls.RemoveAt(0);
            }
            p_home.Controls.Add(banhang);
            banhang.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lbl_name.Text = "Xin chào" + " " + taikhoan;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

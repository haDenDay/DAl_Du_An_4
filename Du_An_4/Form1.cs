using DAl_Du_An_4.Context;
using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Service;
using System.Windows.Forms;

namespace Du_An_4
{
    public partial class Form1 : Form
    {
        MyContext dbcontext = new MyContext();
        Use_Service u_Se = new Use_Service();
        private bool passwordVisible = false;
        public Form1()
        {
            InitializeComponent();
        }

        public List<Taikhoan> getTaiKhoans(string tentk, string matkhau)// hàm lấy thông tin tài khoản trong db
        {
            var ListTaiKhoan = dbcontext.Taikhoans.Where(p => p.Tentk.Equals(tentk) && p.Matkhau.Equals(matkhau)).ToList();

            return ListTaiKhoan;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var tkList = getTaiKhoans(txt_Use.Text, txt_Pass.Text);

            bool isValidUser = false;
            foreach (var account in tkList)
            {
                if (account.Tentk.Equals(txt_Use.Text) && account.Matkhau.Equals(txt_Pass.Text))
                {
                    if (account.Trangthai.Value)
                    {
                        isValidUser = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khóa.");
                        return;
                    }
                }
            }

            if (isValidUser)
            {
                Home home = new Home();
                home.taikhoan = txt_Use.Text;
                this.Hide();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                txt_Pass.PasswordChar = '*';
                button1.Text = "Hiện mật khẩu";
            }
            else
            {
                txt_Pass.PasswordChar = '\0';
                button1.Text = "Ẩn mật khẩu";
            }
            passwordVisible = !passwordVisible;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

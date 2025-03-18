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
    public partial class QLSP : Form
    {
        CTSP_Service ct_se = new CTSP_Service();
        private string Click;
        private string chon;
        private string nhay;
        private string dup;
        private Dictionary<string, string> productImageMap = new Dictionary<string, string>();
        private bool? tt = true;
        private bool? ttsp = true;
        private bool? ttms = true;
        private bool? ttxx = true;
        private bool? tttl = true;
        private bool? tts = true;
        List<Sanpham> lssp = new List<Sanpham>();
        List<Mausac> lsms = new List<Mausac>();
        List<Xuatxu> lsxx = new List<Xuatxu>();
        List<Theloai> lstl = new List<Theloai>();
        List<Sizeaonam> lts = new List<Sizeaonam>();
        List<Chitietsanpham> lctsp = new List<Chitietsanpham>();
        public QLSP()
        {
            InitializeComponent();
            InitializeProductImageMap();
        }

        public void LoadCTSP()
        {
            dtg_ctsp.ColumnCount = 11;

            dtg_ctsp.Columns[0].Name = "Mã chi tiết sản phẩm";
            dtg_ctsp.Columns[1].Name = "Tên Sản phẩm";
            dtg_ctsp.Columns[2].Name = "Tên thể loại";
            dtg_ctsp.Columns[3].Name = "Tên màu";
            dtg_ctsp.Columns[4].Name = "Xuất xứ";
            dtg_ctsp.Columns[5].Name = "Size";
            dtg_ctsp.Columns[6].Name = "Ngày sửa";
            dtg_ctsp.Columns[7].Name = "Ngày nhận";
            dtg_ctsp.Columns[8].Name = "Người nhận";
            dtg_ctsp.Columns[9].Name = "Người sửa";
            dtg_ctsp.Columns[10].Name = "Trạng thái";

            dtg_ctsp.Rows.Clear();


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

            foreach (var item in datajon.Where(x => x.Trangthai == tt).ToList())
            {
                dtg_ctsp.Rows.Add(item.Mactsp, item.Tensp, item.Tentl, item.Mau, item.DiaChi, item.Size,
                                item.Ngaysua, item.Ngaynhan, item.Nguoinhan, item.Nguoisua, item.Trangthai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadCTSP();
        }

        public void LoadSP()
        {
            dtg_sanpham.ColumnCount = 10;

            dtg_sanpham.Columns[0].Name = "Mã sản phẩm";
            dtg_sanpham.Columns[1].Name = "Tên sản phẩm";
            dtg_sanpham.Columns[2].Name = "Số lượng";
            dtg_sanpham.Columns[3].Name = "Giá";
            dtg_sanpham.Columns[4].Name = "Mô tả";
            dtg_sanpham.Columns[5].Name = "Ngày sửa";
            dtg_sanpham.Columns[6].Name = "Ngày nhận";
            dtg_sanpham.Columns[7].Name = "Người nhận";
            dtg_sanpham.Columns[8].Name = "Người sửa";
            dtg_sanpham.Columns[9].Name = "Trạng thái";

            dtg_sanpham.Rows.Clear();

            foreach (var sp in ct_se.GetSanpham().Where(x => x.Trangthai == ttsp))
            {
                dtg_sanpham.Rows.Add(sp.Masp, sp.Tensp, sp.Soluong, sp.Gia, sp.Mota, sp.Ngaysua, sp.Ngaynhan,
                                     sp.Nguoinhan, sp.Nguoisua, sp.Trangthai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void InitializeProductImageMap()
        {

            productImageMap.Add("SP001", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\AoSomiTrang.jpg");
            productImageMap.Add("SP002", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\z5678947171084_bbfa82d9a2f1311fc1cef41de5a90db1.jpg");
            productImageMap.Add("SP003", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\z5678984228519_7cea90677c0d72fadb4db1a9c4ebc504.jpg");
            productImageMap.Add("SP004", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\z5678987824550_e6889af633c8a103e52946ddc838c739.jpg");
            productImageMap.Add("SP005", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aoSoMiTrang2.jpg");
            productImageMap.Add("SP006", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aoThunden1.jpg");
            productImageMap.Add("SP007", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aoThunDen2.jpg");
            productImageMap.Add("SP008", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aothunden3.jpg");
            productImageMap.Add("SP009", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\demi1.jpg");
            productImageMap.Add("SP0010", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\demi2.jpg");
            productImageMap.Add("SP0011", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\demi3.jpg");
            productImageMap.Add("SP0012", "D:\\FPOLY\\Ky3\\Block2\\DuAn_1_SonBN\\LamLaiLan3_duAn\\Ảnh db\\aothundenTrang.jpg");
        }

        private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0 || row >= ct_se.GetSanpham().Count)
            {
                return;
            }
            Click = dtg_sanpham.Rows[row].Cells[0].Value.ToString();
            bindata();
            if (e.RowIndex >= 0 || e.RowIndex == dtg_sanpham.Columns[0].Index)
            {
                string productCode = dtg_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (productImageMap.ContainsKey(productCode))
                {
                    pcb_sp.ImageLocation = productImageMap[productCode];
                    pcb_sp.Image = Image.FromFile(pcb_sp.ImageLocation);
                }
                else
                {
                    // Handle case when image is not found for the product code
                    // For example, display a default image or show an error message
                    pcb_sp.ImageLocation = "path/to/default-AoSomiTrang.jpg";
                }
            }
        }
        private void bindata()
        {
            var chon = ct_se.GetSanpham().Find(x => x.Masp == Click);
            txt_maSP.Text = chon.Masp;
            txt_tensp.Text = chon.Tensp;
            txt_soLuong.Text = chon.Soluong.ToString();
            txt_gia.Text = chon.Gia.ToString();
            rbtn_mota.Text = chon.Mota;
            txt_NgayNhan.Text = chon.Ngaynhan.ToString();
            txt_NgaySua.Text = chon.Ngaysua.ToString();
            txt_NguoiNhan.Text = chon.Nguoinhan;
            txt_NguoiSua.Text = chon.Nguoisua;
            if (chon.Trangthai == true)
            {
                rbtn_conhang.Checked = true;
            }
            else
            {
                rbtn_hethang.Checked = true;
            }
        }

        public void LoadTL()
        {
            dtg_tl.ColumnCount = 3;

            dtg_tl.Columns[0].Name = "Mã thể loại";
            dtg_tl.Columns[1].Name = "Tên thể loại";
            dtg_tl.Columns[2].Name = "Trạng thái";

            dtg_tl.Rows.Clear();

            foreach (var tl in ct_se.GetTheloais().Where(x => x.Tragthai == tttl))
            {
                dtg_tl.Rows.Add(tl.Matl, tl.Tentl, tl.Tragthai == true ? "Còn Hàng" : "Hết hàng");
            }
        }

        public void LoadSize()
        {
            dtg_size.ColumnCount = 3;

            dtg_size.Columns[0].Name = "Mã size";
            dtg_size.Columns[1].Name = "Size";
            dtg_size.Columns[2].Name = "Trạng thái";

            dtg_size.Rows.Clear();

            foreach (var s in ct_se.GetSizes().Where(x => x.Trangth == tts))
            {
                dtg_size.Rows.Add(s.Masize, s.Size, s.Trangth == true ? "Còn Hàng" : "Hết hàng");
            }
        }

        public void LoadMau()
        {
            dtg_mau.ColumnCount = 3;

            dtg_mau.Columns[0].Name = "Mã màu";
            dtg_mau.Columns[1].Name = "Màu";
            dtg_mau.Columns[2].Name = "Trạng thái";

            dtg_mau.Rows.Clear();

            foreach (var m in ct_se.GetMausacs().Where(x => x.Trgthai == ttms))
            {
                dtg_mau.Rows.Add(m.Mamau, m.Tenmau, m.Trgthai == true ? "Còn Hàng" : "Hết hàng");
            }
        }

        public void LoadXX()
        {
            dtg_xx.ColumnCount = 3;

            dtg_xx.Columns[0].Name = "Mã xuất xứ";
            dtg_xx.Columns[1].Name = "Địa chỉ";
            dtg_xx.Columns[2].Name = "Trạng thái";

            dtg_xx.Rows.Clear();

            foreach (var x in ct_se.GetXuatxus().Where(x => x.Trngthai == ttxx))
            {
                dtg_xx.Rows.Add(x.Maxx, x.Diachi, x.Trngthai == true ? "Còn Hàng" : "Hết hàng");
            }
        }


        MyContext dbcontext = new MyContext();
        public List<Chitietsanpham> getctsp(string ttsp)
        {
            var listspct = dbcontext.Chitietsanphams.Where(p => p.Trngthai.Equals(ttsp)).ToList();

            return listspct;
        }

        private void cmb_chontrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTrangThai = cmb_chontrangthai.SelectedItem.ToString();
            var checkctsp = getctsp(selectedTrangThai);

            if (cmb_chontrangthai.SelectedIndex == 0)
            {
                ttms = true;
                tts = true;
                ttsp = true;
                tttl = true;
                ttxx = true;
                tt = true;
            }
            else if (cmb_chontrangthai.SelectedIndex == 1)
            {
                ttms = false;
                tts = false;
                ttsp = false;
                tttl = false;
                ttxx = false;
                tt = false;
            }

            LoadSP();
            LoadMau();
            LoadXX();
            LoadTL();
            LoadSize();
            LoadCTSP();
        }

        private void dtg_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong < 0 || dong >= ct_se.GetSizes().Count)
            {
                return;
            }
            nhay = dtg_size.Rows[dong].Cells[0].Value.ToString();
            binSize();
        }

        private void binSize()
        {
            var ha = ct_se.GetSizes().Find(x => x.Masize == nhay);
            txt_masize.Text = ha.Masize;
            txt_size.Text = ha.Size;
            if (ha.Trangth == true)
            {
                rbtn_conhangSize.Checked = true;
            }
            else
            {
                rbtn_hethangSize.Checked = true;
            }
        }

        private void dtg_mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hia = e.RowIndex;
            if (hia < 0 || hia >= ct_se.GetMausacs().Count)
            {
                return;
            }
            dup = dtg_mau.Rows[hia].Cells[0].Value.ToString();
            BinMauSac();
        }

        private void BinMauSac()
        {
            var c = ct_se.GetMausacs().Find(x => x.Mamau == dup);
            txt_mamau.Text = c.Mamau;
            txt_tenmau.Text = c.Tenmau;
            if (c.Trgthai == true)
            {
                rbtn_conhangMau.Checked = true;
            }
            else
            {
                rbtn_hethangMau.Checked = true;
            }
        }

        private void dtg_xx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cot = e.RowIndex;
            if (cot < 0 || cot >= ct_se.GetXuatxus().Count)
            {
                return;
            }
            chon = dtg_xx.Rows[cot].Cells[0].Value.ToString();
            BinXX();
        }

        private void BinXX()
        {
            var h = ct_se.GetXuatxus().Find(x => x.Maxx == chon);
            txt_maxx.Text = h.Maxx;
            rtbx_diachi.Text = h.Diachi;
            if (h.Trngthai == true)
            {
                rbtn_conhangXX.Checked = true;
            }
            else
            {
                rbtn_hethangXX.Checked = true;
            }
        }

        private void dtg_tl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0 || row >= ct_se.GetTheloais().Count)
            {
                return;
            }
            Click = dtg_tl.Rows[row].Cells[0].Value.ToString();
            HienTheloai();
        }

        private void HienTheloai()
        {
            var nhay = ct_se.GetTheloais().Find(x => x.Matl == Click);
            txt_maTL.Text = nhay.Matl;
            txt_tentl.Text = nhay.Tentl;
            if (nhay.Tragthai == true)
            {
                rbtn_conhangTL.Checked = true;
            }
            else
            {
                rbtn_HetHangTL.Checked = true;
            }
        }

        private void btn_ThemTheLoai_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn thêm chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_maTL.Text) || string.IsNullOrWhiteSpace(txt_tentl.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin thể loại .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var checkTrung = dbcontext.Theloais.FirstOrDefault(t => t.Matl == txt_maTL.Text);
                if (checkTrung != null)
                {
                    MessageBox.Show("Mã thể loại đã tồn tại. Vui lòng nhập mã thể loại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Theloai tl = new Theloai();
                tl.Matl = txt_maTL.Text;
                tl.Tentl = txt_tentl.Text;
                if (rbtn_conhangTL.Checked == true)
                {
                    tl.Tragthai = true;
                }
                else
                {
                    tl.Tragthai = false;
                }
                MessageBox.Show(ct_se.ThemTL(tl));
                LoadTL();
            }
        }

        private void btn_SuaTheLoai_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn sửa chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(txt_maTL.Text) || string.IsNullOrWhiteSpace(txt_tentl.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Size áo .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dangsua = dbcontext.Sizeaonams.FirstOrDefault(p => p.Masize == txt_maTL.Text);
                if (dangsua == null)
                {
                    MessageBox.Show("Size áo không tồn tại, không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var a = ct_se.GetTheloais().Where(x => x.Matl == Click).FirstOrDefault();
                a.Matl = txt_maTL.Text;
                a.Tentl = txt_tentl.Text;
                if (rbtn_conhangTL.Checked == true)
                {
                    a.Tragthai = true;
                }
                else
                {
                    a.Tragthai = false;
                }
                MessageBox.Show(ct_se.CapNhatTL(a));
                LoadTL();
            }
        }

        private void btn_themSize_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn thêm chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_masize.Text) || string.IsNullOrWhiteSpace(txt_size.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin size .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var checkTrung = dbcontext.Sizeaonams.FirstOrDefault(t => t.Masize == txt_masize.Text);
                if (checkTrung != null)
                {
                    MessageBox.Show("Mã size đã tồn tại. Vui lòng nhập mã size khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Sizeaonam s = new Sizeaonam();
                s.Masize = txt_masize.Text;
                s.Size = txt_size.Text;
                if (rbtn_conhangSize.Checked == true)
                {
                    s.Trangth = true;
                }
                else { s.Trangth = false; }
                MessageBox.Show(ct_se.ThemS(s));
                LoadSize();
            }
        }

        private void btn_SuaSize_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn sửa chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(txt_maTL.Text) || string.IsNullOrWhiteSpace(txt_tentl.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Size áo .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dangsua = dbcontext.Sizeaonams.FirstOrDefault(p => p.Masize == txt_maTL.Text);
                if (dangsua == null)
                {
                    MessageBox.Show("Size áo không tồn tại, không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var k = ct_se.GetSizes().Where(x => x.Masize == Click).FirstOrDefault();
                k.Masize = txt_maTL.Text;
                k.Size = txt_tentl.Text;
                if (rbtn_conhangTL.Checked == true)
                {
                    k.Trangth = true;
                }
                else
                {
                    k.Trangth = false;
                }
                MessageBox.Show(ct_se.CapNhatS(k));
                LoadSize();
            }
        }

        private void btn_themMau_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn thêm chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_mamau.Text) || string.IsNullOrWhiteSpace(txt_tenmau.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin màu  .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var checkTrung = dbcontext.Mausacs.FirstOrDefault(t => t.Mamau == txt_mamau.Text);
                if (checkTrung != null)
                {
                    MessageBox.Show("Mã màu đã tồn tại. Vui lòng nhập mã màu khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Mausac m = new Mausac();
                m.Mamau = txt_mamau.Text;
                m.Tenmau = txt_tenmau.Text;
                if (rbtn_conhangMau.Checked == true)
                {
                    m.Trgthai = true;
                }
                else
                {
                    m.Trgthai = false;
                }
                MessageBox.Show(ct_se.ThemMS(m));
                LoadMau();
            }
        }

        private void btn_suaMau_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn sửa chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(txt_mamau.Text) || string.IsNullOrWhiteSpace(txt_tenmau.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin màu áo .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dangsua = dbcontext.Mausacs.FirstOrDefault(p => p.Mamau == txt_mamau.Text);
                if (dangsua == null)
                {
                    MessageBox.Show("Màu áo không tồn tại, không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var l = ct_se.GetMausacs().Where(x => x.Mamau == Click).FirstOrDefault();
                l.Mamau = txt_mamau.Text;
                l.Tenmau = txt_tenmau.Text;
                if (rbtn_conhangMau.Checked == true)
                {
                    l.Trgthai = true;
                }
                else { l.Trgthai = false; }
                MessageBox.Show(ct_se.CapNhatMS(l));
                LoadMau();
            }
        }

        private void btn_ThemXX_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn thêm chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_maxx.Text) || string.IsNullOrWhiteSpace(rtbx_diachi.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin xuất xứ  .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var checkTrung = dbcontext.Xuatxus.FirstOrDefault(t => t.Maxx == txt_maxx.Text);
                if (checkTrung != null)
                {
                    MessageBox.Show("Mã màu đã tồn tại. Vui lòng nhập mã màu khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Xuatxu x = new Xuatxu();
                x.Maxx = txt_maxx.Text;
                x.Diachi = rtbx_diachi.Text;
                if (rbtn_conhangXX.Checked == true)
                {
                    x.Trngthai = true;
                }
                else
                {
                    x.Trngthai = false;
                }
                MessageBox.Show(ct_se.ThemXX(x));
                LoadXX();
            }
        }

        private void btn_SuaXX_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn sửa chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(txt_maxx.Text) || string.IsNullOrWhiteSpace(rtbx_diachi.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin màu áo .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dangsua = dbcontext.Xuatxus.FirstOrDefault(p => p.Maxx == txt_maxx.Text);
                if (dangsua == null)
                {
                    MessageBox.Show("Màu áo không tồn tại, không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var z = ct_se.GetXuatxus().Where(x => x.Maxx == Click).FirstOrDefault();
                z.Maxx = txt_maxx.Text;
                z.Diachi = rtbx_diachi.Text;
                if (rbtn_conhangXX.Checked == true)
                {
                    z.Trngthai = true;
                }
                else
                {
                    z.Trngthai = false;
                }
                MessageBox.Show(ct_se.CapNhatXX(z));
                LoadXX();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn sửa chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(txt_maSP.Text) || string.IsNullOrWhiteSpace(txt_tensp.Text) || string.IsNullOrWhiteSpace(txt_soLuong.Text) || string.IsNullOrWhiteSpace(txt_gia.Text) || string.IsNullOrWhiteSpace(rbtn_mota.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dangsua = dbcontext.Sanphams.FirstOrDefault(p => p.Masp == txt_maSP.Text);
                if (dangsua == null)
                {
                    MessageBox.Show("Sản phẩm không tồn tại, không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var sp = ct_se.GetSanphams().Where(x => x.Masp == Click).FirstOrDefault();
                sp.Masp = txt_maSP.Text;
                sp.Tensp = txt_tensp.Text;
                sp.Soluong = int.Parse(txt_soLuong.Text);
                sp.Gia = decimal.Parse(txt_gia.Text);
                sp.Mota = rbtn_mota.Text;
                sp.Ngaynhan = DateOnly.Parse(txt_NgayNhan.Text);
                sp.Ngaysua = DateOnly.Parse(txt_NgaySua.Text);
                sp.Nguoinhan = txt_NguoiNhan.Text;
                sp.Nguoisua = txt_NguoiSua.Text;
                if (rbtn_conhang.Checked == true)
                {
                    sp.Trangthai = true;
                }
                else
                {
                    sp.Trangthai = false;
                }
                MessageBox.Show(ct_se.CapNhatSP(sp));
                LoadSP();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Chắc chắn bạn muốn thêm chứ  ", "Xác nhận ", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_maSP.Text) || string.IsNullOrWhiteSpace(txt_tensp.Text) || string.IsNullOrWhiteSpace(txt_soLuong.Text) || string.IsNullOrWhiteSpace(txt_gia.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phảm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var checkTrung = dbcontext.Sanphams.FirstOrDefault(t => t.Masp == txt_maSP.Text);
                if (checkTrung != null)
                {
                    MessageBox.Show("Mã Sản phẩm đã tồn tại. Vui lòng nhập mã sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Sanpham sp = new Sanpham();
                sp.Masp = txt_maSP.Text;
                sp.Tensp = txt_tensp.Text;
                sp.Soluong = int.Parse(txt_soLuong.Text);
                sp.Gia = decimal.Parse(txt_gia.Text);
                sp.Mota = rbtn_mota.Text;
                sp.Ngaynhan = DateOnly.Parse(txt_NgayNhan.Text);
                sp.Ngaysua = DateOnly.Parse(txt_NgaySua.Text);
                sp.Nguoinhan = txt_NguoiNhan.Text;
                sp.Nguoisua = txt_NguoiSua.Text;
                if (rbtn_conhang.Checked == true)
                {
                    sp.Trangthai = true;
                }
                else
                {
                    sp.Trangthai = false;
                }
                MessageBox.Show(ct_se.ThemSP(sp));
                LoadSP();
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void btn_loadTL_Click(object sender, EventArgs e)
        {
            LoadTL();
        }

        private void bth_LoadSize_Click(object sender, EventArgs e)
        {
            LoadSize();
        }

        private void btn_loadMau_Click(object sender, EventArgs e)
        {
            LoadMau();
        }

        private void btn_loadXX_Click(object sender, EventArgs e)
        {
            LoadXX();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSP();
        }
    }
}

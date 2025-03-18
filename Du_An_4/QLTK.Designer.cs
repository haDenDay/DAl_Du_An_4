namespace Du_An_4
{
    partial class QLTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTK));
            cmb_theoTrangThai = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dtg_tkhoan = new DataGridView();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_khoa = new Button();
            txt_tim = new TextBox();
            btn_timkiem = new Button();
            btn_Load = new Button();
            btn_sua = new Button();
            btn_themTK = new Button();
            groupBox1 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            cmb_PhanLoai = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            rbtn_ngungHD = new RadioButton();
            rbtn_hoatDong = new RadioButton();
            txt_nguoiNhan = new TextBox();
            txt_ngaySua = new TextBox();
            txt_nguoiSua = new TextBox();
            txt_ngayNhan = new TextBox();
            txt_mk = new TextBox();
            txt_tentk = new TextBox();
            txt_matk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_tkhoan).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cmb_theoTrangThai
            // 
            cmb_theoTrangThai.FormattingEnabled = true;
            cmb_theoTrangThai.Items.AddRange(new object[] { "Hoạt động", "Ngừng hoạt động;" });
            cmb_theoTrangThai.Location = new Point(732, 392);
            cmb_theoTrangThai.Name = "cmb_theoTrangThai";
            cmb_theoTrangThai.Size = new Size(151, 28);
            cmb_theoTrangThai.TabIndex = 11;
            cmb_theoTrangThai.SelectedIndexChanged += cmb_theoTrangThai_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(572, 395);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 10;
            label2.Text = "Theo trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(77, 382);
            label1.Name = "label1";
            label1.Size = new Size(352, 38);
            label1.TabIndex = 9;
            label1.Text = "DANH SÁCH TÀI KHOẢN ";
            // 
            // dtg_tkhoan
            // 
            dtg_tkhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_tkhoan.Location = new Point(12, 450);
            dtg_tkhoan.Name = "dtg_tkhoan";
            dtg_tkhoan.RowHeadersWidth = 51;
            dtg_tkhoan.Size = new Size(944, 188);
            dtg_tkhoan.TabIndex = 8;
            dtg_tkhoan.CellClick += dtg_tkhoan_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(btn_khoa);
            groupBox2.Controls.Add(txt_tim);
            groupBox2.Controls.Add(btn_timkiem);
            groupBox2.Controls.Add(btn_Load);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_themTK);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(635, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 333);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "CHỨC NĂNG";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(74, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 115;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 152);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 114;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // btn_khoa
            // 
            btn_khoa.Location = new Point(167, 139);
            btn_khoa.Name = "btn_khoa";
            btn_khoa.Size = new Size(148, 53);
            btn_khoa.TabIndex = 6;
            btn_khoa.Text = "Khóa ";
            btn_khoa.UseVisualStyleBackColor = true;
            // 
            // txt_tim
            // 
            txt_tim.Location = new Point(9, 218);
            txt_tim.Name = "txt_tim";
            txt_tim.Size = new Size(306, 30);
            txt_tim.TabIndex = 5;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(65, 263);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(183, 54);
            btn_timkiem.TabIndex = 4;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // btn_Load
            // 
            btn_Load.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Load.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Load.Location = new Point(9, 141);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(146, 53);
            btn_Load.TabIndex = 2;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.Location = new Point(167, 53);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(148, 49);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_themTK
            // 
            btn_themTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_themTK.Location = new Point(9, 53);
            btn_themTK.Name = "btn_themTK";
            btn_themTK.Size = new Size(146, 49);
            btn_themTK.TabIndex = 0;
            btn_themTK.Text = "Thêm";
            btn_themTK.UseVisualStyleBackColor = true;
            btn_themTK.Click += btn_themTK_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cmb_PhanLoai);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txt_nguoiNhan);
            groupBox1.Controls.Add(txt_ngaySua);
            groupBox1.Controls.Add(txt_nguoiSua);
            groupBox1.Controls.Add(txt_ngayNhan);
            groupBox1.Controls.Add(txt_mk);
            groupBox1.Controls.Add(txt_tentk);
            groupBox1.Controls.Add(txt_matk);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 333);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(2, 125);
            label16.Name = "label16";
            label16.Size = new Size(24, 31);
            label16.TabIndex = 23;
            label16.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(0, 79);
            label15.Name = "label15";
            label15.Size = new Size(24, 31);
            label15.TabIndex = 22;
            label15.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(351, 279);
            label14.Name = "label14";
            label14.Size = new Size(230, 23);
            label14.TabIndex = 21;
            label14.Text = "Không được phép bỏ trống";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(308, 273);
            label13.Name = "label13";
            label13.Size = new Size(52, 31);
            label13.TabIndex = 20;
            label13.Text = "( * )";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(264, 92);
            label12.Name = "label12";
            label12.Size = new Size(24, 31);
            label12.TabIndex = 19;
            label12.Text = "*";
            // 
            // cmb_PhanLoai
            // 
            cmb_PhanLoai.FormattingEnabled = true;
            cmb_PhanLoai.Items.AddRange(new object[] { "Nhân viên", "Admin", "Khách hàng" });
            cmb_PhanLoai.Location = new Point(426, 92);
            cmb_PhanLoai.Name = "cmb_PhanLoai";
            cmb_PhanLoai.Size = new Size(176, 28);
            cmb_PhanLoai.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(285, 158);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 17;
            label11.Text = "Trạng thái";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(285, 95);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 16;
            label10.Text = "Phân loại tài khoản";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(285, 38);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 15;
            label9.Text = "Người nhận";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 273);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 14;
            label8.Text = "Người sửa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 218);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 13;
            label7.Text = "Ngày nhận";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 172);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 12;
            label6.Text = "Ngày sửa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 128);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 82);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 10;
            label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 38);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 9;
            label3.Text = "Mã tài khoản";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtn_ngungHD);
            groupBox3.Controls.Add(rbtn_hoatDong);
            groupBox3.Location = new Point(426, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 109);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // rbtn_ngungHD
            // 
            rbtn_ngungHD.AutoSize = true;
            rbtn_ngungHD.Location = new Point(6, 66);
            rbtn_ngungHD.Name = "rbtn_ngungHD";
            rbtn_ngungHD.Size = new Size(149, 24);
            rbtn_ngungHD.TabIndex = 1;
            rbtn_ngungHD.TabStop = true;
            rbtn_ngungHD.Text = "Ngừng hoạt động";
            rbtn_ngungHD.UseVisualStyleBackColor = true;
            // 
            // rbtn_hoatDong
            // 
            rbtn_hoatDong.AutoSize = true;
            rbtn_hoatDong.Location = new Point(6, 30);
            rbtn_hoatDong.Name = "rbtn_hoatDong";
            rbtn_hoatDong.Size = new Size(102, 24);
            rbtn_hoatDong.TabIndex = 0;
            rbtn_hoatDong.TabStop = true;
            rbtn_hoatDong.Text = "Hoạt đông";
            rbtn_hoatDong.UseVisualStyleBackColor = true;
            // 
            // txt_nguoiNhan
            // 
            txt_nguoiNhan.Location = new Point(426, 35);
            txt_nguoiNhan.Name = "txt_nguoiNhan";
            txt_nguoiNhan.Size = new Size(176, 27);
            txt_nguoiNhan.TabIndex = 6;
            // 
            // txt_ngaySua
            // 
            txt_ngaySua.Location = new Point(123, 169);
            txt_ngaySua.Name = "txt_ngaySua";
            txt_ngaySua.Size = new Size(125, 27);
            txt_ngaySua.TabIndex = 5;
            // 
            // txt_nguoiSua
            // 
            txt_nguoiSua.Location = new Point(123, 266);
            txt_nguoiSua.Name = "txt_nguoiSua";
            txt_nguoiSua.Size = new Size(125, 27);
            txt_nguoiSua.TabIndex = 4;
            // 
            // txt_ngayNhan
            // 
            txt_ngayNhan.Location = new Point(123, 215);
            txt_ngayNhan.Name = "txt_ngayNhan";
            txt_ngayNhan.Size = new Size(125, 27);
            txt_ngayNhan.TabIndex = 3;
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(123, 125);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(125, 27);
            txt_mk.TabIndex = 2;
            // 
            // txt_tentk
            // 
            txt_tentk.Location = new Point(123, 79);
            txt_tentk.Name = "txt_tentk";
            txt_tentk.Size = new Size(125, 27);
            txt_tentk.TabIndex = 1;
            // 
            // txt_matk
            // 
            txt_matk.Location = new Point(123, 35);
            txt_matk.Name = "txt_matk";
            txt_matk.Size = new Size(125, 27);
            txt_matk.TabIndex = 0;
            // 
            // QLTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 650);
            Controls.Add(cmb_theoTrangThai);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_tkhoan);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QLTK";
            Text = "QLTK";
            Load += QLTK_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_tkhoan).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_theoTrangThai;
        private Label label2;
        private Label label1;
        private DataGridView dtg_tkhoan;
        private GroupBox groupBox2;
        private Button btn_khoa;
        private TextBox txt_tim;
        private Button btn_timkiem;
        private Button btn_Load;
        private Button btn_sua;
        private Button btn_themTK;
        private GroupBox groupBox1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox cmb_PhanLoai;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private RadioButton rbtn_ngungHD;
        private RadioButton rbtn_hoatDong;
        private TextBox txt_nguoiNhan;
        private TextBox txt_ngaySua;
        private TextBox txt_nguoiSua;
        private TextBox txt_ngayNhan;
        private TextBox txt_mk;
        private TextBox txt_tentk;
        private TextBox txt_matk;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
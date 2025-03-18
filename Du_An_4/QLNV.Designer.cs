namespace Du_An_4
{
    partial class QLNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNV));
            label24 = new Label();
            cmb_trangthaiNV = new ComboBox();
            pcb_nhanvien = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            txt_tim = new TextBox();
            btn_TimKiem = new Button();
            label5 = new Label();
            dtg_nv = new DataGridView();
            btn_Load = new Button();
            groupBox1 = new GroupBox();
            label23 = new Label();
            label22 = new Label();
            label20 = new Label();
            label21 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            groupBox4 = new GroupBox();
            rbtn_nu = new RadioButton();
            rbtn_nam = new RadioButton();
            rbtn_noiThuongchu = new RichTextBox();
            groupBox3 = new GroupBox();
            rbtn_nghi = new RadioButton();
            rbtn_hoatdong = new RadioButton();
            txt_Ngaysinh = new TextBox();
            label4 = new Label();
            txt_Nguoinhan = new TextBox();
            txt_ngayNhan = new TextBox();
            txt_Chucvu = new TextBox();
            txt_cccd = new TextBox();
            txt_QuocTich = new TextBox();
            txt_Diachi = new TextBox();
            txt_Ten = new TextBox();
            txt_MaTK = new TextBox();
            txt_maNV = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label13 = new Label();
            txt_NguoiSua = new TextBox();
            txt_NgaySua = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label16 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcb_nhanvien).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_nv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Red;
            label24.Location = new Point(586, 418);
            label24.Name = "label24";
            label24.Size = new Size(163, 23);
            label24.TabIndex = 110;
            label24.Text = "Lọc theo trạng thái";
            // 
            // cmb_trangthaiNV
            // 
            cmb_trangthaiNV.FormattingEnabled = true;
            cmb_trangthaiNV.Items.AddRange(new object[] { "Hoạt động", "Nghỉ" });
            cmb_trangthaiNV.Location = new Point(755, 415);
            cmb_trangthaiNV.Name = "cmb_trangthaiNV";
            cmb_trangthaiNV.Size = new Size(184, 28);
            cmb_trangthaiNV.TabIndex = 109;
            cmb_trangthaiNV.SelectedIndexChanged += cmb_trangthaiNV_SelectedIndexChanged;
            // 
            // pcb_nhanvien
            // 
            pcb_nhanvien.Location = new Point(949, 334);
            pcb_nhanvien.Name = "pcb_nhanvien";
            pcb_nhanvien.Size = new Size(305, 334);
            pcb_nhanvien.TabIndex = 108;
            pcb_nhanvien.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txt_tim);
            groupBox2.Controls.Add(btn_TimKiem);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(945, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 271);
            groupBox2.TabIndex = 107;
            groupBox2.TabStop = false;
            groupBox2.Text = "CHỨC NĂNG";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(77, 201);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(15, 47);
            button2.Name = "button2";
            button2.Size = new Size(140, 47);
            button2.TabIndex = 13;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(161, 47);
            button1.Name = "button1";
            button1.Size = new Size(142, 47);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_tim
            // 
            txt_tim.Location = new Point(26, 148);
            txt_tim.Name = "txt_tim";
            txt_tim.Size = new Size(257, 27);
            txt_tim.TabIndex = 11;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimKiem.Location = new Point(70, 192);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(170, 51);
            btn_TimKiem.TabIndex = 8;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(16, 403);
            label5.Name = "label5";
            label5.Size = new Size(349, 38);
            label5.TabIndex = 106;
            label5.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dtg_nv
            // 
            dtg_nv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_nv.Location = new Point(9, 470);
            dtg_nv.Name = "dtg_nv";
            dtg_nv.RowHeadersWidth = 51;
            dtg_nv.Size = new Size(932, 184);
            dtg_nv.TabIndex = 105;
            dtg_nv.CellClick += dtg_nv_CellClick;
            // 
            // btn_Load
            // 
            btn_Load.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Load.ForeColor = Color.Blue;
            btn_Load.Location = new Point(414, 403);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(144, 44);
            btn_Load.TabIndex = 103;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(rbtn_noiThuongchu);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txt_Ngaysinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Nguoinhan);
            groupBox1.Controls.Add(txt_ngayNhan);
            groupBox1.Controls.Add(txt_Chucvu);
            groupBox1.Controls.Add(txt_cccd);
            groupBox1.Controls.Add(txt_QuocTich);
            groupBox1.Controls.Add(txt_Diachi);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(txt_MaTK);
            groupBox1.Controls.Add(txt_maNV);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txt_NguoiSua);
            groupBox1.Controls.Add(txt_NgaySua);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label16);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(7, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(932, 355);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(315, 29);
            label23.Name = "label23";
            label23.Size = new Size(24, 31);
            label23.TabIndex = 101;
            label23.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(315, 279);
            label22.Name = "label22";
            label22.Size = new Size(24, 31);
            label22.TabIndex = 100;
            label22.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(424, 318);
            label20.Name = "label20";
            label20.Size = new Size(230, 23);
            label20.TabIndex = 99;
            label20.Text = "Không được phép bỏ trống";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(381, 312);
            label21.Name = "label21";
            label21.Size = new Size(52, 31);
            label21.TabIndex = 98;
            label21.Text = "( * )";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(1, 33);
            label19.Name = "label19";
            label19.Size = new Size(24, 31);
            label19.TabIndex = 97;
            label19.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(1, 152);
            label18.Name = "label18";
            label18.Size = new Size(24, 31);
            label18.TabIndex = 96;
            label18.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(314, 211);
            label17.Name = "label17";
            label17.Size = new Size(24, 31);
            label17.TabIndex = 95;
            label17.Text = "*";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbtn_nu);
            groupBox4.Controls.Add(rbtn_nam);
            groupBox4.Location = new Point(126, 249);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(161, 73);
            groupBox4.TabIndex = 94;
            groupBox4.TabStop = false;
            // 
            // rbtn_nu
            // 
            rbtn_nu.AutoSize = true;
            rbtn_nu.Location = new Point(90, 30);
            rbtn_nu.Name = "rbtn_nu";
            rbtn_nu.Size = new Size(50, 24);
            rbtn_nu.TabIndex = 1;
            rbtn_nu.TabStop = true;
            rbtn_nu.Text = "Nữ";
            rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            rbtn_nam.AutoSize = true;
            rbtn_nam.Location = new Point(6, 30);
            rbtn_nam.Name = "rbtn_nam";
            rbtn_nam.Size = new Size(62, 24);
            rbtn_nam.TabIndex = 0;
            rbtn_nam.TabStop = true;
            rbtn_nam.Text = "Nam";
            rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_noiThuongchu
            // 
            rbtn_noiThuongchu.Location = new Point(457, 134);
            rbtn_noiThuongchu.Name = "rbtn_noiThuongchu";
            rbtn_noiThuongchu.Size = new Size(159, 72);
            rbtn_noiThuongchu.TabIndex = 93;
            rbtn_noiThuongchu.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtn_nghi);
            groupBox3.Controls.Add(rbtn_hoatdong);
            groupBox3.Location = new Point(717, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 73);
            groupBox3.TabIndex = 92;
            groupBox3.TabStop = false;
            // 
            // rbtn_nghi
            // 
            rbtn_nghi.AutoSize = true;
            rbtn_nghi.Location = new Point(114, 30);
            rbtn_nghi.Name = "rbtn_nghi";
            rbtn_nghi.Size = new Size(62, 24);
            rbtn_nghi.TabIndex = 1;
            rbtn_nghi.TabStop = true;
            rbtn_nghi.Text = "Nghỉ";
            rbtn_nghi.UseVisualStyleBackColor = true;
            // 
            // rbtn_hoatdong
            // 
            rbtn_hoatdong.AutoSize = true;
            rbtn_hoatdong.Location = new Point(6, 30);
            rbtn_hoatdong.Name = "rbtn_hoatdong";
            rbtn_hoatdong.Size = new Size(102, 24);
            rbtn_hoatdong.TabIndex = 0;
            rbtn_hoatdong.TabStop = true;
            rbtn_hoatdong.Text = "Hoạt động";
            rbtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // txt_Ngaysinh
            // 
            txt_Ngaysinh.Location = new Point(126, 209);
            txt_Ngaysinh.Name = "txt_Ngaysinh";
            txt_Ngaysinh.Size = new Size(161, 27);
            txt_Ngaysinh.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 216);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 90;
            label4.Text = "Ngày sinh";
            // 
            // txt_Nguoinhan
            // 
            txt_Nguoinhan.Location = new Point(716, 93);
            txt_Nguoinhan.Name = "txt_Nguoinhan";
            txt_Nguoinhan.Size = new Size(161, 27);
            txt_Nguoinhan.TabIndex = 89;
            // 
            // txt_ngayNhan
            // 
            txt_ngayNhan.Location = new Point(716, 24);
            txt_ngayNhan.Name = "txt_ngayNhan";
            txt_ngayNhan.Size = new Size(161, 27);
            txt_ngayNhan.TabIndex = 88;
            // 
            // txt_Chucvu
            // 
            txt_Chucvu.Location = new Point(457, 274);
            txt_Chucvu.Name = "txt_Chucvu";
            txt_Chucvu.Size = new Size(159, 27);
            txt_Chucvu.TabIndex = 87;
            // 
            // txt_cccd
            // 
            txt_cccd.Location = new Point(457, 212);
            txt_cccd.Name = "txt_cccd";
            txt_cccd.Size = new Size(159, 27);
            txt_cccd.TabIndex = 86;
            // 
            // txt_QuocTich
            // 
            txt_QuocTich.Location = new Point(455, 89);
            txt_QuocTich.Name = "txt_QuocTich";
            txt_QuocTich.Size = new Size(161, 27);
            txt_QuocTich.TabIndex = 84;
            // 
            // txt_Diachi
            // 
            txt_Diachi.Location = new Point(455, 28);
            txt_Diachi.Name = "txt_Diachi";
            txt_Diachi.Size = new Size(161, 27);
            txt_Diachi.TabIndex = 83;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(126, 152);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(161, 27);
            txt_Ten.TabIndex = 80;
            // 
            // txt_MaTK
            // 
            txt_MaTK.Location = new Point(126, 82);
            txt_MaTK.Name = "txt_MaTK";
            txt_MaTK.Size = new Size(161, 27);
            txt_MaTK.TabIndex = 79;
            // 
            // txt_maNV
            // 
            txt_maNV.Location = new Point(126, 24);
            txt_maNV.Name = "txt_maNV";
            txt_maNV.Size = new Size(161, 27);
            txt_maNV.TabIndex = 78;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(629, 96);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 77;
            label12.Text = "Người nhận";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(629, 31);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 76;
            label11.Text = "Ngày nhận";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(339, 281);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 75;
            label10.Text = "Chức vụ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 212);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 74;
            label9.Text = "Số CCCD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 137);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 73;
            label8.Text = "Nơi thường chú";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 96);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 72;
            label7.Text = "Quốc tịch";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 31);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 71;
            label6.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 281);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 70;
            label1.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 155);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 68;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 89);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 67;
            label2.Text = "Mã tài khoản";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(23, 35);
            label13.Name = "label13";
            label13.Size = new Size(97, 20);
            label13.TabIndex = 66;
            label13.Text = "Mã nhân viên";
            // 
            // txt_NguoiSua
            // 
            txt_NguoiSua.Location = new Point(716, 216);
            txt_NguoiSua.Name = "txt_NguoiSua";
            txt_NguoiSua.Size = new Size(161, 27);
            txt_NguoiSua.TabIndex = 64;
            // 
            // txt_NgaySua
            // 
            txt_NgaySua.Location = new Point(716, 162);
            txt_NgaySua.Name = "txt_NgaySua";
            txt_NgaySua.Size = new Size(161, 27);
            txt_NgaySua.TabIndex = 63;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(636, 281);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 62;
            label15.Text = "Trạng thái";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(636, 219);
            label14.Name = "label14";
            label14.Size = new Size(78, 20);
            label14.TabIndex = 61;
            label14.Text = "Người sửa";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(636, 162);
            label16.Name = "label16";
            label16.Size = new Size(71, 20);
            label16.TabIndex = 60;
            label16.Text = "Ngày sửa";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(422, 410);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 111;
            pictureBox5.TabStop = false;
            // 
            // QLNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 690);
            Controls.Add(pictureBox5);
            Controls.Add(label24);
            Controls.Add(cmb_trangthaiNV);
            Controls.Add(pcb_nhanvien);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(dtg_nv);
            Controls.Add(btn_Load);
            Controls.Add(groupBox1);
            Name = "QLNV";
            Text = "QLNV";
            Load += QLNV_Load;
            ((System.ComponentModel.ISupportInitialize)pcb_nhanvien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_nv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label24;
        private ComboBox cmb_trangthaiNV;
        private PictureBox pcb_nhanvien;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private TextBox txt_tim;
        private Button btn_TimKiem;
        private Label label5;
        private DataGridView dtg_nv;
        private Button btn_Load;
        private GroupBox groupBox1;
        private Label label23;
        private Label label22;
        private Label label20;
        private Label label21;
        private Label label19;
        private Label label18;
        private Label label17;
        private GroupBox groupBox4;
        private RadioButton rbtn_nu;
        private RadioButton rbtn_nam;
        private RichTextBox rbtn_noiThuongchu;
        private GroupBox groupBox3;
        private RadioButton rbtn_nghi;
        private RadioButton rbtn_hoatdong;
        private TextBox txt_Ngaysinh;
        private Label label4;
        private TextBox txt_Nguoinhan;
        private TextBox txt_ngayNhan;
        private TextBox txt_Chucvu;
        private TextBox txt_cccd;
        private TextBox txt_QuocTich;
        private TextBox txt_Diachi;
        private TextBox txt_Ten;
        private TextBox txt_MaTK;
        private TextBox txt_maNV;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label13;
        private TextBox txt_NguoiSua;
        private TextBox txt_NgaySua;
        private Label label15;
        private Label label14;
        private Label label16;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
    }
}
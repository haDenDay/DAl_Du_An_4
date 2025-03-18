namespace Du_An_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txt_Pass = new TextBox();
            txt_Use = new TextBox();
            btn_thoat = new Button();
            btn_dangnhap = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(204, 187);
            button2.Name = "button2";
            button2.Size = new Size(136, 29);
            button2.TabIndex = 37;
            button2.Text = "Quên mật khẩu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(34, 187);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 36;
            button1.Text = "Hiện thị mật khẩu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(378, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(121, 29);
            label3.Name = "label3";
            label3.Size = new Size(131, 31);
            label3.TabIndex = 34;
            label3.Text = "Đăng nhập";
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(97, 133);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PasswordChar = '*';
            txt_Pass.Size = new Size(243, 27);
            txt_Pass.TabIndex = 33;
            // 
            // txt_Use
            // 
            txt_Use.Location = new Point(97, 82);
            txt_Use.Name = "txt_Use";
            txt_Use.Size = new Size(243, 27);
            txt_Use.TabIndex = 32;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.White;
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thoat.ForeColor = Color.Blue;
            btn_thoat.Location = new Point(226, 231);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(99, 41);
            btn_thoat.TabIndex = 31;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.White;
            btn_dangnhap.BackgroundImageLayout = ImageLayout.None;
            btn_dangnhap.Cursor = Cursors.SizeAll;
            btn_dangnhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangnhap.ForeColor = Color.Blue;
            btn_dangnhap.ImageAlign = ContentAlignment.BottomRight;
            btn_dangnhap.Location = new Point(52, 231);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(109, 41);
            btn_dangnhap.TabIndex = 29;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(15, 140);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 30;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(15, 89);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 28;
            label1.Text = "Usename";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 319);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txt_Pass);
            Controls.Add(txt_Use);
            Controls.Add(btn_thoat);
            Controls.Add(btn_dangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txt_Pass;
        private TextBox txt_Use;
        private Button btn_thoat;
        private Button btn_dangnhap;
        private Label label2;
        private Label label1;
    }
}

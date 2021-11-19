
namespace FORM
{
    partial class frmQuanLiNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiNhanVien));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_show = new System.Windows.Forms.Panel();
            this.panel_chucnang = new System.Windows.Forms.Panel();
            this.cmd_doimatkhau = new System.Windows.Forms.Button();
            this.cmd_tracuu = new System.Windows.Forms.Button();
            this.panel_danhmuc = new System.Windows.Forms.Panel();
            this.cmd_tienluong = new System.Windows.Forms.Button();
            this.cmd_nhansu = new System.Windows.Forms.Button();
            this.cmd_chucnag = new System.Windows.Forms.Button();
            this.cmd_danhmuc = new System.Windows.Forms.Button();
            this.cmd_taiKhoan = new System.Windows.Forms.Button();
            this.panel_taikhoan = new System.Windows.Forms.Panel();
            this.cmd_thongtin = new System.Windows.Forms.Button();
            this.cmd_dangnhap = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_chucnang.SuspendLayout();
            this.panel_danhmuc.SuspendLayout();
            this.panel_taikhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(51, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 52);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(1205, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 37);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
           
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem4,
            this.menuItem5});
            this.menuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(124, 33);
            this.menuItem1.Text = "&Tài khoản";
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(223, 36);
            this.menuItem4.Text = "Đăng Nhập";
            // 
            // menuItem5
            // 
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(223, 36);
            this.menuItem5.Text = "Thông tin";
            this.menuItem5.Click += new System.EventHandler(this.cmd_thongtin_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem7,
            this.menuItem8});
            this.menuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(130, 33);
            this.menuItem2.Text = "&Danh Mục";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Name = "menuItem7";
            this.menuItem7.Size = new System.Drawing.Size(217, 36);
            this.menuItem7.Text = "Nhân Sự";
            this.menuItem7.Click += new System.EventHandler(this.cmd_nhansu_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Name = "menuItem8";
            this.menuItem8.Size = new System.Drawing.Size(217, 36);
            this.menuItem8.Text = "Tiền lương";
            this.menuItem8.Click += new System.EventHandler(this.cmd_tienluong_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem11,
            this.menuItem13});
            this.menuItem3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(132, 33);
            this.menuItem3.Text = "&Chức năng";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Name = "menuItem11";
            this.menuItem11.Size = new System.Drawing.Size(270, 36);
            this.menuItem11.Text = "Tra cứu";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Name = "menuItem13";
            this.menuItem13.Size = new System.Drawing.Size(270, 36);
            this.menuItem13.Text = "Đổi mật khẩu";
            this.menuItem13.Click += new System.EventHandler(this.cmd_doimatkhau_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(65, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 52);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.Color.White;
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Location = new System.Drawing.Point(195, 58);
            this.panel_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1412, 854);
            this.panel_show.TabIndex = 16;
            // 
            // panel_chucnang
            // 
            this.panel_chucnang.BackColor = System.Drawing.Color.Transparent;
            this.panel_chucnang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_chucnang.Controls.Add(this.cmd_doimatkhau);
            this.panel_chucnang.Controls.Add(this.cmd_tracuu);
            this.panel_chucnang.Enabled = false;
            this.panel_chucnang.Location = new System.Drawing.Point(3, 509);
            this.panel_chucnang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_chucnang.Name = "panel_chucnang";
            this.panel_chucnang.Size = new System.Drawing.Size(189, 152);
            this.panel_chucnang.TabIndex = 24;
            // 
            // cmd_doimatkhau
            // 
            this.cmd_doimatkhau.BackColor = System.Drawing.Color.Transparent;
            this.cmd_doimatkhau.BackgroundImage = global::FORM.Properties.Resources.b1;
            this.cmd_doimatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_doimatkhau.FlatAppearance.BorderSize = 0;
            this.cmd_doimatkhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_doimatkhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_doimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_doimatkhau.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_doimatkhau.Image = global::FORM.Properties.Resources._1269515091_keepassx;
            this.cmd_doimatkhau.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmd_doimatkhau.Location = new System.Drawing.Point(4, 84);
            this.cmd_doimatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_doimatkhau.Name = "cmd_doimatkhau";
            this.cmd_doimatkhau.Size = new System.Drawing.Size(176, 57);
            this.cmd_doimatkhau.TabIndex = 14;
            this.cmd_doimatkhau.Text = "Đổi mật khẩu";
            this.cmd_doimatkhau.UseVisualStyleBackColor = false;
            this.cmd_doimatkhau.Click += new System.EventHandler(this.cmd_doimatkhau_Click);
            // 
            // cmd_tracuu
            // 
            this.cmd_tracuu.BackColor = System.Drawing.Color.Transparent;
            this.cmd_tracuu.BackgroundImage = global::FORM.Properties.Resources.b1;
            this.cmd_tracuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_tracuu.FlatAppearance.BorderSize = 0;
            this.cmd_tracuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_tracuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_tracuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_tracuu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_tracuu.Image = global::FORM.Properties.Resources.tim;
            this.cmd_tracuu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmd_tracuu.Location = new System.Drawing.Point(4, 13);
            this.cmd_tracuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_tracuu.Name = "cmd_tracuu";
            this.cmd_tracuu.Size = new System.Drawing.Size(176, 61);
            this.cmd_tracuu.TabIndex = 13;
            this.cmd_tracuu.Text = "Tra Cứu";
            this.cmd_tracuu.UseVisualStyleBackColor = false;
            this.cmd_tracuu.Click += new System.EventHandler(this.cmd_tracuu_Click);
            // 
            // panel_danhmuc
            // 
            this.panel_danhmuc.BackColor = System.Drawing.Color.Transparent;
            this.panel_danhmuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_danhmuc.Controls.Add(this.cmd_tienluong);
            this.panel_danhmuc.Controls.Add(this.cmd_nhansu);
            this.panel_danhmuc.Enabled = false;
            this.panel_danhmuc.Location = new System.Drawing.Point(7, 671);
            this.panel_danhmuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_danhmuc.Name = "panel_danhmuc";
            this.panel_danhmuc.Size = new System.Drawing.Size(185, 160);
            this.panel_danhmuc.TabIndex = 23;
            // 
            // cmd_tienluong
            // 
            this.cmd_tienluong.BackColor = System.Drawing.Color.Transparent;
            this.cmd_tienluong.BackgroundImage = global::FORM.Properties.Resources.b1;
            this.cmd_tienluong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_tienluong.FlatAppearance.BorderSize = 0;
            this.cmd_tienluong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_tienluong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_tienluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_tienluong.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_tienluong.Image = global::FORM.Properties.Resources.TinhLuong;
            this.cmd_tienluong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmd_tienluong.Location = new System.Drawing.Point(4, 92);
            this.cmd_tienluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_tienluong.Name = "cmd_tienluong";
            this.cmd_tienluong.Size = new System.Drawing.Size(176, 55);
            this.cmd_tienluong.TabIndex = 11;
            this.cmd_tienluong.Text = "Tiền lương";
            this.cmd_tienluong.UseVisualStyleBackColor = false;
            this.cmd_tienluong.Click += new System.EventHandler(this.cmd_tienluong_Click);
            // 
            // cmd_nhansu
            // 
            this.cmd_nhansu.BackColor = System.Drawing.Color.Transparent;
            this.cmd_nhansu.BackgroundImage = global::FORM.Properties.Resources.b1;
            this.cmd_nhansu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_nhansu.FlatAppearance.BorderSize = 0;
            this.cmd_nhansu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_nhansu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_nhansu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_nhansu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_nhansu.Image = global::FORM.Properties.Resources._1269448502_administrator;
            this.cmd_nhansu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmd_nhansu.Location = new System.Drawing.Point(4, 18);
            this.cmd_nhansu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_nhansu.Name = "cmd_nhansu";
            this.cmd_nhansu.Size = new System.Drawing.Size(176, 64);
            this.cmd_nhansu.TabIndex = 11;
            this.cmd_nhansu.Text = "Nhân Sự";
            this.cmd_nhansu.UseVisualStyleBackColor = false;
            this.cmd_nhansu.Click += new System.EventHandler(this.cmd_nhansu_Click);
            // 
            // cmd_chucnag
            // 
            this.cmd_chucnag.BackColor = System.Drawing.Color.Transparent;
            this.cmd_chucnag.BackgroundImage = global::FORM.Properties.Resources.xanh;
            this.cmd_chucnag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_chucnag.FlatAppearance.BorderSize = 0;
            this.cmd_chucnag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_chucnag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_chucnag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_chucnag.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_chucnag.Location = new System.Drawing.Point(3, 288);
            this.cmd_chucnag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_chucnag.Name = "cmd_chucnag";
            this.cmd_chucnag.Size = new System.Drawing.Size(189, 75);
            this.cmd_chucnag.TabIndex = 12;
            this.cmd_chucnag.Text = "Chức năng";
            this.cmd_chucnag.UseVisualStyleBackColor = false;
            this.cmd_chucnag.Click += new System.EventHandler(this.cmd_chucnag_Click);
            // 
            // cmd_danhmuc
            // 
            this.cmd_danhmuc.BackColor = System.Drawing.Color.Transparent;
            this.cmd_danhmuc.BackgroundImage = global::FORM.Properties.Resources.xanh;
            this.cmd_danhmuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_danhmuc.FlatAppearance.BorderSize = 0;
            this.cmd_danhmuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_danhmuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_danhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_danhmuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_danhmuc.Location = new System.Drawing.Point(3, 203);
            this.cmd_danhmuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_danhmuc.Name = "cmd_danhmuc";
            this.cmd_danhmuc.Size = new System.Drawing.Size(189, 75);
            this.cmd_danhmuc.TabIndex = 14;
            this.cmd_danhmuc.Text = "Danh Mục";
            this.cmd_danhmuc.UseVisualStyleBackColor = false;
            this.cmd_danhmuc.Click += new System.EventHandler(this.cmd_danhmuc_Click);
            // 
            // cmd_taiKhoan
            // 
            this.cmd_taiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.cmd_taiKhoan.BackgroundImage = global::FORM.Properties.Resources.xanh;
            this.cmd_taiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_taiKhoan.FlatAppearance.BorderSize = 0;
            this.cmd_taiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_taiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_taiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_taiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_taiKhoan.Location = new System.Drawing.Point(3, 120);
            this.cmd_taiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_taiKhoan.Name = "cmd_taiKhoan";
            this.cmd_taiKhoan.Size = new System.Drawing.Size(189, 75);
            this.cmd_taiKhoan.TabIndex = 15;
            this.cmd_taiKhoan.Text = "Tài Khoản";
            this.cmd_taiKhoan.UseVisualStyleBackColor = false;
            this.cmd_taiKhoan.Click += new System.EventHandler(this.cmd_taiKhoan_Click);
            // 
            // panel_taikhoan
            // 
            this.panel_taikhoan.BackColor = System.Drawing.Color.Transparent;
            this.panel_taikhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_taikhoan.Controls.Add(this.cmd_thongtin);
            this.panel_taikhoan.Controls.Add(this.cmd_dangnhap);
            this.panel_taikhoan.Location = new System.Drawing.Point(3, 372);
            this.panel_taikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_taikhoan.Name = "panel_taikhoan";
            this.panel_taikhoan.Size = new System.Drawing.Size(189, 140);
            this.panel_taikhoan.TabIndex = 26;
            // 
            // cmd_thongtin
            // 
            this.cmd_thongtin.BackColor = System.Drawing.Color.Transparent;
            this.cmd_thongtin.BackgroundImage = global::FORM.Properties.Resources.b1;
            this.cmd_thongtin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_thongtin.FlatAppearance.BorderSize = 0;
            this.cmd_thongtin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_thongtin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_thongtin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_thongtin.Image = global::FORM.Properties.Resources.add_user;
            this.cmd_thongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_thongtin.Location = new System.Drawing.Point(4, 73);
            this.cmd_thongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_thongtin.Name = "cmd_thongtin";
            this.cmd_thongtin.Size = new System.Drawing.Size(176, 53);
            this.cmd_thongtin.TabIndex = 11;
            this.cmd_thongtin.Text = "Thông tin";
            this.cmd_thongtin.UseVisualStyleBackColor = false;
            this.cmd_thongtin.Click += new System.EventHandler(this.cmd_thongtin_Click);
            // 
            // cmd_dangnhap
            // 
            this.cmd_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.cmd_dangnhap.BackgroundImage = global::FORM.Properties.Resources.b1;
            this.cmd_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_dangnhap.FlatAppearance.BorderSize = 0;
            this.cmd_dangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_dangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_dangnhap.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_dangnhap.Image = global::FORM.Properties.Resources.ccc;
            this.cmd_dangnhap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmd_dangnhap.Location = new System.Drawing.Point(4, 18);
            this.cmd_dangnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_dangnhap.Name = "cmd_dangnhap";
            this.cmd_dangnhap.Size = new System.Drawing.Size(176, 57);
            this.cmd_dangnhap.TabIndex = 11;
            this.cmd_dangnhap.Text = "Đăng Nhập ";
            this.cmd_dangnhap.UseVisualStyleBackColor = false;
            this.cmd_dangnhap.Click += new System.EventHandler(this.cmd_dangnhap_Click);
            // 
            // frmQuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1620, 911);
            this.Controls.Add(this.panel_taikhoan);
            this.Controls.Add(this.panel_danhmuc);
            this.Controls.Add(this.panel_chucnang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.cmd_chucnag);
            this.Controls.Add(this.cmd_danhmuc);
            this.Controls.Add(this.cmd_taiKhoan);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLiNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLiNhanVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_chucnang.ResumeLayout(false);
            this.panel_danhmuc.ResumeLayout(false);
            this.panel_taikhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmd_chucnag;
        private System.Windows.Forms.Button cmd_danhmuc;
        private System.Windows.Forms.Button cmd_taiKhoan;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuItem5;
        public System.Windows.Forms.ToolStripMenuItem menuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItem7;
        private System.Windows.Forms.ToolStripMenuItem menuItem8;
        public System.Windows.Forms.ToolStripMenuItem menuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuItem11;
        private System.Windows.Forms.ToolStripMenuItem menuItem13;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel panel_danhmuc;
        private System.Windows.Forms.Button cmd_tienluong;
        private System.Windows.Forms.Button cmd_nhansu;
        public System.Windows.Forms.Panel panel_chucnang;
        private System.Windows.Forms.Button cmd_doimatkhau;
        private System.Windows.Forms.Button cmd_tracuu;
        private System.Windows.Forms.Panel panel_taikhoan;
        private System.Windows.Forms.Button cmd_thongtin;
        private System.Windows.Forms.Button cmd_dangnhap;
    }
}
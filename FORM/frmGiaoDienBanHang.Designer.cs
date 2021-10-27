namespace FORM
{
    partial class frmGiaoDienBanHang
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
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.dtgvTimKiem = new System.Windows.Forms.DataGridView();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cbLoaiSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Controls.Add(this.btnThem);
            this.panelTimKiem.Controls.Add(this.btnTimKiem);
            this.panelTimKiem.Controls.Add(this.dtgvTimKiem);
            this.panelTimKiem.Controls.Add(this.txtTenSach);
            this.panelTimKiem.Controls.Add(this.cbLoaiSach);
            this.panelTimKiem.Controls.Add(this.label2);
            this.panelTimKiem.Controls.Add(this.label1);
            this.panelTimKiem.Location = new System.Drawing.Point(11, 10);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(642, 219);
            this.panelTimKiem.TabIndex = 0;
            // 
            // dtgvTimKiem
            // 
            this.dtgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimKiem.Location = new System.Drawing.Point(34, 56);
            this.dtgvTimKiem.Name = "dtgvTimKiem";
            this.dtgvTimKiem.Size = new System.Drawing.Size(514, 135);
            this.dtgvTimKiem.TabIndex = 3;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(290, 14);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(259, 20);
            this.txtTenSach.TabIndex = 2;
            // 
            // cbLoaiSach
            // 
            this.cbLoaiSach.FormattingEnabled = true;
            this.cbLoaiSach.Location = new System.Drawing.Point(66, 11);
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(160, 21);
            this.cbLoaiSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(554, 57);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(554, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmGiaoDienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTimKiem);
            this.Name = "frmGiaoDienBanHang";
            this.Text = "frmGiaoDienBanHang";
            this.Load += new System.EventHandler(this.frmGiaoDienBanHang_Load);
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiSach;
        private System.Windows.Forms.DataGridView dtgvTimKiem;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
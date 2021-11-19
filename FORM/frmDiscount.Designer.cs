
namespace FORM
{
    partial class frmDiscount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvGiamGia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLuuY = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaGiamGia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMucGiamGia = new System.Windows.Forms.TextBox();
            this.dtNKT = new System.Windows.Forms.DateTimePicker();
            this.dtNBD = new System.Windows.Forms.DateTimePicker();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiamGia
            // 
            this.dgvGiamGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiamGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiamGia.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGiamGia.Location = new System.Drawing.Point(15, 15);
            this.dgvGiamGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGiamGia.Name = "dgvGiamGia";
            this.dgvGiamGia.RowHeadersWidth = 51;
            this.dgvGiamGia.RowTemplate.Height = 24;
            this.dgvGiamGia.Size = new System.Drawing.Size(940, 286);
            this.dgvGiamGia.TabIndex = 0;
            this.dgvGiamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiamGia_CellClick);
            this.dgvGiamGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiamGia_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLuuY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblMaGiamGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtMucGiamGia);
            this.groupBox1.Controls.Add(this.dtNKT);
            this.groupBox1.Controls.Add(this.dtNBD);
            this.groupBox1.Controls.Add(this.txtTieuDe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 310);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(940, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảm giá";
            // 
            // txtLuuY
            // 
            this.txtLuuY.Location = new System.Drawing.Point(650, 113);
            this.txtLuuY.Name = "txtLuuY";
            this.txtLuuY.Size = new System.Drawing.Size(264, 143);
            this.txtLuuY.TabIndex = 16;
            this.txtLuuY.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(646, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lưu ý sử dụng";
            // 
            // lblMaGiamGia
            // 
            this.lblMaGiamGia.AutoSize = true;
            this.lblMaGiamGia.ForeColor = System.Drawing.Color.Black;
            this.lblMaGiamGia.Location = new System.Drawing.Point(575, 232);
            this.lblMaGiamGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaGiamGia.Name = "lblMaGiamGia";
            this.lblMaGiamGia.Size = new System.Drawing.Size(41, 22);
            this.lblMaGiamGia.TabIndex = 14;
            this.lblMaGiamGia.Text = "Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(449, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã giảm giá:";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(520, 273);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 54);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(352, 273);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 54);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(184, 273);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 54);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(16, 273);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 54);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMucGiamGia
            // 
            this.txtMucGiamGia.Location = new System.Drawing.Point(213, 228);
            this.txtMucGiamGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMucGiamGia.Name = "txtMucGiamGia";
            this.txtMucGiamGia.Size = new System.Drawing.Size(222, 29);
            this.txtMucGiamGia.TabIndex = 8;
            // 
            // dtNKT
            // 
            this.dtNKT.Location = new System.Drawing.Point(213, 171);
            this.dtNKT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNKT.Name = "dtNKT";
            this.dtNKT.Size = new System.Drawing.Size(417, 29);
            this.dtNKT.TabIndex = 7;
            // 
            // dtNBD
            // 
            this.dtNBD.Location = new System.Drawing.Point(213, 113);
            this.dtNBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNBD.Name = "dtNBD";
            this.dtNBD.Size = new System.Drawing.Size(417, 29);
            this.dtNBD.TabIndex = 6;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(213, 55);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(417, 29);
            this.txtTieuDe.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mức giảm giá(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề";
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGiamGia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDiscount";
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvGiamGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNKT;
        private System.Windows.Forms.DateTimePicker dtNBD;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMucGiamGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaGiamGia;
        private System.Windows.Forms.RichTextBox txtLuuY;
        private System.Windows.Forms.Label label7;
    }
}
namespace FORM
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label11 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Fuchsia;
            this.label11.Location = new System.Drawing.Point(79, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(858, 47);
            this.label11.TabIndex = 7;
            this.label11.Text = "Thống kê doanh thu theo tháng của cửa hàng sách";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(133, 108);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "VND";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(737, 394);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham.Location = new System.Drawing.Point(440, 547);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(66, 30);
            this.btnXoaSanPham.TabIndex = 13;
            this.btnXoaSanPham.Text = "Reload";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 619);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label11);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnXoaSanPham;
    }
}
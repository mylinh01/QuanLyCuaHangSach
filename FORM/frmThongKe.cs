using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;


namespace FORM
{
    public partial class frmThongKe : Form
    {
        private HoaDonBUS busHoaDon = new HoaDonBUS();
        DataTable dtChartMonth = new DataTable();
        DataTable dtChartMonney = new DataTable();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public frmThongKe()
        {
            InitializeComponent();
        }
        void loadThongKe()
        {
            dt = busHoaDon.countTotalbyMonth().Tables[0];
            // ds = busHoaDon.countTotalbyMonth();
            //MessageBox.Show(ds.);
            //dtChartMonth = ds.Tables["Thang"];
            //dtChartMonney = ds.Tables["Doanhthu"];

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";

            chart1.DataSource = dt;
            chart1.Series["VND"].XValueMember = "Thang";
            chart1.Series["VND"].YValueMembers = "Doanhthu";
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            loadThongKe();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            loadThongKe();
        }
    }
}

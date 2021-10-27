using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using BUS;

namespace FORM
{
    public partial class frmGiaoDienBanHang : Form
    {
        public DataSet ds = new DataSet();
        public LoaiSachBUS bus = new LoaiSachBUS();
        public frmGiaoDienBanHang()
        {
            InitializeComponent();
        }

        private void frmGiaoDienBanHang_Load(object sender, EventArgs e)
        {
            loadCbLoaiSach();
        }
        void loadCbLoaiSach()
        {
            var dss = bus.findLoaiSachByName();
            cbLoaiSach.DataSource = dss.Tables[0];
            cbLoaiSach.DisplayMember = "TenLoaiSach";
    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}

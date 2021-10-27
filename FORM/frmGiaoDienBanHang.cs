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
        public LoaiSachBUS busLoaiSach = new LoaiSachBUS();
        public SachBUS busSach = new SachBUS();
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
            //var dss = busLoaiSach.findLoaiSachByIDAndName();
            cbLoaiSach.DataSource = busLoaiSach.findLoaiSachByIDAndName().Tables[0];
        
            cbLoaiSach.DisplayMember = "TenLoaiSach";
    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTenSach.Text == "")
            {
                //cbLoaiSach.SelectedIndex = cbLoaiSach.find
                int idLoaisach = 0;
                var ds = busSach.findSachByNameLoaiSach(idLoaisach);
                dtgvTimKiem.DataSource = ds.Tables[0];
            }
            else
            {
                string tensach = txtTenSach.Text.Trim();
                var ds = busSach.findSachByName(tensach);
                dtgvTimKiem.DataSource = ds.Tables[0];
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}

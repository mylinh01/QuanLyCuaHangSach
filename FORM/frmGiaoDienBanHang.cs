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
        public NhanVienBUS busNhanVien = new NhanVienBUS();
        public ThanhVienBUS busThanhVien = new ThanhVienBUS();
        public frmGiaoDienBanHang()
        {
            InitializeComponent();
        }

        private void frmGiaoDienBanHang_Load(object sender, EventArgs e)
        {
            lbNgayMua.Text = DateTime.Now.ToString();
            loadCbNhanVien();
            loadCbThanhVien();
        }
        private void loadCbThanhVien()
        {
            cbThanhVien.DataSource = busThanhVien.getNameAndIdThanhVien().Tables[0];
            cbThanhVien.DisplayMember = "HoTen";
        }
        private void loadCbNhanVien()
        {
            cbNhanVien.DataSource = busNhanVien.getNameAndIdNhanVien().Tables[0];
            cbNhanVien.DisplayMember = "HoTen";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

                string tensach = txtTenSach.Text.Trim();
                var ds = busSach.findSachByName(tensach);
                dtgvTimKiem.DataSource = ds.Tables[0];

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

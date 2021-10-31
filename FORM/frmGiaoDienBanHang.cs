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
            txtTenSachHoaDon.Enabled = false;
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
            cbNhanVien.ValueMember = "ID";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

                string tensach = txtTenSach.Text.Trim();
                var ds = busSach.findSachByName(tensach);
                dtgvTimKiem.DataSource = ds.Tables[0];

        }


        private void dtgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTimKiem.Rows[e.RowIndex];
                txtTenSachHoaDon.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            if(cbNhanVien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double sl = Convert.ToInt32(busSach.getSoSachTonKho(txtTenSachHoaDon.Text).Tables[0].Rows[0]["SoLuongTonKho"].ToString());
            if (Convert.ToInt32(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mua lớn hơn số lượng tồn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //string title = busSach.getSoSachTonKho(txtTenSachHoaDon.Text).Tables[0].Rows[0]["SoLuongTonKho"].ToString();
           // string a= (busSach.getSoSachTonKho(txtTenSachHoaDon.Text)).ToString();
            //DialogResult dialogResult = MessageBox.Show(title);
            addData(txtTenSachHoaDon.Text, txtSoLuong.Text, (100).ToString());

        }
        private void addData(string name, string soluong, string thanhtien)
        {
            String[] row = { name, soluong, thanhtien };
            dtgvHoaDon.Rows.Add(row);
        }
        private void cbNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbNhanVien.SelectedValue.ToString());
        }
    }
}

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
        public GiamGiaBUS busGiamGia = new GiamGiaBUS();
        public HoaDonBUS busHoaDon = new HoaDonBUS();
        private int id_nv;
        private int id_tv;
        private int idgg;
        public frmGiaoDienBanHang()
        {
            InitializeComponent();
        }

        private void frmGiaoDienBanHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadCbThanhVien()
        {
            cbThanhVien.DataSource = busThanhVien.getNameAndIdThanhVien().Tables[0];
            cbThanhVien.DisplayMember = "HoTen";
            cbThanhVien.ValueMember = "ID";

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
            for(int i=0;i<dtgvHoaDon.RowCount; i++)
            {
                var Row = dtgvHoaDon.Rows[i];
                string name = Row.Cells[0].Value.ToString();
                if(name == txtTenSachHoaDon.Text)
                {
                    MessageBox.Show("Sách này đã có trong hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            addData(txtTenSachHoaDon.Text, txtSoLuong.Text, (100).ToString());
            totalMoney();
            tinhThanhTien();
        }

        private void addData(string name, string soluong, string thanhtien)
        {
            int sl = Convert.ToInt32(txtSoLuong.Text);
            int gia1cuon = Convert.ToInt32(busSach.getGiaBanByName(txtTenSachHoaDon.Text).Tables[0].Rows[0]["GiaBan"].ToString());
            thanhtien = (sl * gia1cuon).ToString();
            String[] row = { name, soluong, thanhtien };
            dtgvHoaDon.Rows.Add(row);
        }

        private void totalMoney()
        {
            double sum = 0;
            for (int i = 0; i < dtgvHoaDon.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dtgvHoaDon.Rows[i].Cells[2].Value);
            }
            lbTongTien.Text = sum.ToString();
        }

        private void tinhThanhTien()
        {
            double sum = 0;
            double tongtin = Convert.ToDouble(lbTongTien.Text);
            double giamgia = Convert.ToDouble(lbGiamGia.Text);
            sum = tongtin - (double)(giamgia * tongtin) / 100;
            lbThanhTien.Text = sum.ToString();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            int index = dtgvHoaDon.CurrentCell.RowIndex;
            dtgvHoaDon.Rows.RemoveAt(index);
            totalMoney();
            tinhThanhTien();
        }

        public void loadData()
        {
            //lbNgayMua.Text = DateTime.Now.ToString("M/d/yyyy");
            lbNgayMua.Text = DateTime.Now.ToString();
            loadCbNhanVien();
            loadCbThanhVien();
            txtTenSachHoaDon.Enabled = false;
            txtSoLuong.Text = "1";
            lbTongTien.Text = "0";
            lbGiamGia.Text = "0";
            lbThanhTien.Text = "0";
            txtTenSach.Clear();
            txtTenSachHoaDon.Clear();
            dtgvHoaDon.AllowUserToAddRows = false;
            dtgvTimKiem.AllowUserToAddRows = false;
            //cbThanhVien.SelectedItem =null;
            //cbNhanVien.SelectedItem = null;
            dtgvHoaDon.Rows.Clear();
            //cbThanhVien.SelectedIndex = 0;
            tinhGiamGia();
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void tinhGiamGia()
        {
            double giamgia = 0;
            string name = cbThanhVien.SelectedValue.ToString();
            if (name != "System.Data.DataRowView")
            {
                id_tv = Convert.ToInt32(cbThanhVien.GetItemText(cbThanhVien.SelectedValue.ToString()));
                double ggtv = Convert.ToInt32(busThanhVien.getGiamGiaByIDThanhVien(id_tv).Tables[0].Rows[0]["MucUuDai"].ToString());
                giamgia += ggtv;
            }
            double ggngay = 0;
            DateTime time = DateTime.Now;
            ds =  busGiamGia.getGiamGiaByNgay(time);
            ggngay = Convert.ToDouble( ds.Tables[0].Rows[0]["PhanTramGG"]);
            // lấy id của mã giảm giá để lưu xuống database
            idgg = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
            //
            giamgia += ggngay;
            if (giamgia > 100) giamgia = 100;
            lbGiamGia.Text = giamgia.ToString();
        }

        private void cbNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbNhanVien.SelectedValue.ToString());
            string name = cbNhanVien.SelectedValue.ToString();
            if (name != "System.Data.DataRowView")
            {
                // lấy id của nhân viên  để lưu
                id_nv = Convert.ToInt32(cbNhanVien.SelectedValue.ToString());
            }
           

        }
        private void cbThanhVien_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbThanhVien.SelectedValue.ToString());

            string name = cbThanhVien.SelectedValue.ToString();
            if (name != "System.Data.DataRowView")
            {
                cbThanhVien.ValueMember = "ID";
                id_tv = int.Parse(cbThanhVien.SelectedValue.ToString());
            }


        }
        private void cbThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhGiamGia();
            string name = cbThanhVien.SelectedValue.ToString();
            if (name != "System.Data.DataRowView")
            {
                tinhThanhTien();
            }
        }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            luuHoaDon(id_nv, id_tv, idgg, Convert.ToInt64(lbThanhTien.Text));
            luuChiTietHoaDon();
        }
        private void luuHoaDon(int idnv, int idtv, int idgg, long thanhtien)
        {
            string err = "";
            DateTime ngaytao = DateTime.Now;
            DateTime ngayupdate = DateTime.Now;
            if (!busHoaDon.insertHoaDon(ref err, idnv, idtv, idgg, ngaytao, thanhtien,ngaytao,ngayupdate))
                MessageBox.Show(err);
           // else DataBind();
        }
        private void luuChiTietHoaDon()
        {

        }
    }
}

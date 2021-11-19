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

namespace FORM
{
    public partial class frmInvoice : Form
    {
        private HoaDonBUS hoaDonBus = new HoaDonBUS();
        private ChiTietHoaDonBUS cthdBus = new ChiTietHoaDonBUS();
        private NhanVienBUS nhanVienBus = new NhanVienBUS();
        private ThanhVienBUS thanhVienBus = new ThanhVienBUS();
        private PhieuNhapBUS phieuNhapBus = new PhieuNhapBUS();
        private ChiTietPhieuNhapBUS ctpnBus = new ChiTietPhieuNhapBUS();
        private SachBUS sachBus = new SachBUS();
        private NXBBUS nxbBus = new NXBBUS();
        private long idnv;
        private long idnxb;
        private long idpn;


        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            loadDataHoadon();
            loadDataPhieuNhap();
        }
        /*******************************************************************************************************************************/
        /*                                                      -----Hóa đơn-----                                                      */
        /*******************************************************************************************************************************/
        private void loadCbNhanVienHD()
        {
            cbNVHD.DataSource = nhanVienBus.getNhanVien().Tables[0];
            cbNVHD.DisplayMember = "HoTen";
            cbNVHD.ValueMember = "ID";
        }
        private void loadCbThanhVien()
        {
            cbTV.DataSource = thanhVienBus.getThanhVien().Tables[0];
            cbTV.DisplayMember = "HoTen";
            cbTV.ValueMember = "ID";
        }
        private void loadCbSdtThanhVien()
        {
            cbSDT.DataSource = thanhVienBus.getThanhVien().Tables[0];
            cbSDT.DisplayMember = "SDT";
            cbSDT.ValueMember = "ID";
        }
       
        private void loadDataHoadon()
        {
            dgvHD.DataSource = hoaDonBus.getHoaDon().Tables[0];
            loadCbNhanVienHD();
            loadCbThanhVien();
            loadCbSdtThanhVien();
            resetTextHD();
        }
        private void resetTextHD()
        {
            txtIDHD.ResetText();
            cbNVHD.ResetText();
            cbTV.ResetText();
            cbSDT.ResetText();
            txtTienHD.ResetText();
            dtpNgayNhap.Value = DateTime.Now;
        }
        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = e.RowIndex;
            txtIDHD.Text = dgvHD.Rows[row].Cells[0].Value.ToString();
       
            cbNVHD.SelectedValue = dgvHD.Rows[row].Cells[1].Value.ToString();
            cbTV.SelectedValue = dgvHD.Rows[row].Cells[2].Value.ToString();
            cbSDT.SelectedValue = dgvHD.Rows[row].Cells[2].Value.ToString();
            dtpNgayMua.Value = Convert.ToDateTime(dgvHD.Rows[row].Cells[4].Value.ToString());
            txtTienHD.Text = dgvHD.Rows[row].Cells[5].Value.ToString();
            
            
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            long id = long.Parse(txtIDHD.Text);
            var ds = cthdBus.xemCTHD(id);
            dgvCTHD.DataSource = ds.Tables[0];
            txtGG.Text = dgvCTHD.CurrentRow.Cells["PTGG"].Value.ToString() + "%";
            txtMucUD.Text = dgvCTHD.CurrentRow.Cells["MucUD"].Value.ToString() + "%";
            /*
            cbNVHD.SelectedValue = dgvHD.CurrentRow.Cells[1].Value.ToString();
            cbTV.SelectedValue = dgvHD.CurrentRow.Cells[2].Value.ToString();
            cbSDT.SelectedValue = dgvHD.CurrentRow.Cells[2].Value.ToString();
            dtpNgayMua.Value = Convert.ToDateTime(dgvHD.CurrentRow.Cells[4].Value.ToString());
            txtTienHD.Text = dgvHD.CurrentRow.Cells[5].Value.ToString();
            */
        }


        /********************************************************************************************************************************/
        /*                                                     -----Phiếu nhập-----                                                     */
        /********************************************************************************************************************************/

        private void loadCbNhanVienPN()
        {
            cbNVPN.DataSource = nhanVienBus.getNhanVien().Tables[0];
            cbNVPN.DisplayMember = "HoTen";
            cbNVPN.ValueMember = "ID";
        }
        private void loadCbNXB()
        {
            cbNXB.DataSource = nxbBus.getNXB().Tables[0];
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "ID";
        }
        private void loadCbSdtNXB()
        {
            cbSdtNXB.DataSource = nxbBus.getNXB().Tables[0];
            cbSdtNXB.DisplayMember = "SDT";
            cbSdtNXB.ValueMember = "ID";
        }
        private void loadDataPhieuNhap()
        {
            dgvPN.DataSource = phieuNhapBus.getPhieuNhap().Tables[0];
            loadCbNhanVienPN();
            loadCbNXB();
            loadCbSdtNXB();
            resetTextPN();
            
        }
        private void resetTextPN()
        {
            txtIDPN.ResetText();
            cbNVPN.ResetText();
            cbNXB.ResetText();
            cbTenSach.ResetText();
            cbSdtNXB.ResetText();
            txtTienPN.ResetText();
            dtpNgayNhap.Value = DateTime.Now;
            txtSoLuong.ResetText();
            txtGiaNhap.ResetText();
            dgvCTPN.DataSource = null;
        }
        private void btnXemCTPN_Click(object sender, EventArgs e)
        {
            long id = long.Parse(txtIDPN.Text);
            var ds = ctpnBus.xemCTPN(id);
            dgvCTPN.DataSource = ds.Tables[0];
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = e.RowIndex;
            txtIDPN.Text = dgvPN.Rows[row].Cells[0].Value.ToString();
            cbNVPN.SelectedValue = dgvPN.Rows[row].Cells[1].Value.ToString();
            cbNXB.SelectedValue = dgvPN.Rows[row].Cells[2].Value.ToString();
            cbSdtNXB.SelectedValue = dgvPN.Rows[row].Cells[2].Value.ToString();
            dtpNgayNhap.Value = Convert.ToDateTime(dgvPN.Rows[row].Cells[3].Value.ToString());
            txtTienPN.Text = dgvPN.Rows[row].Cells[4].Value.ToString();
            
        }
        private void addData(string ten, string soluong, string gianhap, string thanhtien)
        {
            int sl = int.Parse(txtSoLuong.Text);
            long gn = long.Parse(txtGiaNhap.Text);
            thanhtien = (sl * gn).ToString();
            String[] row = { ten, soluong, gianhap, thanhtien };
            dgvCTPN.Rows.Add(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idnv = long.Parse(cbNVPN.SelectedValue.ToString());
            DateTime ngaynhap = DateTime.Parse(dtpNgayNhap.Text);
            long thanhtien = long.Parse(txtTienPN.Text);
            try
            {
                luuPhieuNhap(idnv, idnxb, ngaynhap , thanhtien );
                idpn = long.Parse(phieuNhapBus.getLastRowInPhieuNhap().Tables[0].Rows[0]["ID"].ToString());
                luuChiTietPhieuNhap(idpn);
                MessageBox.Show("Lưu phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataPhieuNhap();
            }
            catch (Exception)
            {
                //throw ee;
                MessageBox.Show("Lưu phiếu nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetTextPN();
            grbSach.Enabled = false;
            grbThem.Enabled = false;
            cbNVPN.Enabled = false;
            cbNXB.Enabled = false;
            loadDataPhieuNhap();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgvCTPN.RowCount; i++)
            {
                var Row = dgvCTPN.Rows[i];
                string name = Row.Cells[0].Value.ToString();
                if (name == cbTenSach.Text)
                {
                    MessageBox.Show("Sách này đã có trong phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            addData(cbTenSach.Text, txtSoLuong.Text, txtGiaNhap.Text, (100).ToString());
            tinhThanhTien();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvCTPN.CurrentCell.RowIndex;
                dgvCTPN.Rows.RemoveAt(index);
                tinhThanhTien();
            }
            catch
            {
                MessageBox.Show("Không có sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void tinhThanhTien()
        {
            long sum = 0;
            for (int i = 0; i < dgvCTPN.Rows.Count; ++i)
            {
                    sum += Convert.ToInt64(dgvCTPN.Rows[i].Cells[3].Value);
            }
            txtTienPN.Text = sum.ToString();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            loadDataPhieuNhap();
        }
        private void luuPhieuNhap(long idnv, long idnxb, DateTime ngaynhap, long thanhtien)
        {
            string err = "";
            if (!phieuNhapBus.insertPhieuNhap(ref err, idnv, idnxb, ngaynhap, thanhtien, DateTime.Now, DateTime.Now))
                MessageBox.Show(err);
        }
        private void luuChiTietPhieuNhap(long idpn)
        {
            for (int i = 0; i < dgvCTPN.Rows.Count; i++)
                {
                    string err = "";
                    string tensach = dgvCTPN.Rows[i].Cells[0].Value.ToString();
                    int soluong = Convert.ToInt32(dgvCTPN.Rows[i].Cells[1].Value.ToString());
                    long idsach = Convert.ToInt64(sachBus.getIDSachByName(tensach).Tables[0].Rows[0]["ID"].ToString());
                    long gianhap = Convert.ToInt64(dgvCTPN.Rows[i].Cells[2].Value.ToString());
                    if (!ctpnBus.insertChiTietPhieuNhap(ref err, idpn, idsach, soluong, gianhap, DateTime.Now, DateTime.Now))
                        MessageBox.Show(err);
                }
           
        }
        private void cbTenNXB_SelectedValueChanged(object sender, EventArgs e)
        {
            
            string name = cbNXB.SelectedValue.ToString();
            if (name != "System.Data.DataRowView")
            {
                cbNXB.ValueMember = "ID";
                idnxb = long.Parse(cbNXB.SelectedValue.ToString());
            }
            cbTenSach.DataSource = sachBus.getSachByIDNXB(idnxb).Tables[0];
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "ID";
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            resetTextPN();
            grbSach.Enabled = true;
            grbThem.Enabled = true;
            cbNVPN.Enabled = true;
            cbNXB.Enabled = true;
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {

            DateTime ngaymua = DateTime.Parse(dtpNgayMua.Text);
            dgvHD.DataSource = hoaDonBus.findHoaDon(ngaymua).Tables[0];
        }

        private void btnTimPN_Click(object sender, EventArgs e)
        {
            DateTime ngaynhap = DateTime.Parse(dtpNgayNhap.Text);
            dgvPN.DataSource = phieuNhapBus.findPhieuNhap(ngaynhap).Tables[0];
        }
    }
}

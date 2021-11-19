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
    public partial class frmBookstore : Form
    {
        public frmBookstore()
        {
            InitializeComponent();
        }
        private void frmBookstore_Load(object sender, EventArgs e)
        {
            loadDataSach();
            loadDataTacGia();
            loadDataLoaiSach();
            loadDataNXB();
            initLog("Load form: " + DateTime.Now);
            initLogLS("Load form: " + DateTime.Now);
            initLogTG("Load form: " + DateTime.Now);
            initLogNXB("Load form: " + DateTime.Now);
        }
        private SachBUS sachBus = new SachBUS();
        private LoaiSachBUS loaiSachBus = new LoaiSachBUS();
        private TacGiaBUS tacGiaBus = new TacGiaBUS();
        private NXBBUS nxbBus = new NXBBUS();
        int isSave = 0;
        private void loadCbTacGia()
        {
            cbTacGia.DataSource = tacGiaBus.getTacGia().Tables[0];
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "ID";
        }
        private void loadCbLoaiSach()
        {
            cbLoaiSach.DataSource = loaiSachBus.getLoaiSach().Tables[0];
            cbLoaiSach.DisplayMember = "TenLoaiSach";
            cbLoaiSach.ValueMember = "ID";
        }
        private void loadCbNXB()
        {
            cbNXB.DataSource = nxbBus.getNXB().Tables[0];
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "ID";
        }

        /********************************************************************************************************************************/
        /*                                                      -----Sách-----                                                          */
        /********************************************************************************************************************************/
        private void loadDataSach()
        {
            dgvSach.DataSource = sachBus.getSach().Tables[0];
            loadCbTacGia();
            loadCbLoaiSach();
            loadCbNXB();
            ResetTextSach();
        }


        private void enableOrDisableButtonSach(bool isEnable)
        {
            foreach (Button btn in groupBoxSach.Controls)
            {
                if (btn != btnSaveSach && btn != btnCancelSach)
                {
                    btn.Enabled = isEnable;
                }
            }
            btnSaveSach.Enabled = !isEnable;
            btnCancelSach.Enabled = !isEnable;
        }
        private void enableOrDisableTextBoxSach(bool isEnable)
        {
            txtTenSach.Enabled = isEnable;
            txtGia.Enabled = isEnable;
            //txtSoLuong.Enabled = isEnable;
            cbLoaiSach.Enabled = isEnable;
            cbTacGia.Enabled = isEnable;
            cbNXB.Enabled = isEnable;
        }
        private void ResetTextSach()
        {
            txtIDSach.ResetText();
            txtTenSach.ResetText();
            cbLoaiSach.ResetText();
            cbNXB.ResetText();
            cbTacGia.ResetText();
            txtGia.ResetText();
            txtSoLuong.Text = "0";
            txtTenSach.Clear();
            
        }
        private void btnAddSach_Click(object sender, EventArgs e)
        {
            ResetTextSach();
            enableOrDisableButtonSach(false);
            enableOrDisableTextBoxSach(true);
            isSave = 1;
            initLog("Đang thêm...: " + DateTime.Now);
        }

        private void btnDeleteSach_Click(object sender, EventArgs e)
        {
            long id = long.Parse(txtIDSach.Text);
            string err = "";
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn xóa ID " + id + "?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);            
            if (traloi == DialogResult.Yes)
            {
                sachBus.deleteSach(ref err, id);
                initLog("Đã xóa thành công: " + DateTime.Now);
            }
            else
            {
                initLog("Đã hủy bỏ thao tác thực hiện: " + DateTime.Now);
            }
            loadDataSach();
        }

        private void btnUpdateSach_Click(object sender, EventArgs e)
        {
            enableOrDisableButtonSach(false);
            enableOrDisableTextBoxSach(true);
            isSave = -1;
            initLog("Đang cập nhật...: " + DateTime.Now);
        }

        private void btnSaveSach_Click(object sender, EventArgs e)
        {
            string ten = txtTenSach.Text;
            long idLS = long.Parse(cbLoaiSach.SelectedValue.ToString());
            long idNXB = long.Parse(cbNXB.SelectedValue.ToString());
            long idTG = long.Parse(cbTacGia.SelectedValue.ToString());
            long giaBan = long.Parse(txtGia.Text);
            int soluong = int.Parse(txtSoLuong.Text);
            if (isSave == 1)
            {
                string err = "";
                if (!sachBus.insertSach(ref err, ten, idLS, idNXB, idTG, giaBan, soluong, DateTime.Now, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLog("Thêm thất bại: " + DateTime.Now);
                    return;
                }
                initLog("Đã thêm thành công: " + DateTime.Now);
            }
            else if (isSave == -1)
            {
                long id = long.Parse(txtIDSach.Text);
                string err = "";
                if (!sachBus.updateSach(ref err, id, ten, idLS, idNXB, idTG, giaBan, soluong, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLog("Chỉnh sửa thất bại: " + DateTime.Now);
                    return;
                }
                initLog("Đã chỉnh sửa thành công: " + DateTime.Now);
            }
            isSave = 0;
            ResetTextSach();
            enableOrDisableButtonSach(true);
            enableOrDisableTextBoxSach(false);
            loadDataSach();
        }
        private void btnCancelSach_Click(object sender, EventArgs e)
        {
            ResetTextSach();
            enableOrDisableButtonSach(true);
            enableOrDisableTextBoxSach(false);
            isSave = 0;
            initLog("Đã hủy thao tác đang thực hiện: " + DateTime.Now);
            loadDataSach();
        }
        private void btnReloadSach_Click(object sender, EventArgs e)
        {
            loadDataSach();
            initLog("Reload: " + DateTime.Now);
        }
        private void initLog(string log)
        {
            log += "\r\n";
            txtLog.Text = log + txtLog.Text;
        }


        /********************************************************************************************************************************/
        /*                                                     -----Loại sách-----                                                      */
        /********************************************************************************************************************************/

        private void loadDataLoaiSach()
        {
            dgvLoaiSach.DataSource = loaiSachBus.getLoaiSach().Tables[0];
          
            dgvLoaiSach.Columns[0].HeaderText = "ID";
            dgvLoaiSach.Columns[1].HeaderText = "Tên thể loại";
            dgvLoaiSach.Columns[2].HeaderText = "Ngày tạo";
            dgvLoaiSach.Columns[3].HeaderText = "Ngày update";

            dgvLoaiSach.Columns[0].Width = 100;
            dgvLoaiSach.Columns[1].Width = 287;
            dgvLoaiSach.Columns[2].Width = 150;
            dgvLoaiSach.Columns[3].Width = 150;
        }
        private void enableOrDisableButtonLoaiSach(bool isEnable)
        {
            foreach (Button btn in groupBoxLS.Controls)
            {
                if (btn != btnSaveLoaiSach && btn != btnCancelLoaiSach)
                {
                    btn.Enabled = isEnable;
                }
            }
            btnSaveLoaiSach.Enabled = !isEnable;
            btnCancelLoaiSach.Enabled = !isEnable;
        }
        private void ResetTextLoaiSach()
        {
            txtIDLS.ResetText();
            txtTenLS.ResetText();
        }
        private void btnAddLoaiSach_Click(object sender, EventArgs e)
        {
            ResetTextLoaiSach();
            enableOrDisableButtonLoaiSach(false);
            txtTenLS.Enabled = true;
            isSave = 1;
            initLogLS("Đang thêm...: " + DateTime.Now);
        }

        private void btnDeleteLoaiSach_Click(object sender, EventArgs e)
        {
            long id = long.Parse(txtIDLS.Text);
            string err = "";
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn xóa ID " + id + "?", "Trả lời",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                loaiSachBus.deleteLoaiSach(ref err, id);
                initLogLS("Đã xóa thành công: " + DateTime.Now);
            }
            else
            {
                initLogLS("Đã hủy bỏ thao tác thực hiện: " + DateTime.Now);
            }
            loadDataLoaiSach();
        }
        private void btnEditLoaiSach_Click(object sender, EventArgs e)
        {
            enableOrDisableButtonLoaiSach(false);
            txtTenLS.Enabled = true;
            isSave = -1;
            initLogLS("Đang cập nhật...: " + DateTime.Now);
        }
        private void btnSaveLoaiSach_Click(object sender, EventArgs e)
        {
            string ten = txtTenLS.Text;
            if (isSave == 1)
            {
                string err = "";
                if (!loaiSachBus.insertLoaiSach(ref err, ten, DateTime.Now, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLogLS("Thêm thất bại: " + DateTime.Now);
                    return;
                }
                initLogLS("Đã thêm thành công: " + DateTime.Now);
            }
            else if (isSave == -1)
            {
                long id = long.Parse(txtIDLS.Text);
                string err = "";
                if (!loaiSachBus.updateLoaiSach(ref err, id, ten, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLogLS("Chỉnh sửa thất bại: " + DateTime.Now);
                    return;
                }
                initLogLS("Đã chỉnh sửa thành công: " + DateTime.Now);
            }
            isSave = 0;
            ResetTextLoaiSach();
            enableOrDisableButtonLoaiSach(true);
            txtTenLS.Enabled = false;
            loadDataLoaiSach();
        }
        private void btnCancelLoaiSach_Click(object sender, EventArgs e)
        {
            ResetTextLoaiSach();
            enableOrDisableButtonLoaiSach(true);
            txtTenLS.Enabled = false;
            isSave = 0;
            initLog("Đã hủy thao tác đang thực hiện: " + DateTime.Now);
            loadDataLoaiSach();
        }
        private void btnReloadLoaiSach_Click(object sender, EventArgs e)
        {
            loadDataLoaiSach();
            initLogLS("Reload: " + DateTime.Now);
        }
        private void initLogLS(string log)
        {
            log += "\r\n";
            txtLogLS.Text = log + txtLogLS.Text;
        }
        /********************************************************************************************************************************/
        /*                                                      -----Tác giả-----                                                       */
        /********************************************************************************************************************************/
        private void loadDataTacGia()
        {
            dgvTacGia.DataSource = tacGiaBus.getTacGia().Tables[0];

            dgvTacGia.Columns[0].HeaderText = "ID";
            dgvTacGia.Columns[1].HeaderText = "Tên tác giả";
            dgvTacGia.Columns[2].HeaderText = "Ngày tạo";
            dgvTacGia.Columns[3].HeaderText = "Ngày update";

            dgvTacGia.Columns[0].Width = 100;
            dgvTacGia.Columns[1].Width = 287;
            dgvTacGia.Columns[2].Width = 150;
            dgvTacGia.Columns[3].Width = 150;

        }
        private void enableOrDisableButtonTacGia(bool isEnable)
        {
            foreach (Button btn in groupBoxTG.Controls)
            {
                if (btn != btnSaveLoaiSach && btn != btnCancelLoaiSach)
                {
                    btn.Enabled = isEnable;
                }
            }
            btnSaveTacGia.Enabled = !isEnable;
            btnCancelTacGia.Enabled = !isEnable;
        }
        
        private void initLogTG(string log)
        {
            log += "\r\n";
            txtLogTG.Text = log + txtLogTG.Text;
        }
        private void resetTextTacGia()
        {
            txtIDTG.ResetText();
            txtTenTG.ResetText();
        }
        
        private void btnAddTacGia_Click(object sender, EventArgs e)
        {                     
            resetTextTacGia();
            enableOrDisableButtonTacGia(false);
            txtTenTG.Enabled = true;
            isSave = 1;
            initLogTG("Đang thêm...: " + DateTime.Now);
        }

        private void btnDeleteTacGia_Click(object sender, EventArgs e)
        {
            long id = long.Parse(txtIDTG.Text);
            string err = "";
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn xóa ID " + id + "?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                tacGiaBus.deleteTacGia(ref err, id);
                initLogTG("Đã xóa thành công: " + DateTime.Now);
            }
            else
            {
                initLogTG("Đã hủy bỏ thao tác thực hiện: " + DateTime.Now);
            }
            loadDataTacGia();
        }

        private void btnEditTacGia_Click(object sender, EventArgs e)
        {
            enableOrDisableButtonTacGia(false);
            txtTenTG.Enabled = true;
            isSave = -1;
            initLogTG("Đang cập nhật...: " + DateTime.Now);
        }
        private void btnSaveTacGia_Click(object sender, EventArgs e)
        {
            string ten = txtTenTG.Text;
            if (isSave == 1)
            {
                string err = "";
                if (!tacGiaBus.insertTacGia(ref err, ten, DateTime.Now, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLogTG("Thêm thất bại: " + DateTime.Now);
                    return;
                }
                initLogTG("Đã thêm thành công: " + DateTime.Now);
            }
            else if (isSave == -1)
            {
                long id = long.Parse(txtIDTG.Text);
                string err = "";
                if (!tacGiaBus.updateTacGia(ref err, id, ten, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLogTG("Chỉnh sửa thất bại: " + DateTime.Now);
                    return;
                }
                initLogTG("Đã chỉnh sửa thành công: " + DateTime.Now);
            }
            isSave = 0;
            resetTextTacGia();
            enableOrDisableButtonTacGia(true);
            txtTenTG.Enabled = false;
            loadDataTacGia();
        }
        private void btnCancelTacGia_Click(object sender, EventArgs e)
        {
            resetTextTacGia();
            enableOrDisableButtonTacGia(false);
            txtTenTG.Enabled = true;
            isSave = 0;
            initLogTG("Đã hủy thao tác đang thực hiện: " + DateTime.Now);
            loadDataTacGia();
        }
        private void btnReloadTacGia_Click(object sender, EventArgs e)
        {
            loadDataTacGia();
            initLogTG("Reload: " + DateTime.Now);
        }

        /*********************************************************************************************************************************/
        /*                                                    -----Nhà xuất bản-----                                                     */
        /*********************************************************************************************************************************/
        private void loadDataNXB()
        {
            dgvNXB.DataSource = nxbBus.getNXB().Tables[0];

            dgvNXB.Columns[0].HeaderText = "ID";
            dgvNXB.Columns[1].HeaderText = "Tên NXB";
            dgvNXB.Columns[2].HeaderText = "Địa chỉ";
            dgvNXB.Columns[3].HeaderText = "SĐT";
            dgvNXB.Columns[4].HeaderText = "Ngày tạo";
            dgvNXB.Columns[5].HeaderText = "Ngày update";

            dgvNXB.Columns[0].Width = 67;
            dgvNXB.Columns[1].Width = 180;
            dgvNXB.Columns[2].Width = 180;
            dgvNXB.Columns[3].Width = 120;
            dgvNXB.Columns[4].Width = 70;
            dgvNXB.Columns[5].Width = 70;
        }

        private void enableOrDisableButtonNXB(bool isEnable)
        {
            foreach (Button btn in groupBoxNXB.Controls)
            {
                if (btn != btnSaveLoaiSach && btn != btnCancelLoaiSach)
                {
                    btn.Enabled = isEnable;
                }
            }
            btnSaveNXB.Enabled = !isEnable;
            btnCancelNXB.Enabled = !isEnable;
        }
        private void initLogNXB(string log)
        {
            log += "\r\n";
            txtLogNXB.Text = log + txtLogNXB.Text;
        }
        private void resetTextNXB()
        {
            txtIDNXB.ResetText();
            txtTenNXB.ResetText();
            txtDiaChi.ResetText();
            txtSdt.ResetText();
        }
        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            resetTextNXB();
            enableOrDisableButtonNXB(false);
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSdt.Enabled = true;
            isSave = 1;
            initLogNXB("Đang thêm...: " + DateTime.Now);
        }

        private void btnDeleteNXB_Click(object sender, EventArgs e)
        {
            long id = long.Parse(txtIDNXB.Text);
            string err = "";
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn xóa ID " + id + "?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.Yes)
            {
                nxbBus.deleteNXB(ref err, id);
                initLogNXB("Đã xóa thành công: " + DateTime.Now);
            }
            else
            {
                initLogNXB("Đã hủy bỏ thao tác thực hiện: " + DateTime.Now);
            }
            loadDataNXB();
        }

        private void btnEditNXB_Click(object sender, EventArgs e)
        {
            enableOrDisableButtonNXB(false);
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSdt.Enabled = true;
            isSave = -1;
            initLogNXB("Đang cập nhật...: " + DateTime.Now);
        }
        private void btnSaveNXB_Click(object sender, EventArgs e)
        {
            string ten = txtTenNXB.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSdt.Text;
            if (isSave == 1)
            {
                string err = "";
                if (!nxbBus.insertNXB(ref err, ten, diachi, sdt, DateTime.Now, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLogNXB("Thêm thất bại: " + DateTime.Now);
                    return;
                }
                initLogNXB("Đã thêm thành công: " + DateTime.Now);
            }
            else if (isSave == -1)
            {
                long id = long.Parse(txtIDNXB.Text);
                string err = "";
                if (!nxbBus.updateNXB(ref err, id, ten, diachi, sdt, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLogTG("Chỉnh sửa thất bại: " + DateTime.Now);
                    return;
                }
                initLogNXB("Đã chỉnh sửa thành công: " + DateTime.Now);
            }
            isSave = 0;
            resetTextNXB();
            enableOrDisableButtonNXB(true);
            txtTenTG.Enabled = false;
            loadDataNXB();
        }
        private void btnCancelNXB_Click(object sender, EventArgs e)
        {
            resetTextNXB();
            enableOrDisableButtonNXB(true);
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSdt.Enabled = true;
            isSave = 0;
            initLogNXB("Đã hủy thao tác đang thực hiện: " + DateTime.Now);
            loadDataNXB();
        }

        private void btnReloadNXB_Click(object sender, EventArgs e)
        {
            loadDataNXB();
            initLogNXB("Reload: " + DateTime.Now);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimSach.Text.Trim();
            dgvSach.DataSource = sachBus.findSach(keyword).Tables[0];

        }

        private void dgvLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDLS.Text = dgvLoaiSach.CurrentRow.Cells[0].Value.ToString();
            txtTenLS.Text = dgvLoaiSach.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDTG.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
            txtTenTG.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDNXB.Text = dgvNXB.CurrentRow.Cells[0].Value.ToString();
            txtTenNXB.Text = dgvNXB.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNXB.CurrentRow.Cells[2].Value.ToString();
            txtSdt.Text = dgvNXB.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtIDSach.Text = dgvSach.Rows[row].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[row].Cells[1].Value.ToString();
            cbTacGia.Text = dgvSach.Rows[row].Cells[2].Value.ToString();
            cbLoaiSach.Text = dgvSach.Rows[row].Cells[3].Value.ToString();
            cbNXB.Text = dgvSach.Rows[row].Cells[4].Value.ToString();
            txtGia.Text = dgvSach.Rows[row].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvSach.Rows[row].Cells[6].Value.ToString();
        }
    }

}

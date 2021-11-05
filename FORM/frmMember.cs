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
    public partial class frmMember : Form
    {

        ThanhVienBUS thanhVienBUS = new ThanhVienBUS();
        LoaiThanhVienBUS loaiThanhVienBUS = new LoaiThanhVienBUS();
        int isSave = 0;
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            reload();
            initLog("Load form: " + DateTime.Now);
        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            bindingTxtWhenOnlick(row);
        }

        private void bindingTxtWhenOnlick(int row)
        {
            txtID.Text = dgvThanhVien.Rows[row].Cells[0].Value.ToString();
            txtName.Text = dgvThanhVien.Rows[row].Cells[1].Value.ToString();
            txtAddress.Text = dgvThanhVien.Rows[row].Cells[2].Value.ToString();
            txtPhNo.Text = dgvThanhVien.Rows[row].Cells[3].Value.ToString();
            cbxTypeMember.SelectedValue = dgvThanhVien.Rows[row].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetTextAll();
            enableOrDisableButton(false);
            enableOrDisableTextBox(true);
            isSave = 1;
            initLog("Đang thêm thành viên...: " + DateTime.Now);
        }

        private void enableOrDisableButton(bool isEnable)
        {
            foreach (Button btn in pnlControl.Controls)
            {
                if (btn != btnSave && btn != btnCancel)
                {
                    btn.Enabled = isEnable;
                }
            }
            btnSave.Enabled = !isEnable;
            btnCancel.Enabled = !isEnable;
        }

        private void enableOrDisableTextBox(bool isEnable)
        {
            txtAddress.Enabled = isEnable;
            txtName.Enabled = isEnable;
            txtPhNo.Enabled = isEnable;
            cbxTypeMember.Enabled = isEnable;
        }

        private void ResetTextAll()
        {
            txtID.ResetText();
            txtName.ResetText();
            txtAddress.ResetText();
            txtPhNo.ResetText();
            cbxTypeMember.SelectedValue = "1";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phNo = txtPhNo.Text;
            int idTypeMember = int.Parse(cbxTypeMember.SelectedValue.ToString());
            if (isSave == 1)
            {
                string err = "";
                if (!thanhVienBUS.insertThanhVien(ref err, name, address, phNo, idTypeMember, DateTime.Now, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLog("Thêm thành viên thất bại: " + DateTime.Now);
                    return;
                }
                initLog("Đã thêm thành viên: " + DateTime.Now);
            }
            else if (isSave == -1)
            {
                int id = int.Parse(txtID.Text);
                string err = "";
                if (!thanhVienBUS.updateThanhVien(ref err, id, name, address, phNo, idTypeMember, DateTime.Now))
                {
                    MessageBox.Show(err);
                    initLog("Chỉnh sửa thành viên thất bại: " + DateTime.Now);
                    return;
                }
                initLog("Đã chỉnh sửa thành viên: " + DateTime.Now);
            }
            isSave = 0;
            ResetTextAll();
            enableOrDisableButton(true);
            enableOrDisableTextBox(false);
            reload();
        }

        private void reload()
        {
            dgvThanhVien.DataSource = thanhVienBUS.getThanhVien().Tables[0];
            cbxTypeMember.DataSource = loaiThanhVienBUS.getLoaiThanhVien().Tables[0];
            cbxTypeMember.DisplayMember = "TenLoaiTV";
            cbxTypeMember.ValueMember = "ID";
            bindingTxtWhenOnlick(0);
            txtID.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetTextAll();
            enableOrDisableButton(true);
            enableOrDisableTextBox(false);
            isSave = 0;
            initLog("Đã hủy thao tác đang thực hiện: " + DateTime.Now);
            reload();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
            initLog("Reload: " + DateTime.Now);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableOrDisableButton(false);
            enableOrDisableTextBox(true);
            isSave = -1;
            initLog("Đang chỉnh sửa thành viên: " + DateTime.Now);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string err = "";
            if (!thanhVienBUS.deleteThanhVien(ref err, id))
            {
                MessageBox.Show(err);
                return;
            }
            reload();
            initLog("Đã xóa thành viên thành công: " + DateTime.Now);
        }

        private void initLog(string log)
        {
            log += "\r\n";
            txtLog.Text = log + txtLog.Text;
        }
    }
}

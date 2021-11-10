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
    public partial class frmDiscount : Form
    {
        public frmDiscount()
        {
            InitializeComponent();
            SettingDgvGiamGia();
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private GiamGiaBUS giamgiabus = new GiamGiaBUS();
        private DataSet ds = new DataSet();

        private void SettingDgvGiamGia()
        {
            ds = giamgiabus.getGiamGia();
            dgvGiamGia.DataSource = ds.Tables[0];
            dgvGiamGia.Columns[5].Visible = false;
            dgvGiamGia.Columns[6].Visible = false;

            dgvGiamGia.Columns[0].HeaderText = "Mã Giảm Giá";
            dgvGiamGia.Columns[1].HeaderText = "Tiêu đề";
            dgvGiamGia.Columns[2].HeaderText = "Mức Giảm Giá(%)";
            dgvGiamGia.Columns[3].HeaderText = "Ngày bắt đầu";
            dgvGiamGia.Columns[4].HeaderText = "Ngày kết thúc";
            dgvGiamGia.Columns[7].HeaderText = "Ghi chú";

            dgvGiamGia.Columns[0].Width = 130;
            dgvGiamGia.Columns[1].Width = 170;
            dgvGiamGia.Columns[2].Width = 120;
            dgvGiamGia.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGiamGia.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgvGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTieuDe.Text = dgvGiamGia.CurrentRow.Cells[1].Value.ToString();
                dtNBD.Value = Convert.ToDateTime(dgvGiamGia.CurrentRow.Cells[3].Value.ToString());
                dtNKT.Value = Convert.ToDateTime(dgvGiamGia.CurrentRow.Cells[4].Value.ToString());
                txtMucGiamGia.Text = dgvGiamGia.CurrentRow.Cells[2].Value.ToString();
                lblMaGiamGia.Text = dgvGiamGia.CurrentRow.Cells[0].Value.ToString();
                txtLuuY.Text = dgvGiamGia.CurrentRow.Cells[7].Value.ToString();
                btnSave.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
            }

            catch
            {
                return;
            }
        }

        private void Clear()
        {
            txtTieuDe.Clear();
            txtMucGiamGia.Clear();
            lblMaGiamGia.Text = "Null";
            txtLuuY.Clear();
            dtNBD.Value = DateTime.Now;
            dtNKT.Value = DateTime.Now;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (KiemTraDauVao())
            //{
            //    giamgiabus.insertGiamGia(txtTieuDe.Text, float.Parse(txtMucGiamGia.Text), dtNBD.Value, dtNKT.Value,
            //        DateTime.Now, txtLuuY.Text);
            //    Clear();
            //    SettingDgvGiamGia();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //giamgiabus.deleteGiamGia(long.Parse(lblMaGiamGia.Text));
            //Clear();
            //SettingDgvGiamGia();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //giamgiabus.updateGiamGia(long.Parse(lblMaGiamGia.Text), txtTieuDe.Text, float.Parse(txtMucGiamGia.Text),
            //    dtNBD.Value, dtNKT.Value, DateTime.Now, txtLuuY.Text);
            //Clear();
            //SettingDgvGiamGia();
        }

        private bool KiemTraDauVao()
        {
            if (txtTieuDe.Text.Trim().Equals("") ||
                txtMucGiamGia.Text.Trim().Equals("") ||
                txtLuuY.Text.Trim().Equals(""))
            {
                return false;
            }
            return true;
        }

        private void dgvGiamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }
    }
}

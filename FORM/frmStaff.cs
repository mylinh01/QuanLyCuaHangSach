using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace FORM
{
    public partial class frmStaff : Form
    {
        private NhanVienBUS nhanvienbus = new NhanVienBUS();
        private DataSet ds = new DataSet();

        public frmStaff()
        {
            InitializeComponent();
            SettingDgvNhanVien();
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }

        private void SettingDgvNhanVien()
        {
            try
            {
                ds = nhanvienbus.getNhanVien();
                dgvNhanVien.DataSource = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(e+"");
            }

            dgvNhanVien.Columns[1].Visible = false;
            dgvNhanVien.Columns[2].Visible = false;
            dgvNhanVien.Columns[7].Visible = false;
            dgvNhanVien.Columns[8].Visible = false;
            dgvNhanVien.Columns[9].Visible = false;

            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[3].HeaderText = "Họ Và Tên";
            dgvNhanVien.Columns[4].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns[5].HeaderText = "Liên hệ";
            dgvNhanVien.Columns[6].HeaderText = "Lương";

            dgvNhanVien.Columns[3].Width = 180;
            dgvNhanVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private Image ByteArrayToImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            Image img = Image.FromStream(ms, true);
            return img;
        }
        private void Clear()
        {
            txtMaNhanVien.Clear();
            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtUser.Clear();
            txtPassword.Clear();
            txtLuong.Clear();
            txtSDT.Clear();
            pictureBox1.Image = null;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtUser.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtPassword.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtHoTen.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtLuong.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                pictureBox1.Image = null;
                pictureBox1.Image = ByteArrayToImage((byte[]) dgvNhanVien.CurrentRow.Cells[9].Value);
                
            }
            catch
            {

            }
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pathImage;
            OpenFileDialog chonHinhAnh = new OpenFileDialog();
            if (chonHinhAnh.ShowDialog() == DialogResult.OK)
            {
                pathImage = chonHinhAnh.FileName;
                pictureBox1.Image = Image.FromFile(pathImage);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //nhanvienbus.deleteNhanVien(long.Parse(txtMaNhanVien.Text));
            Clear();
            SettingDgvNhanVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(KiemTraDauVao())
            {
                //nhanvienbus.insertNhanVien(txtUser.Text, txtPassword.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text,
                //    long.Parse(txtLuong.Text), DateTime.Now, pictureBox1.Image);
                //SettingDgvNhanVien();
                //Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private bool KiemTraDauVao()
        {
            if (txtDiaChi.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtUser.Text.Trim() =="" || txtPassword.Text.Trim() == "" || txtLuong.Text.Trim() == "" || txtSDT.Text.Trim() == "" || pictureBox1.Image == null)
            {
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //nhanvienbus.updateNhanVien(long.Parse(txtMaNhanVien.Text), txtUser.Text, txtPassword.Text, txtHoTen.Text,
            //    txtDiaChi.Text, txtSDT.Text,
            //    long.Parse(txtLuong.Text), DateTime.Now, pictureBox1.Image);
            //SettingDgvNhanVien();
        }
    }
}

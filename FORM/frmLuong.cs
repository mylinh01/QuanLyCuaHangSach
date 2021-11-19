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
    public partial class frmLuong : Form
    {
        NhanVienBUS nhanVien = new NhanVienBUS();
        DataSet ds = new DataSet();
        void loadCB_MaNV(ComboBox cb)
        {
            ds = nhanVien.getMaNV();
            cb.DataBindings.Clear();
            cb.DataSource = ds.Tables[0];

            cb.DisplayMember = "ID";

            cb.ValueMember = "ID";
        }
        private void DataBind()
        {
            ds = nhanVien.getViewLuong();
            dataGridView1.DataSource = ds.Tables[0];       
            cbMaNV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtLuong.DataBindings.Clear();

            cbMaNV.DataBindings.Add("SelectedValue", ds.Tables[0], "ID");
            //cbQuyen.DataBindings.Add("SelectedValue", ds.Tables[0], "Quyen");
            txtHoTen.DataBindings.Add("Text", ds.Tables[0], "HoTen");
            txtLuong.DataBindings.Add("Text", ds.Tables[0], "Luong");
        }
        public frmLuong()
        {
            InitializeComponent();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            loadCB_MaNV(cbMaNV);
            DataBind();
            txtHoTen.Enabled = false;
            txtLuong.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            dataGridView1.Columns[1].Width = 800;
            dataGridView1.Columns[2].Width = 600;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtLuong.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!nhanVien.updateLuongNhanVien(ref err, long.Parse(cbMaNV.SelectedValue.ToString()),  long.Parse(txtLuong.Text)))
                MessageBox.Show(err);
            else { MessageBox.Show("Thành công"); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            txtLuong.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
    }
}

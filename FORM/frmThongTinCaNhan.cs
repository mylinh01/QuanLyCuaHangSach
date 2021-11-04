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
    public partial class frmThongTinCaNhan : Form
    {
        NhanVienBUS nhanVien = new NhanVienBUS();
        DataSet ds = new DataSet();
        
        
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }
        public class Quyen //lop sta chua thong tin cua cbStatus
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        private void loadCB_Quyen(ComboBox cb)
        {
            //tao 2 sta la con trong va khong trong
            ds = nhanVien.getQuyen();
            cb.DataBindings.Clear();
            //gan datasource
            cbQuyen.DataBindings.Clear();
            cbQuyen.DataSource = ds.Tables[0];
           
            //gan cb.DisplayMember la "Name" la thong tin hien tren cb
            cbQuyen.DisplayMember = "Quyen";
            //gan cb.DisplayMember la "Value" la gia tri thuc cua cb
            cbQuyen.ValueMember = "Quyen";
        }
        void loadCB_MaNV(ComboBox cb)
        {
            ds = nhanVien.getMaNV();
            cb.DataBindings.Clear();
            cb.DataSource = ds.Tables[0];
            
            cb.DisplayMember = "ID";
            
            cb.ValueMember = "ID";
        }
        private void load_Data()
        {
            
        }
        private void DataBind()
        {
            ds = nhanVien.getNhanVien();
            dataGridView1.DataSource = ds.Tables[0];
            cbQuyen.DataBindings.Clear();
            cbMaNV.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPass.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtLuong.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            dtpNgayTao.DataBindings.Clear();
            dtpNgayUpdate.DataBindings.Clear();

            //cbQuyen.DataBindings.Add("SelectedValue", ds.Tables[0], "Quyen");

            cbQuyen.DataBindings.Add("SelectedValue", ds.Tables[0], "Quyen");
            cbMaNV.DataBindings.Add("SelectedValue", ds.Tables[0], "ID");
            //cbQuyen.DataBindings.Add("SelectedValue", ds.Tables[0], "Quyen");
            txtUserName.DataBindings.Add("Text", ds.Tables[0], "Username");
            txtPass.DataBindings.Add("Text", ds.Tables[0], "Password");
            txtHoTen.DataBindings.Add("Text", ds.Tables[0], "HoTen");
            txtLuong.DataBindings.Add("Text", ds.Tables[0], "Luong");
            txtDiaChi.DataBindings.Add("Text", ds.Tables[0], "DiaChi");
            txtSDT.DataBindings.Add("Text", ds.Tables[0], "SDT");
            dtpNgayTao.DataBindings.Add("Value", ds.Tables[0], "NgayTao");
            dtpNgayUpdate.DataBindings.Add("Value", ds.Tables[0], "NgayTao");
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btxMoi_Click(object sender, EventArgs e)
        {
            cbMaNV.Enabled=false;
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (!nhanVien.insertNhanVien(ref err, txtUserName.Text, cbQuyen.SelectedValue.ToString(), txtPass.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text, long.Parse(txtLuong.Text), dtpNgayTao.Value, dtpNgayUpdate.Value))
                    MessageBox.Show(err);
                else { MessageBox.Show("Thành công"); frmThongTinCaNhan_Load(sender, e); }
            }
            catch { MessageBox.Show("Dữ liệu đầu vào không chính xác"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

                string err = "";
                if (!nhanVien.updateNhanVien(ref err, long.Parse(cbMaNV.SelectedValue.ToString()), cbQuyen.SelectedValue.ToString(), txtUserName.Text, txtPass.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text, long.Parse(txtLuong.Text), dtpNgayTao.Value, dtpNgayUpdate.Value))
                    MessageBox.Show(err);
                else { MessageBox.Show("Thành công");  }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

                string err = "";
                if (!nhanVien.deleteNhanVien(ref err, cbMaNV.SelectedValue.ToString()))
                    MessageBox.Show(err);
                else { MessageBox.Show("Thành công");  }
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadCB_Quyen(cbQuyen);
            loadCB_MaNV(cbMaNV);
            DataBind();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                

            }
            catch
            {
                MessageBox.Show("Thao tác lỗi");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

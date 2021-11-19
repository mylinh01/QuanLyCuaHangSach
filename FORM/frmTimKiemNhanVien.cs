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
    public partial class frmTimKiemNhanVien : Form
    {
        NhanVienBUS nhanVien = new NhanVienBUS();
        DataSet ds = new DataSet();
        
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                       dataGridView1.DataSource = nhanVien.searchIDNV(ref err,textBox1.Text);
                    }
                    if (i == 2)
                    {
                        dataGridView1.DataSource = nhanVien.searchTenNV(ref err,textBox1.Text);
                    }
                    if (i == 3)
                    {
                        dataGridView1.DataSource = nhanVien.searchUserNameNV(ref err,textBox1.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            string err = "";
            string search = "";
            radioButton1.Checked = true;
            
            dataGridView1.DataSource = nhanVien.searchTenNV(ref err, search);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String err = "";
            try
            {

                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    dataGridView1.DataSource = nhanVien.searchTenNV(ref err, textBox1.Text);
                }
                else
                {

                    if (i == 1)
                    {
                       
                        dataGridView1.DataSource = nhanVien.searchIDNV(ref err,textBox1.Text);
                    }
                    if (i == 2)
                    {
                        dataGridView1.DataSource = nhanVien.searchTenNV(ref err, textBox1.Text);
                    }
                    if (i == 3)
                    {
                        dataGridView1.DataSource = nhanVien.searchUserNameNV(ref err, textBox1.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập vào từ khóa tìm kiếm")
            {
                textBox1.Text = "";
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

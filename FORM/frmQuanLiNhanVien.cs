using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM
{
    public partial class frmQuanLiNhanVien : Form
    {
        public frmQuanLiNhanVien()
        {
            InitializeComponent();
        }

        public int k = 1;
        int n;
        public void truyen()
        {

            if (k == 1)
            {
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                panel_danhmuc.Enabled = true;
                panel_chucnang.Enabled = true;
                cmd_dangnhap.Enabled = false;
                menuItem4.Enabled = false;
            }
        }
        public void vitricu()
        {
            cmd_taiKhoan.ForeColor = Color.Black;
            cmd_danhmuc.ForeColor = Color.Black;
            cmd_chucnag.ForeColor = Color.Black;
            panel_taikhoan.Hide();
            panel_danhmuc.Hide();
            panel_chucnang.Hide();
            cmd_danhmuc.Location = new Point(3, 220);
            cmd_chucnag.Location = new Point(3, 320);
            panel_taikhoan.Size = new Size(3, 250);
            panel_chucnang.Size = new Size(3, 300);
            panel_danhmuc.Size = new Size(143, 166);
           
        }

        private void cmd_taiKhoan_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                panel_danhmuc.Enabled = true;
                //cmd_taiKhoan.ForeColor = Color.DarkMagenta;
                cmd_danhmuc.Location = new Point(3, 350);
                cmd_chucnag.Location = new Point(3, 450);
                panel_taikhoan.Show();
                panel_taikhoan.Location = new Point(3, 200);
                panel_taikhoan.Size = new Size(190, 137);
                n = 1;
            }
            else if (n == 1)
            {

                vitricu();
                n = 0;
            }
        }

        private void cmd_danhmuc_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                panel_danhmuc.Enabled = true;
                cmd_danhmuc.ForeColor = Color.DarkMagenta;
                panel_danhmuc.Show();
                cmd_chucnag.Location = new Point(3, 480);
                panel_danhmuc.Location = new Point(3, 300);
                panel_danhmuc.Size = new Size(190, 157);
                n = 1;
            }
            else if (n == 1)
            {

                vitricu();
                n = 0;
            }
        }


        private void cmd_chucnag_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                cmd_chucnag.ForeColor = Color.DarkMagenta;
                panel_chucnang.Enabled = true;
                panel_chucnang.Show();
                panel_chucnang.Location = new Point(3, 390);
                panel_chucnang.Size = new Size(190, 155);
                n = 1;
            }
            else if (n == 1)
            {
                vitricu();
                n = 0;
            }
        }

        private void frmQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            vitricu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vitricu();
        }

        private void cmd_nhansu_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan ft = new frmThongTinCaNhan();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void cmd_tracuu_Click(object sender, EventArgs e)
        {

            frmTimKiemNhanVien ftk = new frmTimKiemNhanVien();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan ft = new frmThongTinCaNhan();
            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien ftk = new frmTimKiemNhanVien();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void cmd_dangnhap_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }


     

      
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
            button1.Size = new Size(43, 34);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Visible = true;
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cmd_tienluong_Click(object sender, EventArgs e)
        {
            frmLuong ft = new frmLuong();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

      

        private void cmd_thongtin_Click(object sender, EventArgs e)
        {
            frmStaff ft = new frmStaff();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void cmd_doimatkhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fdm = new frmDoiMatKhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

    }
}

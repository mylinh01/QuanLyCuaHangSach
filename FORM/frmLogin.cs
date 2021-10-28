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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            UpdateTextPosition();
        }
        private void frmLogin_ClientSizeChanged(object sender, EventArgs e)
        {
            UpdateTextPosition();
        }
        private void UpdateTextPosition()
        {
            Graphics g = this.CreateGraphics();
            double fw = this.Width;
            double tw = g.MeasureString(this.Text.Trim(), this.Font).Width;
            double rp = (fw - tw) / 2;
            int tt = Convert.ToInt32(rp);
            string st = " ";
            st = st.PadRight(tt / 3);
            this.Text = st + this.Text.Trim();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinControl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaxControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can't maximized!");
        }
        private void mouseEnterButtonControl(object sender, string action)
        {
            PictureBox pictureBox = sender as PictureBox;
            string src = "";
            switch (action)
            {
                case "exit":
                    {
                        src = "red";
                        break;
                    }
                case "min":
                    {
                        src = "yellow";
                        break;
                    }
                default:
                    {
                        src = "green";
                        break;
                    }
            }
            pictureBox.Image = new Bitmap(Application.StartupPath + "\\resources\\btn_" + src + "_label.png");
        }
        private void mouseLeaveButtonControl(object sender, string action)
        {
            PictureBox pictureBox = sender as PictureBox;
            string src = "";
            switch (action)
            {
                case "exit":
                    {
                        src = "red";
                        break;
                    }
                case "min":
                    {
                        src = "yellow";
                        break;
                    }
                default:
                    {
                        src = "green";
                        break;
                    }
            }
            pictureBox.Image = new Bitmap(Application.StartupPath + "\\resources\\btn_" + src + ".png");
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterButtonControl(sender, "exit");
        }
        private void btnMinControl_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterButtonControl(sender, "min");
        }
        private void btnMaxControl_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterButtonControl(sender, "max");
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveButtonControl(sender, "exit");
        }
        private void btnMinControl_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveButtonControl(sender, "min");
        }
        private void btnMaxControl_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveButtonControl(sender, "max");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


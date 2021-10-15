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
            LoaiThanhVienBUS db = new LoaiThanhVienBUS();
            DataSet dataSet = db.getLoaiThanhVien();
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace FORM
{
    public partial class frmDoiMatKhau : Form
    {
        NhanVienBUS nhanVien = new NhanVienBUS();
        DataSet ds = new DataSet();

        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        

        private SpeechSynthesizer synthesizer;
        private PromptBuilder builder;

        public frmDoiMatKhau()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            setSound();
        }
        private void GetMessage(string Message)
        {
            txtID.Text = Message;
        }
        // set sound
        private void setSound()
        {
            synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            builder = new PromptBuilder();
        }
        private void speechVoidFromString(string text)
        {
            builder.ClearContent();
            builder.StartVoice(new CultureInfo("en-US"));
            builder.AppendText(text);
            builder.EndVoice();
            synthesizer.SpeakAsync(builder);
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtPass2.Text)
            {
                string err = "Ma nhan vien hoac mat khau sai";
                DataTable dt= nhanVien.getPassword(ref err,txtID.Text);
                string pass = "";
                try { pass = dt.Rows[0][0].ToString(); }
                catch { pass = ""; }
                
                if (txtOldPass.Text!=pass)
                {
                    speechVoidFromString("Wrong password");
                    MessageBox.Show(err);
                    
                }    
                    
                else 
                {                   
                    if (!nhanVien.updatePassword(ref err, long.Parse(txtID.Text), txtOldPass.Text, txtNewPass.Text))
                    {
                        MessageBox.Show(err);
                    }
                    else 
                    { 
                        speechVoidFromString("Successfully");
                        MessageBox.Show( "Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmLogin log = new frmLogin();
                        log.Show();
                    }
                }
                
                // neu doi mat khau thanh cong tien hanh dang nhap lai he thong mot lan nua
                
            }
            // sai thi ta bao loi xac nhan pass sai
            else
            {
                speechVoidFromString("Wrong password confirm");
                MessageBox.Show("Wrong password confirm!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
    }
}

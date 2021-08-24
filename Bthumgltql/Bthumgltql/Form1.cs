using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bthumgltql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNhapso.Text);// ép kiểu về int 
            txtDayvuanhap.Text += x.ToString() + " ";
            if (x % 2 == 0)
            {
                Tongchan += x;
               txtTongchan.Text = Tongchan.ToString();
            }
            else
            {
                Tongle += x;
                txtTongle.Text = Tongle.ToString();
            }

            Tongdayso += x;
            txtTongPTTD.Text = Tongdayso.ToString();

            txtNhapso.Clear();
        }

        private void txtTongPTTD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            txtDayvuanhap.Text = "";
            txtTongPTTD.Text = "";
            txtTongchan.Text = "";
            txtTongle.Text = "";
            Tongchan = 0;
            Tongle = 0;
            Tongdayso = 0;
        }
        int Tongchan = 0, Tongle = 0, Tongdayso = 0;
    }
}

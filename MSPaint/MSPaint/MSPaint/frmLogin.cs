using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPaint
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "1111")
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

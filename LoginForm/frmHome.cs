using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStoreStatus frm = new frmStoreStatus();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPriceBook frm = new frmPriceBook();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVendors frm = new frmVendors();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmTimeClock frm = new frmTimeClock();
            frm.Show();
            this.Hide();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(); 
            this.Hide();
        }
    }
}

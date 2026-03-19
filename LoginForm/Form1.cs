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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string[,] UserCredentials =
            {
            {"malunggay" , "pandesal" , "geisler borquillo" },
            {"mang", "tomas", "Bronny James"  }
            
        };

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username!", "Validation");
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password!", "Validation");
                tbPassword.Focus();
            }
            else {
                for (int x = 0; x < UserCredentials.GetLength(0); x++)
                {
                    if (tbUsername.Text == UserCredentials[x, 0]) {
                        if (tbPassword.Text == UserCredentials[x, 1])
                        {
                            frmHome frm = new frmHome();
                            MessageBox.Show("Welcome " + UserCredentials[x, 2]);
                            this.Hide();
                            frm.Show();
                            break;
                        }
                        else {
                            MessageBox.Show("Invalid Username/Password");
                            break;
                        }
                    }
                } 
                

            }
        }
    }
}

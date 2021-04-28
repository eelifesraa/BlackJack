using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class LoginScreen : Form
    {
        public static string name = String.Empty;
        public static int delayTime = 0;
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text == String.Empty)
            {
                MessageBox.Show("Invalid values");
            }
            else
            {
                name = txtName.Text;
                delayTime = Convert.ToInt32(numDelay.Value);
                Form form = new Form1(name,delayTime);
                form.Show();
                this.Hide();
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

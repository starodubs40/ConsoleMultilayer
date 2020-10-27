using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLWinForm
{
    public partial class AuthorizationView : Form
    {
        public AuthorizationView()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            if (EmailTextBox.Text == "1" && PasswordTextBox.Text == "1")
            {
                MarketerView marketer = new MarketerView();
                marketer.Show();
                this.Hide();
            }
            else
            {
                LoginError.Visible = true; 
            }

        }
    }
}

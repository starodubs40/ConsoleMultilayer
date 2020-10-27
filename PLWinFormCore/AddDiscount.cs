using PLWinFormCore.Controllers;
using System;
using System.Windows.Forms;

namespace PLWinFormCore
{
    public partial class AddDiscount : Form
    {
        public MarketerController _marketerController;

        public AddDiscount(MarketerController marketerController)
        {
            InitializeComponent();
            _marketerController = marketerController;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(textBox1.Text);
            
            decimal discount = Convert.ToDecimal(textBox2.Text);

            _marketerController.AddPersonalDiscount(userId , discount);

            label3.Visible = true; 
        }
    }
}

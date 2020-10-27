using BLL.Interfaces;
using BLL.Services;
using DAL.EF;
using DAL.Interfaces;
using NLayerApp.DAL.Repositories;
using PLWinFormCore.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLWinFormCore
{
    public partial class ChangeDiscount : Form
    {
        public MarketerController _marketerController;

        public ChangeDiscount(MarketerController marketerController)
        {
            InitializeComponent();
            
            _marketerController = marketerController;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int userId = Convert.ToInt32(textBox1.Text);

            decimal newDiscount = Convert.ToDecimal(textBox2.Text);

            _marketerController.ChangePersonalDiscount(userId, newDiscount);

            label3.Visible = true;
        }
    }
}

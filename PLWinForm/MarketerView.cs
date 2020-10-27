using BLL.Interfaces;
using BLL.Services;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using NLayerApp.DAL.Repositories;
using PLWinForm.Controllers;
using PLWinForm.Interfaces;
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
    public partial class MarketerView : Form
    {
        public MarketerController _marketerController;

        public MarketerView()
        {
            InitializeComponent();
            DataContext dataContext = new DataContext();
            //IUnitOfWork unitOfWork = new EFUnitOfWork(dataContext);


            //IMarketerServices marketerServices = new MarketerServices(unitOfWork);
            //MarketerController marketerController = new MarketerController(marketerServices);

            //_marketerController = marketerController;
        }

      

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationView authorizationView = new AuthorizationView();
            authorizationView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = _marketerController.GetUsers();

            foreach (var user in users)
            {
                listBox1.Text += user.FirstName; 
            }

            
        }
    }
}

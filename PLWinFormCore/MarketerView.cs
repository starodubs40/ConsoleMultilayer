using BLL.Interfaces;
using BLL.Services;
using DAL.EF;
using DAL.Interfaces;
using NLayerApp.DAL.Repositories;
using PLWinFormCore.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PLWinFormCore
{
    public partial class MarketerView : Form
    {
        public static MarketerController _marketerController;

        private static AddDiscount _instanceAdd = null;
        public static AddDiscount InstanceAdd
        {
            get
            {
                if (_instanceAdd == null)
                {
                    _instanceAdd = new AddDiscount(_marketerController);
                }
                return _instanceAdd;
               
            }
        }

        private static ChangeDiscount _instanceChange = null;
        public static ChangeDiscount InstanceChange
        {
            get
            {
                if (_instanceChange == null)
                {
                    _instanceChange = new ChangeDiscount(_marketerController);
                }
                return _instanceChange;

            }
        }

        public MarketerView()
        {
            InitializeComponent();

            DataContext dataContext = new DataContext();
            IUnitOfWork unitOfWork = new EFUnitOfWork(dataContext);

            IMarketerServices marketerServices = new MarketerServices(unitOfWork);
            MarketerController marketerController = new MarketerController(marketerServices);

            _marketerController = marketerController;
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

            listBox1.Items.Add("Users:");
            foreach (var user in users)
            {
                
                listBox1.Items.Add( $"Id: {user.Id} FirstName: {user.FirstName}  LastName: {user.LastName} Email: {user.Email}"); 
            }
            listBox1.Items.Add("-------");
        }



        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var personalDiscounts = _marketerController.GetAllPersonalDiscounts();

            listBox1.Items.Add("Personal discounts:");
            if (personalDiscounts.Count() != 0)
            {
                
                foreach (var discount in personalDiscounts)
                {

                    listBox1.Items.Add($"Id: {discount.Id} UserId: {discount.UserId}  Discount: {discount.Discount} ");
                }
            }
            else
            {
                listBox1.Items.Add("No one has a personal discount");
            }
            listBox1.Items.Add("Варто ще додати айді та назву продукту на який діє знижка");
            listBox1.Items.Add("-------");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var products = _marketerController.GetProducts();

            listBox1.Items.Add("Products:");
            if (products.Count() != 0)
            {
                foreach (var product in products)
                {
                    listBox1.Items.Add($"Id: {product.Id}  ProductName: {product.Name} Price: {product.Price}");
                }
            }
            else
            {
                listBox1.Items.Add("No products found");
            }
            listBox1.Items.Add("-------");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var orders = _marketerController.GetOrders();

            listBox1.Items.Add("Orders:");
            if (orders.Count() != 0)
            {
                foreach (var order in orders)
                {
                    listBox1.Items.Add($"Id: {order.Id}  UserId: {order.UserId} Time: {order.Time}");
                    listBox1.Items.Add("Полінився вивести список товарів в замовленні");
                }
            }
            else
            {
                listBox1.Items.Add("No order found");
            }
            listBox1.Items.Add("-------");
        }


        //Add
        private void button5_Click(object sender, EventArgs e)
        {
            InstanceAdd.Show();
        }

        //Change
        private void button6_Click(object sender, EventArgs e)
        {
            InstanceChange.Show();
        }
    }
}

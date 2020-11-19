using BLL.Interfaces;
using BLL.Services;
using DAL.EF;
using DAL.Interfaces;
using NLayerApp.DAL.Repositories;
using WpfCore.Controllers;
using System.Windows;
using System;
using System.Linq;

namespace WpfCore
{
    public partial class MarketerView : Window
    {
        public static MarketerController _marketerController;

        public MarketerView()
        {
            InitializeComponent();

            DataContext dataContext = new DataContext();
            IUnitOfWork unitOfWork = new EFUnitOfWork(dataContext);

            IMarketerServices marketerServices = new MarketerServices(unitOfWork);
            MarketerController marketerController = new MarketerController(marketerServices);

            _marketerController = marketerController;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            Terminal.Items.Clear();
        }


        private void GetUsers_Click(object sender, RoutedEventArgs e)
        {
            var users = _marketerController.GetUsers();

            Terminal.Items.Add("Users:");
            foreach (var user in users)
            {

                Terminal.Items.Add($"Id: {user.Id} FirstName: {user.FirstName}  LastName: {user.LastName} Email: {user.Email}");
            }
            Terminal.Items.Add("-------");
        }


        private void GetAllPersonalDiscounts_Click(object sender, RoutedEventArgs e)
        {
            var personalDiscounts = _marketerController.GetAllPersonalDiscounts();

            Terminal.Items.Add("Personal discounts:");
            if (personalDiscounts.Count() != 0)
            {

                foreach (var discount in personalDiscounts)
                {

                    Terminal.Items.Add($"Id: {discount.Id} UserId: {discount.UserId}  Discount: {discount.Discount} ");
                }
            }
            else
            {
                Terminal.Items.Add("No one has a personal discount");
            }
            Terminal.Items.Add("Варто ще додати айді та назву продукту на який діє знижка");
            Terminal.Items.Add("-------");
        }

        private void GetProducts_Click(object sender, RoutedEventArgs e)
        {
            var products = _marketerController.GetProducts();

            Terminal.Items.Add("Products:");
            if (products.Count() != 0)
            {
                foreach (var product in products)
                {
                    Terminal.Items.Add($"Id: {product.Id}  ProductName: {product.Name} Price: {product.Price}");
                }
            }
            else
            {
                Terminal.Items.Add("No products found");
            }
            Terminal.Items.Add("-------");
        }

        private void GetOrders_Click(object sender, RoutedEventArgs e)
        {
            var orders = _marketerController.GetOrders();

            Terminal.Items.Add("Orders:");
            if (orders.Count() != 0)
            {
                foreach (var order in orders)
                {
                    Terminal.Items.Add($"Id: {order.Id}  UserId: {order.UserId} Time: {order.Time}");
                    Terminal.Items.Add("Полінився вивести список товарів в замовленні");
                }
            }
            else
            {
                Terminal.Items.Add("No order found");
            }
            Terminal.Items.Add("-------");
        }


    }
}

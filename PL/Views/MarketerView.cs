using System;



using PL.Controllers;
using PL.Interfaces;

namespace PL.Views
{
    class MarketerView : IMarketerView
    {
        private readonly MarketerController _controller;
        public MarketerView(MarketerController marketerController)
        {
            _controller = marketerController;
            StartView();
        }

        protected void StartView()
        {
            Console.Clear();
            ShowMenu();
        }

        protected virtual void ShowMenu()
        {
            Console.WriteLine("1. Display Personal Discounts");
            Console.WriteLine("2. Add Personal Discounts");
            Console.WriteLine("3. Change Personal Discount");
            Console.WriteLine("4. Display Products");
            Console.WriteLine("5. Display Users");
            Console.WriteLine("6. Show Orders");
            Console.WriteLine("7. Log out");
            Console.WriteLine("8. Closed shop");
            Console.WriteLine("--------------------------");
        }

        public void GetAllPersonalDiscounts()
        {
            StartView();
            var personalDiscounts = _controller.GetAllPersonalDiscounts();
            int index = 1;
            foreach (var discount in personalDiscounts)
                Console.WriteLine($"{index++}. , UserId: {discount.UserId} , Discount: {discount.Discount} ");

            Console.WriteLine("--------------------------");
        }


        public void AddPersonalDiscount(int userId, decimal discount)
        {
            _controller.AddPersonalDiscount(userId,discount);
        }

        public void ChangePersonalDiscount(int userId, decimal discount)
        {
            _controller.ChangePersonalDiscount(userId, discount);
        }

        public void DisplayProducts()
        {
            StartView();
            var products = _controller.GetProducts();
            Console.WriteLine("Display products: ");
            int index = 1;
            foreach (var product in products)
                Console.WriteLine($"{index++}. , Name {product.Name}, Price: {product.Price}\nDescription: {product.Description}");
            
            Console.WriteLine("--------------------------");
        }

        public void DisplayUsers()
        {
            StartView();
            var users = _controller.GetUsers();
            Console.WriteLine("Display Users");
            int index = 1;
            foreach (var user in users)
                Console.WriteLine($"{index++}. , LastName: {user.LastName} , FirstName: {user.FirstName}, Email: {user.Email}");

            Console.WriteLine("--------------------------");
        }

        

        public void ShowOrders()
        {
            StartView();
            var orders = _controller.GetOrders();
            Console.WriteLine("Orders");
            int index = 1;
            foreach (var order in orders)
            {
                Console.WriteLine($"{index++}. , UserId: {order.UserId} , Time: {order.Time} ");
            }
            Console.WriteLine("--------------------------");
        }

        public void LogOut()
        {
            Console.Clear();
        }
    }
}

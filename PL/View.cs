using System;
using BLL;
using BLL.Interfaces;
using PL.Controllers;
using PL.Interfaces;
using PL.Views;

namespace PL
{
    public class View
    {
        private IAuthorizationView _authorizationView;
        private IMarketerView _marketerView;
        private readonly MarketerController _marketerController;
    
        public View(MarketerController marketerController)
        {
            _marketerController = marketerController;
            _authorizationView = new AuthorizationView();
        }

        public void MakeAction()
        {
            if (_authorizationView != null)
                MakeAuthorizationAction();
            else if (_marketerView != null)
            {
                Console.Write("Your choice: ");
                string result = Console.ReadLine();
                MakeMarketerAction(result);
            }
        }

        
        private void MakeAuthorizationAction()
        {
            Console.WriteLine("Enter login: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            if (email == "1" && password == "1")
            {
                _authorizationView = null;
                _marketerView = new MarketerView(_marketerController);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Login or password is incorrect , try again");
            }
        }

        private void MakeMarketerAction(string number)
        {
            switch (number)
            {
                case "1":
                    _marketerView.GetAllPersonalDiscounts();
                    break;
                case "2":
                    Console.Write("Enter user id:");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter discount:");
                    decimal discount2 = Convert.ToDecimal(Console.ReadLine());
                    _marketerView.AddPersonalDiscount(id2 , discount2);
                    break;
                case "3":
                    Console.Write("Enter user id:");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter discount:");
                    decimal discount3 = Convert.ToDecimal(Console.ReadLine());
                    _marketerView.ChangePersonalDiscount(id3 , discount3);
                    break;
                case "4":
                    _marketerView.DisplayProducts();
                    break;
                case "5":
                    _marketerView.DisplayUsers();
                    break;
                case "6":
                    _marketerView.ShowOrders();
                    break;
                case "7":
                    //ChangeViewRole(_guestView.UserInfo.LoggedInUser, _guestView.UserInfo.email);
                    Environment.Exit(0);
                    _marketerView.LogOut();

                    break;
            }
        }


    }
}

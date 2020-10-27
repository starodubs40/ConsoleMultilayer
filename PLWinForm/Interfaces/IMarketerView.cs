
namespace PLWinForm.Interfaces
{
    interface IMarketerView
    {
        void GetAllPersonalDiscounts();
        void AddPersonalDiscount(int userId, decimal discount);
        void ChangePersonalDiscount(int userId , decimal discount);
        void DisplayProducts();
        void DisplayUsers();
        void ShowOrders();
        void LogOut();
    }
}
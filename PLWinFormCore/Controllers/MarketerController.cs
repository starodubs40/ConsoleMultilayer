using BLL.Interfaces;
using BLL.DTO;
using System.Collections.Generic;

namespace PLWinFormCore.Controllers
{
    public class MarketerController
    {
        protected readonly IMarketerServices MarketerServices;


        public string Email { get; set; }

        public MarketerController(IMarketerServices marketerServices)
        {
            MarketerServices = marketerServices;
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            return MarketerServices.GetProducts();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return MarketerServices.GetUsers();
        }

        public IEnumerable<PersonalDiscountDTO> GetAllPersonalDiscounts()
        {
            return MarketerServices.GetAllPersonalDiscounts();
        }

        public void AddPersonalDiscount(int userId, decimal discount)
        {
            MarketerServices.AddPersonalDiscount(userId, discount);
        }

        public void ChangePersonalDiscount(int userId, decimal newDiscount)
        {
            MarketerServices.ChangePersonalDiscount(userId, newDiscount);
        }

        public IEnumerable<OrderDTO> GetOrders()
        {
            return MarketerServices.GetOrders();
        }

    }
}

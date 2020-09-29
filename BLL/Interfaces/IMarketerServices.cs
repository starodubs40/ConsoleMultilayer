using System.Collections.Generic;

using BLL.DTO;


namespace BLL.Interfaces
{
    public interface IMarketerServices
    {

        IEnumerable<ProductDTO> GetProducts();
        IEnumerable<UserDTO> GetUsers();
        IEnumerable<PersonalDiscountDTO> GetAllPersonalDiscounts();
        void AddPersonalDiscount(int userId , decimal discount);
        void ChangePersonalDiscount(int userId , decimal newDiscount);
        IEnumerable<OrderDTO> GetOrders(); 
    }
}

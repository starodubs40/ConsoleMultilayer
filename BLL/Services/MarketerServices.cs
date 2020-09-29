using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
//
using BLL.DTO;
//
using DAL.Interfaces;
using DAL.Entities;
//
using AutoMapper;

namespace BLL.Services
{
    public class MarketerServices : IMarketerServices
    {
        IUnitOfWork Db { get; set; }

        public MarketerServices(IUnitOfWork uow)
        {
            Db = uow;
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            var config = new MapperConfiguration(cnfg => cnfg.CreateMap<Product, ProductDTO>());
            var map = new Mapper(config);
            return map.Map<IEnumerable<ProductDTO>>(Db.Products.GetAll());
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var config = new MapperConfiguration(cnfg => cnfg.CreateMap<User, UserDTO>());
            var map = new Mapper(config);
            return map.Map<IEnumerable<UserDTO>>(Db.Users.GetAll());
        }

        public IEnumerable<PersonalDiscountDTO> GetAllPersonalDiscounts()
        {
            var config = new MapperConfiguration(cnfg => cnfg.CreateMap<PersonalDiscount, PersonalDiscountDTO>());
            var map = new Mapper(config);
            return map.Map<IEnumerable<PersonalDiscountDTO>>(Db.PersonalDiscounts.GetAll());
        }

        public void AddPersonalDiscount(int userId, decimal discount)
        {
            var personalDiscounts = Db.PersonalDiscounts.GetAll();
            Db.PersonalDiscounts.Create(new PersonalDiscount
            {
               // Id = personalDiscounts.Count() != 0  ? personalDiscounts.Max(item => item.Id) + 1 : 0,
                UserId = userId,
                Discount = discount
            });
        }

        public void ChangePersonalDiscount(int userId, decimal newDiscount)
        {
            var personalDiscount = Db.PersonalDiscounts.Find(item => item.UserId == userId);
            personalDiscount.Discount = newDiscount;
        }

        public IEnumerable<OrderDTO> GetOrders()
        {
            var config = new MapperConfiguration(cnfg => cnfg.CreateMap<Order, OrderDTO>());
            var map = new Mapper(config);
            return map.Map<IEnumerable<OrderDTO>>(Db.Orders.GetAll());
        }

    }
}

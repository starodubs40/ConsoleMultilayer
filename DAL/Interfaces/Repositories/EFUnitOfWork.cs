using System;
using DAL.EF;
using DAL.Interfaces.Repositories;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace NLayerApp.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext db;

        private OrderRepository orderRepository;
        private PersonalDiscountRepository personalDiscountRepository;
        private ProductRepository productRepository;
        private UserRepository userRepository;

        public EFUnitOfWork(DataContext context)
        {
            db = context;
        }
       
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public IRepository<PersonalDiscount> PersonalDiscounts
        {
            get
            {
                if (personalDiscountRepository == null)
                    personalDiscountRepository = new PersonalDiscountRepository(db);
                return personalDiscountRepository;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }


        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
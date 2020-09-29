using System.Collections.Generic;
using DAL.Entities;
using DAL.EF;
using System;
using System.Linq;

namespace DAL.Interfaces.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private DataContext db;

        public OrderRepository (DataContext context)
        {
            this.db = context;
        }

        public void Create(Order item)
        {
            db.Orders.Add(item);
        }

        public void Delete(int id)
        {
            Order order = db.Orders.Find(id);
            if (order != null)
                db.Orders.Remove(order);
        }

        public Order Find(Func<Order, bool> predicate)
        {
            return db.Orders.FirstOrDefault(predicate);
        }

        public Order Get(int id)
        {
            return db.Orders.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders;
        }

        public void Update(Order item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
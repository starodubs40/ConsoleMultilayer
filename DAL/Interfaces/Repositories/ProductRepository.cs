using System.Collections.Generic;
using DAL.Entities;
using DAL.EF;
using System;
using System.Linq;

namespace DAL.Interfaces.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private DataContext db;

        public ProductRepository(DataContext context)
        {
            this.db = context;
        }

        public void Create(Product item)
        {
            db.Products.Add(item);
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
                db.Products.Remove(product);
        }

        public Product Find(Func<Product, bool> predicate)
        {
            return db.Products.FirstOrDefault(predicate);
        }


        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public void Update(Product item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}

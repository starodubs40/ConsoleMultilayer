using System.Collections.Generic;
using DAL.Entities;
using DAL.EF;
using System;
using System.Linq;

namespace DAL.Interfaces.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private DataContext db;

        public UserRepository (DataContext context)
        {
            this.db = context;
        }
        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }

        public User Find(Func<User, bool> predicate)
        {
            return db.Users.FirstOrDefault(predicate);
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public void Update(User item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}


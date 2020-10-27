using System.Collections.Generic;
using DAL.Entities;
using DAL.EF;
using System;
using System.Linq;

namespace DAL.Interfaces.Repositories
{
    public class PersonalDiscountRepository : IRepository<PersonalDiscount>
    {
        private DataContext db;

        public PersonalDiscountRepository(DataContext context)
        {
            this.db = context;
        }
        public void Create(PersonalDiscount item)
        {
            db.PersonalDiscounts.Add(item);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            PersonalDiscount personalDiscount = db.PersonalDiscounts.Find(id);
            if (personalDiscount != null)
                db.PersonalDiscounts.Remove(personalDiscount);
        }

        public PersonalDiscount Find(Func<PersonalDiscount, bool> predicate)
        {
            return db.PersonalDiscounts.FirstOrDefault(predicate);
        }

        public PersonalDiscount Get(int id)
        {
            return db.PersonalDiscounts.Find(id);
        }

        public IEnumerable<PersonalDiscount> GetAll()
        {
            return db.PersonalDiscounts;
        }

        public void Update(PersonalDiscount item)
        {
            using (DataContext db = new DataContext())
            {
                // получаем первый объект
                PersonalDiscount p = db.PersonalDiscounts.FirstOrDefault();

                p.Discount = item.Discount;
                db.SaveChanges();   // сохраняем изменения
            }
        }
    }
}

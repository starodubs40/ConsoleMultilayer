using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Order //чеки
    {
        public int Id { get; set; } //id чеку

        public int UserId { get; set; }

        public DateTime Time { get; set; }

        ICollection<Product> Products { get; set; }
    }
}

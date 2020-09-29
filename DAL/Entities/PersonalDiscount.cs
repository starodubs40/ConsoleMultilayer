using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class PersonalDiscount
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public decimal Discount { get; set; }
    }
}

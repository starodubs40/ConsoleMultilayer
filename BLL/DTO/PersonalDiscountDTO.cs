using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class PersonalDiscountDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public decimal Discount { get; set; }
    }
}

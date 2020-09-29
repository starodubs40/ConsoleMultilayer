using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; } //id чеку

        public int UserId { get; set; }

        public DateTime Time { get; set; }

        ICollection<ProductDTO> Products { get; set; }
    }
}

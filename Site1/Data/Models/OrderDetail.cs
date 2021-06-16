using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int carId { get; set; }
        public int price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order email { get; set; }

    }
}

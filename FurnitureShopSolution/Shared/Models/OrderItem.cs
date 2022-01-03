using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
    }
}

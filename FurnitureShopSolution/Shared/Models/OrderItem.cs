using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{

    public class OrderItem
    {
        private int orderID;

        public OrderItem()
        {
        }

        public OrderItem(int orderItemID, int itemID, int quantity, int order_ID)
        {
            OrderItemID = orderItemID;
            ItemID = itemID;
            Quantity = quantity;
            orderID = order_ID;
        }

        public int OrderItemID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
    }
}

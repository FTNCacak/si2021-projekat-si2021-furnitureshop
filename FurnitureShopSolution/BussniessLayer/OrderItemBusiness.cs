using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer
{
    class OrderItemBusiness
    {
        private readonly OrderItemRepository OrderItemRepository = new OrderItemRepository();

        public List<OrderItem> GetAllOrderItems()
        {
            return OrderItemRepository.GetAllOrderItems();
        }
        public bool InsertOrderItem(OrderItem oi)
        {
            if (this.OrderItemRepository.InsertOrderItem(oi) > 0)
                return true;
            return false;
        }
        public void DeleteItemsOrder(int itemorder)
        {
            OrderItemRepository.DeleteOrderItem(itemorder);
        }
    }
}

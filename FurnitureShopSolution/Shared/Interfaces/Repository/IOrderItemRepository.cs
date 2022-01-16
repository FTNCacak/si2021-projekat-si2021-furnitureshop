using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IOrderItemRepository
    {
        List<OrderItem> GetAllOrderItems();
        int InsertOrderItem(OrderItem oi);
        int UpdateOrderItem(OrderItem OrderItem);
        int DeleteOrderItem(int orderitemid);

    }
}

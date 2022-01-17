using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        int InsertOrder(Order o);
        int UpdateOrder(Order Order);
        int DeleteOrder(int order);

    }
}

using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IOrderBusiness
    {
        List<Order> GetAllOrders();
        bool InsertOrder(Order o);
        int UpdateOrder(Order Order);
        int DeleteOrder(int order);
    }
}

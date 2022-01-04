using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer
{
    class OrderBusiness
    {
        private readonly OrderRepository OrderRepository = new OrderRepository();

        public List<Order> GetAllOrders()
        {
            return OrderRepository.GetAllOrders();
        }

        public bool InsertOrder(Order o)
        {
            if (this.OrderRepository.InsertOrder(o) > 0)
                return true;
            return false;
        }
        public void DeleteOrder(int order)
        {
            OrderRepository.DeleteOrder(order);
        }
    }
}

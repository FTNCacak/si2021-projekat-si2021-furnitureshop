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

        public bool InsertOrders(Order o)
        {
            if (this.OrderRepository.InsertOrders(o) > 0)
                return true;
            return false;
        }
        public void DeleteOrders(int order)
        {
            OrderRepository.DeleteOrders(order);
        }
    }
}

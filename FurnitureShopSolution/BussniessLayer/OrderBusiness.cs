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
    }
}

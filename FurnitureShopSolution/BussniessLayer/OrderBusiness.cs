using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer
{
    public class OrderBusiness : IOrderBusiness
    {
        private readonly IOrderRepository OrderRepository;

        public OrderBusiness(IOrderRepository _OrderRepository)
        {
            OrderRepository = _OrderRepository;
        }

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
        public int UpdateOrder(Order Order)
        {
            return OrderRepository.UpdateOrder(Order);
        }
        public int DeleteOrder(int order)
        {
            return OrderRepository.DeleteOrder(order);
        }
    }
}

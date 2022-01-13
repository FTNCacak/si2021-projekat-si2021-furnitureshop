﻿using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer
{
    public class OrderItemBusiness : IOrderItemBusiness
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
        public int UpdateOrderItem(OrderItem OrderItem)
        {
            return OrderItemRepository.UpdateOrderItem(OrderItem); 
        }
        public void DeleteItemsOrder(int itemorder)
        {
            OrderItemRepository.DeleteOrderItem(itemorder);
        }
    }
}

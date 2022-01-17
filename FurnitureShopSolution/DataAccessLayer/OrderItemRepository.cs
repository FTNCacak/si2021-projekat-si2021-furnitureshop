﻿using Shared;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderItemRepository : IOrderItemRepository
    {
        public List<OrderItem> GetAllOrderItems()
        {

            List<OrderItem> orderItems = new List<OrderItem>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM OrderItems";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderItemID = sqlDataReader.GetInt32(0);
                    orderItem.ItemID = sqlDataReader.GetInt32(1);
                    orderItem.Quantity = sqlDataReader.GetInt32(2);
                    orderItem.OrderID = sqlDataReader.GetInt32(3);
                    orderItems.Add(orderItem);
                }

            }
            return orderItems;
        }

        public int InsertOrderItem(OrderItem oi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format("INSERT INTO OrderItems VALUES({0},{1},{2})",
                    oi.ItemID, oi.Quantity,oi.OrderID);
                   
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int UpdateOrderItem(OrderItem OrderItem)
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                //proveriti logiku sql upita ispod
                string command = "UPDATE OrderItems SET Quantity=@Quantity WHERE OrderItemID=@OrderItemID";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@OrderItemID", OrderItem.OrderItemID);
                sqlCommand.Parameters.AddWithValue("@Quantity", OrderItem.Quantity);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int DeleteOrderItem(int orderitemid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM OrderItems WHERE OrderItemID = @OrderItemID";
                    sqlCommand.Parameters.AddWithValue("@OrderItemID", orderitemid);

                    sqlConnection.Open();

                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}

using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderItemRepository
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
                    orderItem.ItemID = sqlDataReader.GetInt32(0);
                    orderItem.Quantity = sqlDataReader.GetInt32(0);
                    orderItems.Add(orderItem);
                }

            }
            return orderItems;
        }
    }
}

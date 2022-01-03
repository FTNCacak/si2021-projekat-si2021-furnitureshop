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
    public class OrderRepository
    {
        public List<Order> GetAllOrders()
        {

            List<Order> orders = new List<Order>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Orders";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Order order = new Order();
                    order.OrderID = sqlDataReader.GetInt32(0);
                    order.OrderItemID = sqlDataReader.GetInt32(1);
                    order.EmployeeID = sqlDataReader.GetInt32(2);
                    order.OrderDate = sqlDataReader.GetDateTime(3);
                    order.Bill = sqlDataReader.GetDecimal(4);
                    orders.Add(order);
                }

            }
            return orders;
        }
    }
}

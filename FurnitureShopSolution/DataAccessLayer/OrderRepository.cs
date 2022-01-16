using Shared;
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
    public class OrderRepository : IOrderRepository
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
                    order.EmployeeID = sqlDataReader.GetInt32(1);
                    order.OrderDate = sqlDataReader.GetDateTime(2);
                    order.Bill = sqlDataReader.GetDecimal(3);
                    orders.Add(order);
                }

            }
            return orders;
        }
        public int InsertOrder(Order o)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format("INSERT INTO Orders VALUES({0},'{1}',{2})",
                    o.EmployeeID,o.OrderDate,o.Bill);
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int UpdateOrder(Order Order)
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                string command = "UPDATE OrderItems SET EmployeeID=@EmployeeID, OrderDate=@OrderDate, Bill=@Bill  WHERE OrderID=@Order";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@OrderID", Order.OrderID);
                sqlCommand.Parameters.AddWithValue("@EmployeeID", Order.EmployeeID);
                sqlCommand.Parameters.AddWithValue("@OrderDate", Order.OrderDate);
                sqlCommand.Parameters.AddWithValue("@Bill", Order.Bill);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public void DeleteOrder(int order)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Orders WHERE Order = @OrderID";
                    sqlCommand.Parameters.AddWithValue("@OrderID", order);
                }
            }
        }
    }
}

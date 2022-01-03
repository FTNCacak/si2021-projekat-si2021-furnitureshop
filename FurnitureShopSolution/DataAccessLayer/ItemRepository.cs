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
    public class ItemRepository
    {
        public List<Item> GetAllItems()
        {

            List<Item> items = new List<Item>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Items";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Item item = new Item();
                    item.ItemID = sqlDataReader.GetInt32(0);
                    item.ProductName = sqlDataReader.GetString(1);
                    item.ProductPrice = sqlDataReader.GetDecimal(2);
                    item.ProductColor = sqlDataReader.GetString(3);
                    item.ProductDescription = sqlDataReader.GetString(4);
                    item.Type = sqlDataReader.GetString(5);
                    item.Category = sqlDataReader.GetString(6);
                    item.Stock = sqlDataReader.GetInt32(7);
                    item.Discount = sqlDataReader.GetInt32(8);

                    items.Add(item);
                }

            }
            return items;
        }
    }
}

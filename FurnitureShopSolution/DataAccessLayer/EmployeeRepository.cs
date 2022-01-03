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
    public class EmployeeRepository
    {

        public List<Employee> GetAllEmployees()
        {

            List<Employee> employees = new List<Employee>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Employees";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = sqlDataReader.GetInt32(0);
                    employee.Name = sqlDataReader.GetString(1);
                    employee.Email = sqlDataReader.GetString(2);
                    employee.PhoneNumber = sqlDataReader.GetInt32(3);
                    employee.Address = sqlDataReader.GetString(4);
                    employee.Username = sqlDataReader.GetString(5);
                    employee.Password = sqlDataReader.GetString(6);
                    employee.Role = sqlDataReader.GetString(7);
                    employee.MenagerID = sqlDataReader.GetInt32(8);

                    employees.Add(employee);
                }

            }
            return employees;
        }
    }
}

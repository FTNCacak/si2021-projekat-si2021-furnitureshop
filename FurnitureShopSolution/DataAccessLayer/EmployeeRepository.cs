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
                    employee.Role = sqlDataReader.IsDBNull(7) ? "none" : sqlDataReader.GetString(7);
                    employee.ManagerID = sqlDataReader.IsDBNull(8) ? 0 : sqlDataReader.GetInt32(8);
                    employees.Add(employee);
                }

            }
            return employees;
        }
        public int InsertEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO Employees VALUES (@Name,@Email,@PhoneNumber,@Address,@Username,@Password,@Role,@ManagerID)";
                sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
                sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
                sqlCommand.Parameters.AddWithValue("@Username", employee.Username);
                sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
                sqlCommand.Parameters.AddWithValue("@Role", employee.Role);
                sqlCommand.Parameters.AddWithValue("@ManagerID", employee.ManagerID);

                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int UpdateEmployee(Employee employee)
        {
          
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                string command = "UPDATE Employees SET Name=@Name, Email=@Email, PhoneNumber=@PhoneNumber, Address=@Address, Username=@Username, Password=@Password, Role=@Role, ManagerID=@ManagerID WHERE EmployeeID=@EmployeeID";

                SqlCommand sqlCommand = new SqlCommand(command,sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
                sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
                sqlCommand.Parameters.AddWithValue("@Username", employee.Username);
                sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
                sqlCommand.Parameters.AddWithValue("@Role", employee.Role);
                sqlCommand.Parameters.AddWithValue("@ManagerID", employee.ManagerID);
                sqlCommand.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public void DeleteEmplyee(int emplyeeid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                    sqlCommand.Parameters.AddWithValue("@EmployeeID", emplyeeid);
                }
            }
        }
    }
}

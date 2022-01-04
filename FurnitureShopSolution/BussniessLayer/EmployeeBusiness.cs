using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer
{
    public class EmployeeBusiness
    {
        private readonly EmployeeRepository employeeRepository = new EmployeeRepository();

        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }
        public bool InsertEmployee(Employee e)
        {
            if (this.employeeRepository.InsertEmployee(e) > 0)
                return true;
            return false;
        }
        public int UpdateEmployee(Employee employee)
        {
            return employeeRepository.UpdateEmployee(employee);
        }
        public void DeleteEmployee(int employee)
        {
            employeeRepository.DeleteEmplyee(employee);
        }
    }
}

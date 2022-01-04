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
        public bool InsertEmployees(Employee e)
        {
            if (this.employeeRepository.InsertEmployees(e) > 0)
                return true;
            return false;
        }
        public void DeleteEmployees(int employee)
        {
            employeeRepository.DeleteEmplyees(employee);
        }
    }
}

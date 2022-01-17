using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeBusiness(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

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
        public int DeleteEmployee(int employee)
        {
            return employeeRepository.DeleteEmplyee(employee);
        }
    }
}

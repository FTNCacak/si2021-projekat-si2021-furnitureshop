using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IEmployeeBusiness
    {
        List<Employee> GetAllEmployees();
        bool InsertEmployee(Employee e);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int employee);
    }
}

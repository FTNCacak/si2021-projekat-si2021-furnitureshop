using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public int PhoneNumber { get; set; }
		public string Address { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
		public int ManagerID { get; set; }
		
	} 
}


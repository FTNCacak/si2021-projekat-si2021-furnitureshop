using BussniessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureShop
{
    public partial class AdminVerification : Form
    {
        private readonly EmployeeBusiness employeeBusiness;
        public Employee employee = new Employee();

        public AdminVerification(Employee e)
        {
            employeeBusiness = new EmployeeBusiness();
            InitializeComponent();
            employee = e;
        }

        private void AdminVerification_Load(object sender, EventArgs e)
        {
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxAVusername.Text == "" && textBoxAVpassword.Text == "")
            {
                //MessageBox.Show("Fill up all fileds!!");
            }
            foreach(Employee emp in employeeBusiness.GetAllEmployees())
            {
                if(textBoxAVusername.Text.CompareTo(emp.Username) == 0 && textBoxAVpassword.Text.CompareTo(emp.Password) == 0)
                {
                    if (emp.Role.ToUpper().CompareTo("ADMINISTRATOR")==0)
                    {
                        employeeBusiness.InsertEmployee(employee);
                    }
                }
            }
        }
    }
}

using BussniessLayer;
using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
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
        private readonly IEmployeeBusiness employeeBusiness;
        public Employee employee = new Employee();
        public Register Register = new Register();

        public AdminVerification(Employee e, Register r)
        {
            //employeeBusiness = new EmployeeBusiness();
            InitializeComponent();
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            this.employeeBusiness = new EmployeeBusiness(employeeRepository);

            employee = e;
            Register = r;
        }

        private void AdminVerification_Load(object sender, EventArgs e)
        {
            textBoxAVpassword.PasswordChar = '●';
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int pom = 0;
            if (textBoxAVusername.Text == "" || textBoxAVpassword.Text == "")
            {
                MessageBox.Show("All fields must be filled.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {


                foreach (Employee emp in employeeBusiness.GetAllEmployees())
                {
                    if (textBoxAVusername.Text.CompareTo(emp.Username) == 0 && textBoxAVpassword.Text.CompareTo(emp.Password) == 0)
                    {
                        if (emp.Role.ToUpper().CompareTo("ADMINISTRATOR") == 0)
                        {
                            employeeBusiness.InsertEmployee(employee);
                            MessageBox.Show("Employee successfully added!", "Information Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            pom = 1;
                            Register.Close();
                            
                            
                        }
                    }

                }
                if (pom != 1)
                {
                    MessageBox.Show("Account with password and username you provided does't exist or doesn't have \"administrator\" role. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void pictureBoxShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxAVpassword.PasswordChar = '\0';
        }

        private void pictureBoxShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxAVpassword.PasswordChar = '●';
        }
    }
}

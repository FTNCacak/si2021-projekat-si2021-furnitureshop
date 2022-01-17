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
    public partial class LogIn : Form
    {
        private readonly IEmployeeBusiness employeeBusiness;

        public LogIn()
        {
           
            InitializeComponent();

            IEmployeeRepository employeeRepository = new EmployeeRepository();
            this.employeeBusiness = new EmployeeBusiness(employeeRepository);

            textBoxPassword.PasswordChar = '●';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees = employeeBusiness.GetAllEmployees();
            int pom = 0;
            if (textBoxUserName.Text.CompareTo("") == 0 || textBoxPassword.Text.CompareTo("") == 0)
            {
                MessageBox.Show("All fields must be filled. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                foreach (Employee employee in employees)
                {
                    if (textBoxUserName.Text.CompareTo(employee.Username) == 0 && textBoxPassword.Text.CompareTo(employee.Password) == 0)
                    { 
                        MessageBox.Show("Login successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FurnitureShop app = new FurnitureShop(employee.Username);
                        app.Show();
                        this.Hide();
                        pom = 1;
                        break;
                    }
                }
                if (pom == 0)
                {
                    MessageBox.Show("Incorrect username or password.Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void pictureBoxShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }
    }
}

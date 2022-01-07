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
    public partial class LogIn : Form
    {
        private readonly EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        public LogIn()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();

            //hiding the LogIn form
            this.Hide();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees = employeeBusiness.GetAllEmployees();
            int pom = 0;
            foreach(Employee employee in employees)
            {
                if(textBoxUserName.Text.CompareTo(employee.Username) == 0 && textBoxPassword.Text.CompareTo(employee.Password) == 0)
                {
                    MessageBox.Show("Login successful.");
                    Form1 app = new Form1();
                    app.Show();
                    this.Hide();
                    pom = 1;
                    break;
                }
            }
            if(pom == 0)
            {
                MessageBox.Show("Incorrect username or password. Try again! ");

            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}

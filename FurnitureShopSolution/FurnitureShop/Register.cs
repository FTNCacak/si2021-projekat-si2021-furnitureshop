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
    public partial class Register : Form
    {
        private readonly EmployeeBusiness employeeBusiness;
        
        public Register()
        {
            this.employeeBusiness = new EmployeeBusiness();
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LogIn l=new LogIn();
            l.Close();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee();
            emp.Name = textBoxName.Text;
            emp.Email = textBoxEmail.Text;
            emp.PhoneNumber = Convert.ToInt32(textBoxPhoneNumber.Text);
            emp.Address = textBoxAdress.Text;
            emp.Username = textBoxUserName.Text;
            emp.Password = textBoxPassword.Text;
            emp.Role = textBoxRole.Text.CompareTo("")==0 ? "none" : textBoxRole.Text;
            emp.ManagerID = textBoxMenagerID.Text.CompareTo("") == 0 ? 0 : Convert.ToInt32(textBoxMenagerID.Text);
            

            AdminVerification a = new AdminVerification(emp);
            a.Show();

            

        }
    }
}

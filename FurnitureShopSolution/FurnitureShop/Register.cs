using BussniessLayer;
using DataAccessLayer;
using Shared;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureShop
{
    public partial class Register : Form
    {
        private readonly IEmployeeBusiness employeeBusiness;
        public Register()
        {
            InitializeComponent();
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            this.employeeBusiness = new EmployeeBusiness(employeeRepository);


            textBoxPassword.PasswordChar = '●';
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee();
            emp.Name = textBoxName.Text;
            emp.Email = textBoxEmail.Text;

            try
            {
                emp.PhoneNumber = Convert.ToInt32(textBoxPhoneNumber.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Field phone number must contains only numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            emp.Address = textBoxAdress.Text;
            emp.Username = textBoxUserName.Text;
            emp.Password = textBoxPassword.Text;
            emp.Role = textBoxRole.Text.CompareTo("")==0 ? "none" : textBoxRole.Text;
            emp.ManagerID = textBoxMenagerID.Text.CompareTo("") == 0 ? 0 : Convert.ToInt32(textBoxMenagerID.Text);

            if (!Regex.Match(textBoxName.Text, Validation.NameRegex).Success)
            {
                MessageBox.Show("Incorrect name!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBoxEmail.Text, Validation.EmailRegex).Success)
            {
                MessageBox.Show("Incorrect email!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBoxPhoneNumber.Text, Validation.PhoneNumberRegex).Success)
            {
                MessageBox.Show("Incorrect phone number!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBoxAdress.Text, Validation.AddressRegex).Success)
            {
                MessageBox.Show("Incorrect address!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBoxUserName.Text, Validation.UsernameRegex).Success)
            {
                MessageBox.Show("Incorrect Username!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBoxPassword.Text, Validation.PasswordRegex).Success)
            {
                MessageBox.Show("Invalid Password format!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBoxRole.Text, Validation.RoleRegex).Success && textBoxRole.Text.CompareTo("") != 0)
            {
                MessageBox.Show("Incorrect Role!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBoxMenagerID.Text, Validation.ManagerIdRegex).Success && textBoxMenagerID.Text.CompareTo("") != 0)
            {
                MessageBox.Show("Incorrect MangerID!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                AdminVerification a = new AdminVerification(emp,this);
                a.ShowDialog();
            }


        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

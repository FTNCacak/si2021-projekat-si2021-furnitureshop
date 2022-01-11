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
    public partial class Form1 : Form
    {
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        private readonly EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        BindingSource bs = new BindingSource();
        BindingSource bs_employee = new BindingSource();
        DataTable dt = new DataTable();
        DataTable dt_employee= new DataTable();
        public Form1(string User)
        {
            InitializeComponent();
            labelUser.Text = User;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>();
            items = itemBusiness.GetInStockItems();

            textBoxSearch.Clear();

            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(decimal));
            dt.Columns.Add("ProductColor", typeof(string));
            dt.Columns.Add("ProductDescription", typeof(string));
            dt.Columns.Add("ProductType", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("Discount", typeof(int));

            dt_employee.Columns.Add("EmployeeID", typeof(int));
            dt_employee.Columns.Add("Name", typeof(string));
            dt_employee.Columns.Add("Email", typeof(string));
            dt_employee.Columns.Add("PhoneNumber", typeof(int));
            dt_employee.Columns.Add("Address", typeof(string));
            dt_employee.Columns.Add("Username", typeof(string));
            dt_employee.Columns.Add("Password", typeof(string));
            dt_employee.Columns.Add("Role", typeof(string));
            dt_employee.Columns.Add("ManagerID", typeof(int));

            dataGridStock.DataSource = itemBusiness.GetInStockItems();
            listBoxItems.HorizontalScrollbar = true;
            foreach(var item in items)
              {
                dt.Rows.Add(new object[] { item.ProductName, item.ProductPrice, item.ProductColor, item.ProductDescription, item.Type, item.Category, item.Stock, item.Discount });
                listBoxItems.Items.Add(string.Format("{0} / Price:{1} / {2} / {3} / {4} / {5} / In stock:{6} / Discount:{7} ",item.ProductName,item.ProductPrice,item.ProductColor,item.ProductDescription,item.Type,item.Category, item.Stock, item.Discount));
              }
            bs.DataSource = dt;
            dataGridStock.DataSource = bs;

            foreach (var employees in employeeBusiness.GetAllEmployees())
            {
                dt_employee.Rows.Add(new object[] { employees.EmployeeID, employees.Name, employees.Email, employees.PhoneNumber, employees.Address, employees.Username, employees.Password, employees.Role, employees.ManagerID });
            }
            bs_employee.DataSource = dt_employee;
            dataGridEmployees.DataSource = bs_employee;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            /*TODO prebaciti u data access layer*/
            bs.Filter =
                string.Format("ProductName LIKE '%{0}%' OR ProductDescription LIKE '%{0}%' OR ProductColor LIKE '%{0}%'", textBoxSearch.Text);
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if(listBoxItems.SelectedItems.Count > 0)
            {
                listBoxCart.Items.Add(listBoxItems.SelectedItem);
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItems.Count > 0)
            {
                listBoxCart.Items.Remove(listBoxCart.SelectedItem);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            employeeBusiness.DeleteEmployee(Convert.ToInt32(dataGridEmployees.SelectedRows[0].Cells[0].Value));
            bs_employee.RemoveAt(dataGridEmployees.SelectedRows[0].Index);
        }

        private void buttonSearch2_Click(object sender, EventArgs e)
        {
            bs_employee.Filter =
               string.Format("Name LIKE '%{0}%' OR Username LIKE '%{0}%' OR Role LIKE '%{0}%'", textBoxSearch2.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }
    }
}

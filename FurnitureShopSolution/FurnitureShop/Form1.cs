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
        BindingList<Employee> emp;
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

            emp = new BindingList<Employee>(employeeBusiness.GetAllEmployees());
            dataGridEmployees.DataSource = emp;


            dataGridStock.DataSource = itemBusiness.GetInStockItems();
            listBoxItems.HorizontalScrollbar = true;
            foreach(var item in items)
              {
                listBoxItems.Items.Add(string.Format("{0} / Price:{1} / {2} / {3} / {4} / {5} / In stock:{6} / Discount:{7} ",item.ProductName,item.ProductPrice,item.ProductColor,item.ProductDescription,item.Type,item.Category, item.Stock, item.Discount));
              }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

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
            emp.RemoveAt(dataGridEmployees.SelectedRows[0].Index);
        }
    }
}

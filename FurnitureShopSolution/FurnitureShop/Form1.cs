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
        DataTable dt = new DataTable();
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

            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(decimal));
            dt.Columns.Add("ProductColor", typeof(string));
            dt.Columns.Add("ProductDescription", typeof(string));
            dt.Columns.Add("ProductType", typeof(string));

            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("Discount", typeof(int));

            dataGridStock.DataSource = itemBusiness.GetInStockItems();
            listBoxItems.HorizontalScrollbar = true;
            foreach(var item in items)
              {
                dt.Rows.Add(new object[] { item.ProductName, item.ProductPrice, item.ProductColor, item.ProductDescription, item.Type, item.Category, item.Stock, item.Discount });

                listBoxItems.Items.Add(string.Format("{0} / Price:{1} / {2} / {3} / {4} / {5} / In stock:{6} / Discount:{7} ",item.ProductName,item.ProductPrice,item.ProductColor,item.ProductDescription,item.Type,item.Category, item.Stock, item.Discount));
              }
            bs.DataSource = dt;
            dataGridStock.DataSource = bs;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
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
            emp.RemoveAt(dataGridEmployees.SelectedRows[0].Index);
        }
    }
}

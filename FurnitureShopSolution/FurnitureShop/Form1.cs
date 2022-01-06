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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>();
            items = itemBusiness.GetInStockItems();
            Register r = new Register();
            r.Show();
            Admin a = new Admin();
            a.Show();
            textBoxSearch.Clear();
            dataGridStock.DataSource = itemBusiness.GetInStockItems();
            dataGridEmployees.DataSource = employeeBusiness.GetAllEmployees();
            listBoxItems.HorizontalScrollbar = true;
            foreach(var item in items)
              {
                listBoxItems.Items.Add(string.Format("{0} / Price:{1} / {2} / {3} / {4} / {5} / In stock:{6} / Discount:{7} ",item.ProductName,item.ProductPrice,item.ProductColor,item.ProductDescription,item.Type,item.Category, item.Stock, item.Discount));
              }
            


        }
        void listBoxItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxItems.IndexFromPoint(e.Location);
            labelBill.Text = index.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBoxItems.SelectedItems.Count > 0)
            {
                listBoxCart.Items.Add(listBoxItems.SelectedItem);
                
            }

            
        }
    }
}

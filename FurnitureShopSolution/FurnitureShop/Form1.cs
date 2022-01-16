using BussniessLayer;
using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureShop
{
    public partial class Form1 : Form
    {
        private readonly IItemBusiness itemBusiness;
        private readonly IEmployeeBusiness employeeBusiness;
        private readonly IOrderBusiness orderBusiness;
        private readonly IOrderItemBusiness orderItemBusiness;

        BindingSource bs = new BindingSource();
        BindingSource bs_employee = new BindingSource();
        DataTable dt = new DataTable();
        DataTable dt_employee= new DataTable();
        public Form1(string Username)
        {
            InitializeComponent();

            IEmployeeRepository _employeeRepository = new EmployeeRepository();
            this.employeeBusiness = new EmployeeBusiness(_employeeRepository);

            IItemRepository _itemRepository = new ItemRepository();
            this.itemBusiness = new ItemBusiness(_itemRepository);

            IOrderItemRepository _orderItemRepository = new OrderItemRepository();
            this.orderItemBusiness = new OrderItemBusiness(_orderItemRepository);

            IOrderRepository _orderRepository = new OrderRepository();
            this.orderBusiness = new OrderBusiness(_orderRepository);

            labelUser.Text = Username;


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
                listBoxItems.Items.Add(string.Format("{0}| {1} / Price:{2} / {3} / {4} / {5} / {6} / In stock:{7} / Discount:{8} ",item.ItemID,item.ProductName,item.ProductPrice,item.ProductColor,item.ProductDescription,item.Type,item.Category, item.Stock, item.Discount));
              }
            bs.DataSource = dt;
            dataGridStock.DataSource = bs;

            refreshDataGridEmployee();
            
            
        }
        private void refreshDataGridEmployee()
        {
            List<Employee> _employees = new List<Employee>();
            _employees = employeeBusiness.GetAllEmployees();
            dataGridEmployees.DataSource = null;
            bs_employee.DataSource = null;
            dt_employee.Clear();
            foreach (var employees in _employees)
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
            decimal bill = decimal.Parse(labelBill.Text);

            if(listBoxItems.SelectedItems.Count > 0)
            {
                listBoxCart.Items.Add(listBoxItems.SelectedItem);

                string selectedItem = listBoxItems.SelectedItem.ToString();
                int position = selectedItem.IndexOf("|");
                selectedItem = selectedItem.Substring(0, position);

                foreach (var item in itemBusiness.GetAllItems())
                {
                    if(item.ItemID == double.Parse(selectedItem))
                    {
                        bill += item.ProductPrice;
                    }
                }
                labelBill.Text = bill.ToString();
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
        
        public static bool FormIsOpen(FormCollection application, Type formType)
        {
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formType);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
            if(FormIsOpen(Application.OpenForms,typeof(Register))==false)
             {
                refreshDataGridEmployee();
            }




        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            bs.Filter =
                string.Format("ProductName LIKE '%{0}%' OR ProductColor LIKE '%{0}%'", textBoxSearch.Text);
        }

        private void textBoxSearch2_TextChanged_1(object sender, EventArgs e)
        {
            bs_employee.Filter =
               string.Format("Name LIKE '%{0}%' OR Username LIKE '%{0}%' OR Role LIKE '%{0}%'", textBoxSearch2.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            Environment.Exit(1);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please confirm your sale!", "Confirm sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                /*OrderItem oI = new OrderItem();
                oI.ItemID =


                Order o = new Order();
                foreach(var employee in employeeBusiness.GetAllEmployees())
                {
                    if(employee.Username.Equals(labelUser.Text))
                    {
                        o.EmployeeID = employee.EmployeeID;
                    }
                }
                o.OrderDate = DateTime.Now;
                o.Bill = decimal.Parse(labelBill.Text);
                //o.OrderItemID
                */
                ;
            }

        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            refreshDataGridEmployee();
        }

        private void button_insertSupply_Click(object sender, EventArgs e)
        {
            string productName = textBox_productName.Text;
            string productType = textBox_productType.Text;
            string productColor = textBox_productColor.Text;
            string productDescription = textBox_productDescription.Text;
            decimal productPrice = Convert.ToDecimal(textBox_productPrice.Text.Trim());
            string productCategory = textBox_productCategory.Text;
            int productStock = Convert.ToInt32(textBox_productStock.Text.Trim());
            int productDiscount = Convert.ToInt32(textBox_productDiscount.Text.Trim());

            //i.ProductName, i.ProductPrice, i.ProductColor, i.ProductDescription, i.Type, i.Category, i.Stock, i.Discount);
            Item item1 = new Item(productName, productPrice, productColor, productDescription, productType, productCategory, productStock, productDiscount);

            if (itemBusiness.InsertItem(item1))
            {
                MessageBox.Show("Uspesno unet item");
                refreshStockData();

                textBox_productName.Clear();
                textBox_productType.Clear();
                textBox_productColor.Clear();
                textBox_productDescription.Clear();
                textBox_productPrice.Clear();
                textBox_productCategory.Clear();
                textBox_productStock.Clear();
                textBox_productDiscount.Clear();
            }
            else
                MessageBox.Show("Nije unet lepo podatak");


        }
        private void refreshStockData()
        {
            List<Item> items = new List<Item>();
            items = itemBusiness.GetInStockItems();
            dataGridStock.DataSource = null;
            bs.DataSource = null;
            dt.Clear();
            foreach (var item in items)
            {
                dt.Rows.Add(new object[] { item.ProductName, item.ProductPrice, item.ProductColor, item.ProductDescription, item.Type, item.Category, item.Stock, item.Discount });
            }
            bs.DataSource = dt;
            dataGridStock.DataSource = bs;
        }
    }
}

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
    public partial class FurnitureShop : Form
    {
        private readonly IItemBusiness itemBusiness;
        private readonly IEmployeeBusiness employeeBusiness;
        private readonly IOrderBusiness orderBusiness;
        private readonly IOrderItemBusiness orderItemBusiness;

        BindingSource bs = new BindingSource();
        BindingSource bs_employee = new BindingSource();
        DataTable dt = new DataTable();
        DataTable dt_employee= new DataTable();
        string role = "";
        public FurnitureShop(string Username)
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

        private void FurnitureShop_Load(object sender, EventArgs e)
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
            dt_employee.Columns.Add("Role", typeof(string));
            dt_employee.Columns.Add("ManagerID", typeof(int));


            dataGridStock.DataSource = itemBusiness.GetInStockItems();
            listBoxItems.HorizontalScrollbar = true;
            foreach (var item in items)
            {
                dt.Rows.Add(new object[] { item.ProductName, item.ProductPrice, item.ProductColor, item.ProductDescription, item.Type, item.Category, item.Stock, item.Discount });
                listBoxItems.Items.Add(string.Format("{0}| {1} / Price:{2} / {3} / {4} / {5} / {6} / In stock:{7} / Discount:{8} ", item.ItemID, item.ProductName, item.ProductPrice, item.ProductColor, item.ProductDescription, item.Type, item.Category, item.Stock, item.Discount));
            }
            bs.DataSource = dt;
            dataGridStock.DataSource = bs;

            refreshDataGridEmployee();

            foreach (var employee in employeeBusiness.GetAllEmployees())
            {
                if (employee.Username == labelUser.Text)
                {
                    role = employee.Role;
                }
            }
        }
        private void refreshDataGridEmployee()
        {
            dataGridEmployees.DataSource = null;
            bs_employee.DataSource = null;
            dt_employee.Clear();
            foreach (var employees in employeeBusiness.GetAllEmployees())
            {
                dt_employee.Rows.Add(new object[] { employees.EmployeeID, employees.Name, employees.Email, employees.PhoneNumber, employees.Address, employees.Username, employees.Role, employees.ManagerID });
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
           
            decimal bill = decimal.Parse(labelBill.Text);

            if (listBoxCart.SelectedItems.Count > 0)
            {
                listBoxCart.Items.Remove(listBoxCart.SelectedItem);

                string selectedItem = listBoxItems.SelectedItem.ToString();
                int position = selectedItem.IndexOf("|");
                selectedItem = selectedItem.Substring(0, position);

                foreach (var item in itemBusiness.GetAllItems())
                {
                    if (item.ItemID == double.Parse(selectedItem))
                    {
                        bill -= item.ProductPrice;
                    }
                }
                if (bill == 0)
                {
                    labelBill.Text = "0";
                }
                else
                {
                    labelBill.Text = bill.ToString();

                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(role.CompareTo("Administrator")==0)
            {
                employeeBusiness.DeleteEmployee(Convert.ToInt32(dataGridEmployees.SelectedRows[0].Cells[0].Value));
                bs_employee.RemoveAt(dataGridEmployees.SelectedRows[0].Index);
                return;
            }
            MessageBox.Show("You do not have permission to delete employees!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
            if (role.CompareTo("Administrator") == 0)
            { 
                Register r = new Register();
                r.ShowDialog();
                if (FormIsOpen(Application.OpenForms, typeof(Register)) == false)
                {
                    refreshDataGridEmployee();
                    return;
                }
            }
            MessageBox.Show("You do not have permission to add employees!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string[] words = textBoxSearch.Text.Split();
            string filter = "";
            int pom = 0;
            foreach(string word in words)
            {
                //just for now

                if (!word.Equals(' '))
                {

                
                if (pom==0)
                {
                    filter +=
                    string.Format("ProductName LIKE '%{0}%' OR ProductColor LIKE '%{0}%'", word);
                    pom = 1;
                }
                else
                {
                    filter +=
                    string.Format(" AND ProductColor LIKE '%{0}%'", word);

                }
                }
            }
            bs.Filter = filter;
            
        }

        private void textBoxSearch2_TextChanged_1(object sender, EventArgs e)
        {
            bs_employee.Filter =
               string.Format("Name LIKE '%{0}%' OR Username LIKE '%{0}%' OR Role LIKE '%{0}%'", textBoxSearch2.Text);
        }

        private void FurnitureShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (labelBill.Text == "0")
            {
                MessageBox.Show("You need to add items to the card to make a sale!", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Please confirm your sale!", "Confirm sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {


                    Order o = new Order();
                    foreach (var employee in employeeBusiness.GetAllEmployees())
                    {
                        if (employee.Username.Equals(labelUser.Text))
                        {
                            o.EmployeeID = employee.EmployeeID;
                        }
                    }
                    o.OrderDate = DateTime.Now;
                    o.Bill = decimal.Parse(labelBill.Text);
                    decimal discount = 0;




                    int order_ID = orderBusiness.GetAllOrders().Last().OrderID;



                    List<int> IDs = new List<int>();

                    foreach (string item in listBoxCart.Items)
                    {
                        int position = item.IndexOf("|");
                        IDs.Add(int.Parse(item.Substring(0, position)));
                    }


                    foreach (var itemID in IDs)
                    {
                        OrderItem oI = new OrderItem();
                        List<OrderItem> orderItems = new List<OrderItem>();
                        orderItems = orderItemBusiness.GetAllOrderItems();
                      


                        foreach (var item in itemBusiness.GetInStockItems())
                        {
                            int orderItem_ID = orderItemBusiness.GetAllOrderItems().Last().OrderItemID;

                            if (item.ItemID == itemID)
                            {
                                Item i = new Item();

                                i.ItemID = itemID;
                                i.ProductColor = item.ProductColor;
                                i.ProductDescription = item.ProductDescription;
                                i.ProductName = item.ProductName;
                                i.ProductPrice = item.ProductPrice;
                                if(item.Stock>0)
                                {
                                    i.Stock = item.Stock - 1;
                                }
                                i.Type = item.Type;
                                i.Category = item.Category;
                                i.Discount = item.Discount;

                                discount += i.Discount;

                               
                                oI.ItemID = item.ItemID;
                                oI.Quantity = 1;
                                oI.OrderID = order_ID;
                                orderItemBusiness.InsertOrderItem(oI);
                                orderItems.Add(oI);
                                itemBusiness.UpdateItem(i);
                                
                               
                            }
                        }
                    }
                    o.Bill *= (1 - (discount / 100));
                    orderBusiness.InsertOrder(o);

                    MessageBox.Show("The bill is: " + o.Bill+"\nDiscount:"+discount+"%", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    listBoxCart.Items.Clear();
                    labelBill.Text = "0";
                    refreshStockData();

                }
            }

        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            refreshDataGridEmployee();
        }

        private void button_insertSupply_Click(object sender, EventArgs e)
        {
            if (textBox_productName.Text == "" || textBox_productType.Text == "" || textBox_productColor.Text == ""
                ||  textBox_productPrice.Text == "" || textBox_productCategory.Text == "" || textBox_productStock.Text == "")
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string productName = textBox_productName.Text;
                string productType = textBox_productType.Text;
                string productColor = textBox_productColor.Text;
                string productDescription = textBox_productDescription.Text;
                decimal productPrice = Convert.ToDecimal(textBox_productPrice.Text.Trim());
                string productCategory = textBox_productCategory.Text;
                int productStock = Convert.ToInt32(textBox_productStock.Text.Trim());
                int productDiscount = Convert.ToInt32(textBox_productDiscount.Text.Trim());

                Item item1 = new Item(productName, productPrice, productColor, productDescription, productType, productCategory, productStock, productDiscount);

                if (itemBusiness.InsertItem(item1))
                {
                    MessageBox.Show("Item successfully added!");
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
                    MessageBox.Show("Error while inserting item! Try again!");
            }


        }
        private void refreshStockData()
        {
            dataGridStock.DataSource = null;
            bs.DataSource = null;
            dt.Clear();
            foreach (var item in itemBusiness.GetInStockItems())
            {
                dt.Rows.Add(new object[] { item.ProductName, item.ProductPrice, item.ProductColor, item.ProductDescription, item.Type, item.Category, item.Stock, item.Discount });
            }
            bs.DataSource = dt;
            dataGridStock.DataSource = bs;
        }
    }
}

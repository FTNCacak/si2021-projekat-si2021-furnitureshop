using BussniessLayer;
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
            textBoxSearch.Clear();
            dataGridStock.DataSource = itemBusiness.GetInStockItems();
            dataGridEmployees.DataSource = employeeBusiness.GetAllEmployees();
            
        }
    }
}

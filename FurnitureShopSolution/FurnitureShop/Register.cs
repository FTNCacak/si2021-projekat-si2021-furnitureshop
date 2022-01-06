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
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LogIn l=new LogIn();
            l.Close();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
        }
    }
}

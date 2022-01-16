namespace FurnitureShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.Sell = new System.Windows.Forms.TabPage();
            this.panelSale = new System.Windows.Forms.Panel();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBill = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_productDescription = new System.Windows.Forms.TextBox();
            this.textBox_productDiscount = new System.Windows.Forms.TextBox();
            this.textBox_productStock = new System.Windows.Forms.TextBox();
            this.textBox_productColor = new System.Windows.Forms.TextBox();
            this.textBox_productCategory = new System.Windows.Forms.TextBox();
            this.textBox_productPrice = new System.Windows.Forms.TextBox();
            this.textBox_productType = new System.Windows.Forms.TextBox();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.button_insertSupply = new System.Windows.Forms.Button();
            this.label_productDiscount = new System.Windows.Forms.Label();
            this.label_productStock = new System.Windows.Forms.Label();
            this.label_productCategory = new System.Windows.Forms.Label();
            this.label_productType = new System.Windows.Forms.Label();
            this.label_productDescription = new System.Windows.Forms.Label();
            this.label_productColor = new System.Windows.Forms.Label();
            this.label_productPrice = new System.Windows.Forms.Label();
            this.label_productName = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.tabControlMenu.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.Sell.SuspendLayout();
            this.panelSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.HomeTab);
            this.tabControlMenu.Controls.Add(this.Sell);
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage3);
            this.tabControlMenu.Location = new System.Drawing.Point(22, 25);
            this.tabControlMenu.MaximumSize = new System.Drawing.Size(800, 450);
            this.tabControlMenu.MinimumSize = new System.Drawing.Size(200, 350);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(745, 426);
            this.tabControlMenu.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.HomeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeTab.Controls.Add(this.pictureBox1);
            this.HomeTab.Controls.Add(this.buttonSearch);
            this.HomeTab.Controls.Add(this.textBoxSearch);
            this.HomeTab.Controls.Add(this.dataGridStock);
            this.HomeTab.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(15);
            this.HomeTab.Size = new System.Drawing.Size(737, 400);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FurnitureShop.Properties.Resources.search_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(122, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Tan;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(322, 75);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 26);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Tan;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Snow;
            this.textBoxSearch.Location = new System.Drawing.Point(155, 39);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(444, 30);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridStock
            // 
            this.dataGridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridStock.Location = new System.Drawing.Point(18, 114);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.RowHeadersWidth = 51;
            this.dataGridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStock.Size = new System.Drawing.Size(701, 262);
            this.dataGridStock.TabIndex = 0;
            // 
            // Sell
            // 
            this.Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.Sell.Controls.Add(this.panelSale);
            this.Sell.Controls.Add(this.label1);
            this.Sell.Location = new System.Drawing.Point(4, 22);
            this.Sell.Name = "Sell";
            this.Sell.Padding = new System.Windows.Forms.Padding(3);
            this.Sell.Size = new System.Drawing.Size(737, 400);
            this.Sell.TabIndex = 1;
            this.Sell.Text = "Sale";
            // 
            // panelSale
            // 
            this.panelSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSale.Controls.Add(this.buttonSell);
            this.panelSale.Controls.Add(this.buttonRemoveItem);
            this.panelSale.Controls.Add(this.buttonAddItem);
            this.panelSale.Controls.Add(this.label6);
            this.panelSale.Controls.Add(this.listBoxItems);
            this.panelSale.Controls.Add(this.listBoxCart);
            this.panelSale.Controls.Add(this.pictureBox2);
            this.panelSale.Controls.Add(this.label5);
            this.panelSale.Controls.Add(this.panel1);
            this.panelSale.Controls.Add(this.label3);
            this.panelSale.ForeColor = System.Drawing.SystemColors.Window;
            this.panelSale.Location = new System.Drawing.Point(57, 55);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(633, 315);
            this.panelSale.TabIndex = 1;
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.Tan;
            this.buttonSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSell.Location = new System.Drawing.Point(273, 257);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(94, 42);
            this.buttonSell.TabIndex = 11;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.BackColor = System.Drawing.Color.Tan;
            this.buttonRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonRemoveItem.Location = new System.Drawing.Point(292, 142);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(75, 42);
            this.buttonRemoveItem.TabIndex = 10;
            this.buttonRemoveItem.Text = "Remove item from Cart";
            this.buttonRemoveItem.UseVisualStyleBackColor = false;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.Tan;
            this.buttonAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonAddItem.Location = new System.Drawing.Point(292, 94);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 42);
            this.buttonAddItem.TabIndex = 9;
            this.buttonAddItem.Text = "Add item to Cart";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(17, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Items:";
            // 
            // listBoxItems
            // 
            this.listBoxItems.BackColor = System.Drawing.Color.Tan;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(20, 66);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(253, 134);
            this.listBoxItems.Sorted = true;
            this.listBoxItems.TabIndex = 7;
            // 
            // listBoxCart
            // 
            this.listBoxCart.BackColor = System.Drawing.Color.Tan;
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(388, 66);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(202, 134);
            this.listBoxCart.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FurnitureShop.Properties.Resources.Double_J_Design_Diagram_Free_Shopping_cart;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(366, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(399, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shoping cart:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelBill);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(455, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 24);
            this.panel1.TabIndex = 3;
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.Location = new System.Drawing.Point(-1, 4);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(13, 13);
            this.labelBill.TabIndex = 1;
            this.labelBill.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(422, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(304, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a new sale";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.tabPage1.Controls.Add(this.pictureBoxRefresh);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.textBoxSearch2);
            this.tabPage1.Controls.Add(this.buttonSearch2);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.dataGridEmployees);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(737, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Employees";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BackgroundImage = global::FurnitureShop.Properties.Resources.arrow_refresh_1_icon;
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(697, 375);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(24, 22);
            this.pictureBoxRefresh.TabIndex = 8;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Tan;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(139, 41);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 30);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.BackColor = System.Drawing.Color.Tan;
            this.textBoxSearch2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch2.ForeColor = System.Drawing.Color.Snow;
            this.textBoxSearch2.Location = new System.Drawing.Point(278, 41);
            this.textBoxSearch2.Multiline = true;
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(314, 30);
            this.textBoxSearch2.TabIndex = 6;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBoxSearch2_TextChanged_1);
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.BackColor = System.Drawing.Color.Tan;
            this.buttonSearch2.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearch2.FlatAppearance.BorderSize = 2;
            this.buttonSearch2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.buttonSearch2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearch2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch2.ForeColor = System.Drawing.Color.White;
            this.buttonSearch2.Location = new System.Drawing.Point(598, 41);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(123, 30);
            this.buttonSearch2.TabIndex = 4;
            this.buttonSearch2.Text = "Search";
            this.buttonSearch2.UseVisualStyleBackColor = false;
            this.buttonSearch2.Click += new System.EventHandler(this.buttonSearch2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Tan;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(20, 41);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(113, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridEmployees
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEmployees.Location = new System.Drawing.Point(20, 95);
            this.dataGridEmployees.Name = "dataGridEmployees";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEmployees.RowHeadersWidth = 51;
            this.dataGridEmployees.Size = new System.Drawing.Size(701, 276);
            this.dataGridEmployees.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox_productDescription);
            this.tabPage3.Controls.Add(this.textBox_productDiscount);
            this.tabPage3.Controls.Add(this.textBox_productStock);
            this.tabPage3.Controls.Add(this.textBox_productColor);
            this.tabPage3.Controls.Add(this.textBox_productCategory);
            this.tabPage3.Controls.Add(this.textBox_productPrice);
            this.tabPage3.Controls.Add(this.textBox_productType);
            this.tabPage3.Controls.Add(this.textBox_productName);
            this.tabPage3.Controls.Add(this.button_insertSupply);
            this.tabPage3.Controls.Add(this.label_productDiscount);
            this.tabPage3.Controls.Add(this.label_productStock);
            this.tabPage3.Controls.Add(this.label_productCategory);
            this.tabPage3.Controls.Add(this.label_productType);
            this.tabPage3.Controls.Add(this.label_productDescription);
            this.tabPage3.Controls.Add(this.label_productColor);
            this.tabPage3.Controls.Add(this.label_productPrice);
            this.tabPage3.Controls.Add(this.label_productName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(737, 400);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Supply";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(251, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 54);
            this.label8.TabIndex = 36;
            this.label8.Text = "Add new item";
            // 
            // textBox_productDescription
            // 
            this.textBox_productDescription.BackColor = System.Drawing.Color.Tan;
            this.textBox_productDescription.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productDescription.Location = new System.Drawing.Point(301, 244);
            this.textBox_productDescription.Multiline = true;
            this.textBox_productDescription.Name = "textBox_productDescription";
            this.textBox_productDescription.Size = new System.Drawing.Size(369, 59);
            this.textBox_productDescription.TabIndex = 35;
            // 
            // textBox_productDiscount
            // 
            this.textBox_productDiscount.BackColor = System.Drawing.Color.Tan;
            this.textBox_productDiscount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productDiscount.Location = new System.Drawing.Point(79, 244);
            this.textBox_productDiscount.Name = "textBox_productDiscount";
            this.textBox_productDiscount.Size = new System.Drawing.Size(162, 22);
            this.textBox_productDiscount.TabIndex = 34;
            // 
            // textBox_productStock
            // 
            this.textBox_productStock.BackColor = System.Drawing.Color.Tan;
            this.textBox_productStock.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productStock.Location = new System.Drawing.Point(508, 186);
            this.textBox_productStock.Name = "textBox_productStock";
            this.textBox_productStock.Size = new System.Drawing.Size(162, 22);
            this.textBox_productStock.TabIndex = 33;
            // 
            // textBox_productColor
            // 
            this.textBox_productColor.BackColor = System.Drawing.Color.Tan;
            this.textBox_productColor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productColor.Location = new System.Drawing.Point(301, 184);
            this.textBox_productColor.Name = "textBox_productColor";
            this.textBox_productColor.Size = new System.Drawing.Size(170, 22);
            this.textBox_productColor.TabIndex = 32;
            // 
            // textBox_productCategory
            // 
            this.textBox_productCategory.BackColor = System.Drawing.Color.Tan;
            this.textBox_productCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productCategory.Location = new System.Drawing.Point(79, 184);
            this.textBox_productCategory.Name = "textBox_productCategory";
            this.textBox_productCategory.Size = new System.Drawing.Size(162, 22);
            this.textBox_productCategory.TabIndex = 31;
            // 
            // textBox_productPrice
            // 
            this.textBox_productPrice.BackColor = System.Drawing.Color.Tan;
            this.textBox_productPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productPrice.Location = new System.Drawing.Point(508, 120);
            this.textBox_productPrice.Name = "textBox_productPrice";
            this.textBox_productPrice.Size = new System.Drawing.Size(162, 22);
            this.textBox_productPrice.TabIndex = 30;
            // 
            // textBox_productType
            // 
            this.textBox_productType.BackColor = System.Drawing.Color.Tan;
            this.textBox_productType.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productType.Location = new System.Drawing.Point(301, 120);
            this.textBox_productType.Name = "textBox_productType";
            this.textBox_productType.Size = new System.Drawing.Size(162, 22);
            this.textBox_productType.TabIndex = 29;
            // 
            // textBox_productName
            // 
            this.textBox_productName.BackColor = System.Drawing.Color.Tan;
            this.textBox_productName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_productName.Location = new System.Drawing.Point(79, 120);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(162, 22);
            this.textBox_productName.TabIndex = 28;
            // 
            // button_insertSupply
            // 
            this.button_insertSupply.BackColor = System.Drawing.Color.Tan;
            this.button_insertSupply.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_insertSupply.Location = new System.Drawing.Point(301, 336);
            this.button_insertSupply.Name = "button_insertSupply";
            this.button_insertSupply.Size = new System.Drawing.Size(113, 37);
            this.button_insertSupply.TabIndex = 27;
            this.button_insertSupply.Text = "Insert supply";
            this.button_insertSupply.UseVisualStyleBackColor = false;
            this.button_insertSupply.Click += new System.EventHandler(this.button_insertSupply_Click);
            // 
            // label_productDiscount
            // 
            this.label_productDiscount.AutoSize = true;
            this.label_productDiscount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productDiscount.Location = new System.Drawing.Point(75, 209);
            this.label_productDiscount.Name = "label_productDiscount";
            this.label_productDiscount.Size = new System.Drawing.Size(89, 28);
            this.label_productDiscount.TabIndex = 26;
            this.label_productDiscount.Text = "Discount";
            // 
            // label_productStock
            // 
            this.label_productStock.AutoSize = true;
            this.label_productStock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productStock.Location = new System.Drawing.Point(504, 150);
            this.label_productStock.Name = "label_productStock";
            this.label_productStock.Size = new System.Drawing.Size(60, 28);
            this.label_productStock.TabIndex = 25;
            this.label_productStock.Text = "Stock";
            // 
            // label_productCategory
            // 
            this.label_productCategory.AutoSize = true;
            this.label_productCategory.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productCategory.Location = new System.Drawing.Point(75, 149);
            this.label_productCategory.Name = "label_productCategory";
            this.label_productCategory.Size = new System.Drawing.Size(166, 28);
            this.label_productCategory.TabIndex = 24;
            this.label_productCategory.Text = "Product Category";
            // 
            // label_productType
            // 
            this.label_productType.AutoSize = true;
            this.label_productType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productType.Location = new System.Drawing.Point(297, 85);
            this.label_productType.Name = "label_productType";
            this.label_productType.Size = new System.Drawing.Size(53, 28);
            this.label_productType.TabIndex = 23;
            this.label_productType.Text = "Type";
            // 
            // label_productDescription
            // 
            this.label_productDescription.AutoSize = true;
            this.label_productDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productDescription.Location = new System.Drawing.Point(297, 209);
            this.label_productDescription.Name = "label_productDescription";
            this.label_productDescription.Size = new System.Drawing.Size(186, 28);
            this.label_productDescription.TabIndex = 22;
            this.label_productDescription.Text = "Product Description";
            // 
            // label_productColor
            // 
            this.label_productColor.AutoSize = true;
            this.label_productColor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productColor.Location = new System.Drawing.Point(297, 149);
            this.label_productColor.Name = "label_productColor";
            this.label_productColor.Size = new System.Drawing.Size(131, 28);
            this.label_productColor.TabIndex = 21;
            this.label_productColor.Text = "Product color";
            // 
            // label_productPrice
            // 
            this.label_productPrice.AutoSize = true;
            this.label_productPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productPrice.Location = new System.Drawing.Point(504, 85);
            this.label_productPrice.Name = "label_productPrice";
            this.label_productPrice.Size = new System.Drawing.Size(129, 28);
            this.label_productPrice.TabIndex = 20;
            this.label_productPrice.Text = "Product price";
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productName.Location = new System.Drawing.Point(75, 85);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(138, 28);
            this.label_productName.TabIndex = 19;
            this.label_productName.Text = "Product Name";
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Bisque;
            this.labelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUser.Location = new System.Drawing.Point(407, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUser.Size = new System.Drawing.Size(362, 35);
            this.labelUser.TabIndex = 4;
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(791, 458);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tabControlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture Shop";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            this.Sell.ResumeLayout(false);
            this.Sell.PerformLayout();
            this.panelSale.ResumeLayout(false);
            this.panelSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage Sell;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridEmployees;
        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_productDescription;
        private System.Windows.Forms.TextBox textBox_productDiscount;
        private System.Windows.Forms.TextBox textBox_productStock;
        private System.Windows.Forms.TextBox textBox_productColor;
        private System.Windows.Forms.TextBox textBox_productCategory;
        private System.Windows.Forms.TextBox textBox_productPrice;
        private System.Windows.Forms.TextBox textBox_productType;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Button button_insertSupply;
        private System.Windows.Forms.Label label_productDiscount;
        private System.Windows.Forms.Label label_productStock;
        private System.Windows.Forms.Label label_productCategory;
        private System.Windows.Forms.Label label_productType;
        private System.Windows.Forms.Label label_productDescription;
        private System.Windows.Forms.Label label_productColor;
        private System.Windows.Forms.Label label_productPrice;
        private System.Windows.Forms.Label label_productName;
    }
}


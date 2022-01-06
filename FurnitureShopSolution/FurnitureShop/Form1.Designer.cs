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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.Sell = new System.Windows.Forms.TabPage();
            this.panelSale = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelBill = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlMenu.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.Sell.SuspendLayout();
            this.panelSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.HomeTab);
            this.tabControlMenu.Controls.Add(this.Sell);
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage3);
            this.tabControlMenu.Location = new System.Drawing.Point(29, 12);
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
            this.textBoxSearch.Text = "ew";
            // 
            // dataGridStock
            // 
            this.dataGridStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(18, 120);
            this.dataGridStock.Name = "dataGridStock";
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
            this.panelSale.Controls.Add(this.button1);
            this.panelSale.Controls.Add(this.label6);
            this.panelSale.Controls.Add(this.listBoxItems);
            this.panelSale.Controls.Add(this.listBoxCart);
            this.panelSale.Controls.Add(this.pictureBox2);
            this.panelSale.Controls.Add(this.label5);
            this.panelSale.Controls.Add(this.panel1);
            this.panelSale.Controls.Add(this.label3);
            this.panelSale.Controls.Add(this.label2);
            this.panelSale.Controls.Add(this.dateTimePicker1);
            this.panelSale.ForeColor = System.Drawing.SystemColors.Window;
            this.panelSale.Location = new System.Drawing.Point(65, 70);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(633, 315);
            this.panelSale.TabIndex = 1;
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
            this.listBoxItems.Size = new System.Drawing.Size(253, 160);
            this.listBoxItems.Sorted = true;
            this.listBoxItems.TabIndex = 7;
            // 
            // listBoxCart
            // 
            this.listBoxCart.BackColor = System.Drawing.Color.Tan;
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(388, 66);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(202, 160);
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
            this.panel1.Location = new System.Drawing.Point(455, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 24);
            this.panel1.TabIndex = 3;
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
            this.label3.Location = new System.Drawing.Point(422, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(17, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a new sale";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.tabPage1.Controls.Add(this.dataGridEmployees);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(737, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Employees";
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.Location = new System.Drawing.Point(20, 109);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.Size = new System.Drawing.Size(701, 262);
            this.dataGridEmployees.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(737, 400);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Supply";
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.Location = new System.Drawing.Point(-1, 4);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(0, 13);
            this.labelBill.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(292, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add item to Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Furniture Shop";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Button button1;
    }
}


﻿namespace FurnitureShop
{
    partial class AdminVerification
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAVusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAVpassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // textBoxAVusername
            // 
            this.textBoxAVusername.Location = new System.Drawing.Point(117, 58);
            this.textBoxAVusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAVusername.Name = "textBoxAVusername";
            this.textBoxAVusername.Size = new System.Drawing.Size(133, 22);
            this.textBoxAVusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // textBoxAVpassword
            // 
            this.textBoxAVpassword.Location = new System.Drawing.Point(117, 110);
            this.textBoxAVpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAVpassword.Name = "textBoxAVpassword";
            this.textBoxAVpassword.Size = new System.Drawing.Size(133, 22);
            this.textBoxAVpassword.TabIndex = 3;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Sienna;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRegister.Location = new System.Drawing.Point(21, 169);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(231, 46);
            this.buttonRegister.TabIndex = 18;
            this.buttonRegister.Text = "Add employee";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.ForeColor = System.Drawing.Color.Sienna;
            this.Registration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Registration.Location = new System.Drawing.Point(12, 9);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(216, 31);
            this.Registration.TabIndex = 20;
            this.Registration.Text = "Admin verification";
            // 
            // AdminVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(275, 228);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxAVpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAVusername);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminVerification";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminVerification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAVusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAVpassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label Registration;
    }
}
namespace Gubich
{
    partial class MainMenuForm
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
            this.ProductsButton = new System.Windows.Forms.Button();
            this.StorageButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.ProductTypesButton = new System.Windows.Forms.Button();
            this.UnitsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(114, 80);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsButton.TabIndex = 0;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // StorageButton
            // 
            this.StorageButton.Location = new System.Drawing.Point(114, 109);
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.Size = new System.Drawing.Size(75, 23);
            this.StorageButton.TabIndex = 1;
            this.StorageButton.Text = "Storage";
            this.StorageButton.UseVisualStyleBackColor = true;
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(114, 138);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(75, 23);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Location = new System.Drawing.Point(114, 167);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(75, 23);
            this.ClientsButton.TabIndex = 3;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // ProductTypesButton
            // 
            this.ProductTypesButton.Location = new System.Drawing.Point(114, 196);
            this.ProductTypesButton.Name = "ProductTypesButton";
            this.ProductTypesButton.Size = new System.Drawing.Size(75, 23);
            this.ProductTypesButton.TabIndex = 4;
            this.ProductTypesButton.Text = "ProductTypesButton";
            this.ProductTypesButton.UseVisualStyleBackColor = true;
            this.ProductTypesButton.Click += new System.EventHandler(this.ProductTypesButton_Click);
            // 
            // UnitsButton
            // 
            this.UnitsButton.Location = new System.Drawing.Point(114, 225);
            this.UnitsButton.Name = "UnitsButton";
            this.UnitsButton.Size = new System.Drawing.Size(75, 23);
            this.UnitsButton.TabIndex = 5;
            this.UnitsButton.Text = "UnitsButton";
            this.UnitsButton.UseVisualStyleBackColor = true;
            this.UnitsButton.Click += new System.EventHandler(this.UnitsButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 272);
            this.Controls.Add(this.UnitsButton);
            this.Controls.Add(this.ProductTypesButton);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.StorageButton);
            this.Controls.Add(this.ProductsButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button StorageButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button ProductTypesButton;
        private System.Windows.Forms.Button UnitsButton;
    }
}
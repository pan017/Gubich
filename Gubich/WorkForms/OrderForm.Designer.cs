namespace Gubich.WorkForms
{
    partial class OrderForm
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
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetFindButton = new System.Windows.Forms.Button();
            this.FindQueryTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToAddRows = false;
            this.OrderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.OrderDateColumn,
            this.ProductColumn,
            this.ClientColumn,
            this.CountColumn,
            this.ManagerColumn});
            this.OrderDataGridView.Location = new System.Drawing.Point(12, 12);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.Size = new System.Drawing.Size(682, 208);
            this.OrderDataGridView.TabIndex = 0;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(12, 226);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(163, 23);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "Новый заказ";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Location = new System.Drawing.Point(181, 226);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(152, 23);
            this.EditOrderButton.TabIndex = 2;
            this.EditOrderButton.Text = "Изменить";
            this.EditOrderButton.UseVisualStyleBackColor = true;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // OrderDateColumn
            // 
            this.OrderDateColumn.HeaderText = "Дата";
            this.OrderDateColumn.Name = "OrderDateColumn";
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Товар";
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.Width = 150;
            // 
            // ClientColumn
            // 
            this.ClientColumn.HeaderText = "Клиент";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.Width = 150;
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Количесвто";
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.Width = 80;
            // 
            // ManagerColumn
            // 
            this.ManagerColumn.HeaderText = "Менеджер";
            this.ManagerColumn.Name = "ManagerColumn";
            this.ManagerColumn.Width = 150;
            // 
            // ResetFindButton
            // 
            this.ResetFindButton.Location = new System.Drawing.Point(615, 226);
            this.ResetFindButton.Name = "ResetFindButton";
            this.ResetFindButton.Size = new System.Drawing.Size(75, 23);
            this.ResetFindButton.TabIndex = 11;
            this.ResetFindButton.Text = "Сброс";
            this.ResetFindButton.UseVisualStyleBackColor = true;
            this.ResetFindButton.Click += new System.EventHandler(this.ResetFindButton_Click);
            // 
            // FindQueryTextBox
            // 
            this.FindQueryTextBox.Location = new System.Drawing.Point(404, 229);
            this.FindQueryTextBox.Name = "FindQueryTextBox";
            this.FindQueryTextBox.Size = new System.Drawing.Size(124, 20);
            this.FindQueryTextBox.TabIndex = 10;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(534, 226);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 261);
            this.Controls.Add(this.ResetFindButton);
            this.Controls.Add(this.FindQueryTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrderDataGridView);
            this.Name = "OrderForm";
            this.Text = "Заказы";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerColumn;
        private System.Windows.Forms.Button ResetFindButton;
        private System.Windows.Forms.TextBox FindQueryTextBox;
        private System.Windows.Forms.Button FindButton;
    }
}
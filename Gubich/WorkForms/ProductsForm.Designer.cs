namespace Gubich.WorkForms
{
    partial class ProductsForm
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
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharackteristicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindQueryTextBox = new System.Windows.Forms.TextBox();
            this.ResetFindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn,
            this.PriceColumn,
            this.DescriptionColumn,
            this.CharackteristicColumn,
            this.UnitColumn,
            this.ProductTypeColumn});
            this.ProductDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.Size = new System.Drawing.Size(724, 217);
            this.ProductDataGridView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Наименование";
            this.NameColumn.Name = "NameColumn";
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.Name = "PriceColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Описание";
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // CharackteristicColumn
            // 
            this.CharackteristicColumn.HeaderText = "Характеристика";
            this.CharackteristicColumn.Name = "CharackteristicColumn";
            // 
            // UnitColumn
            // 
            this.UnitColumn.HeaderText = "Ед.изм.";
            this.UnitColumn.Name = "UnitColumn";
            // 
            // ProductTypeColumn
            // 
            this.ProductTypeColumn.HeaderText = "Тип";
            this.ProductTypeColumn.Name = "ProductTypeColumn";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(12, 247);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(137, 23);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Добавить товар";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Location = new System.Drawing.Point(155, 247);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(75, 23);
            this.EditProductButton.TabIndex = 2;
            this.EditProductButton.Text = "Изменить";
            this.EditProductButton.UseVisualStyleBackColor = true;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(578, 247);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindQueryTextBox
            // 
            this.FindQueryTextBox.Location = new System.Drawing.Point(448, 247);
            this.FindQueryTextBox.Name = "FindQueryTextBox";
            this.FindQueryTextBox.Size = new System.Drawing.Size(124, 20);
            this.FindQueryTextBox.TabIndex = 4;
            // 
            // ResetFindButton
            // 
            this.ResetFindButton.Location = new System.Drawing.Point(659, 247);
            this.ResetFindButton.Name = "ResetFindButton";
            this.ResetFindButton.Size = new System.Drawing.Size(75, 23);
            this.ResetFindButton.TabIndex = 5;
            this.ResetFindButton.Text = "Сброс";
            this.ResetFindButton.UseVisualStyleBackColor = true;
            this.ResetFindButton.Click += new System.EventHandler(this.ResetFindButton_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 286);
            this.Controls.Add(this.ResetFindButton);
            this.Controls.Add(this.FindQueryTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductDataGridView);
            this.Name = "ProductsForm";
            this.Text = "Продукция";
            this.Activated += new System.EventHandler(this.ProductsForm_Activated);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharackteristicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTypeColumn;
        private System.Windows.Forms.Button EditProductButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindQueryTextBox;
        private System.Windows.Forms.Button ResetFindButton;
    }
}
namespace Gubich.WorkForms
{
    partial class ProductTypesForm
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
            this.ProductTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductType = new System.Windows.Forms.Button();
            this.WordkingTextBox = new System.Windows.Forms.TextBox();
            this.SaveProductTypeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductTypesDataGridView
            // 
            this.ProductTypesDataGridView.AllowUserToAddRows = false;
            this.ProductTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn});
            this.ProductTypesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductTypesDataGridView.Name = "ProductTypesDataGridView";
            this.ProductTypesDataGridView.Size = new System.Drawing.Size(218, 237);
            this.ProductTypesDataGridView.TabIndex = 0;
            this.ProductTypesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductTypesDataGridView_CellClick);
            this.ProductTypesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductTypesDataGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Тип продукта";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 150;
            // 
            // AddProductType
            // 
            this.AddProductType.Location = new System.Drawing.Point(239, 55);
            this.AddProductType.Name = "AddProductType";
            this.AddProductType.Size = new System.Drawing.Size(138, 23);
            this.AddProductType.TabIndex = 1;
            this.AddProductType.Text = "Новый";
            this.AddProductType.UseVisualStyleBackColor = true;
            this.AddProductType.Click += new System.EventHandler(this.AddProductType_Click);
            // 
            // WordkingTextBox
            // 
            this.WordkingTextBox.Location = new System.Drawing.Point(239, 29);
            this.WordkingTextBox.Name = "WordkingTextBox";
            this.WordkingTextBox.Size = new System.Drawing.Size(138, 20);
            this.WordkingTextBox.TabIndex = 2;
            // 
            // SaveProductTypeButton
            // 
            this.SaveProductTypeButton.Location = new System.Drawing.Point(239, 84);
            this.SaveProductTypeButton.Name = "SaveProductTypeButton";
            this.SaveProductTypeButton.Size = new System.Drawing.Size(138, 23);
            this.SaveProductTypeButton.TabIndex = 3;
            this.SaveProductTypeButton.Text = "Сохранить";
            this.SaveProductTypeButton.UseVisualStyleBackColor = true;
            this.SaveProductTypeButton.Click += new System.EventHandler(this.SaveProductTypeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип продукта";
            // 
            // ProductTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveProductTypeButton);
            this.Controls.Add(this.WordkingTextBox);
            this.Controls.Add(this.AddProductType);
            this.Controls.Add(this.ProductTypesDataGridView);
            this.Name = "ProductTypesForm";
            this.Text = "Тип товара";
            this.Activated += new System.EventHandler(this.ProductTypesForm_Activated);
            this.Load += new System.EventHandler(this.ProductTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductTypesDataGridView;
        private System.Windows.Forms.Button AddProductType;
        private System.Windows.Forms.TextBox WordkingTextBox;
        private System.Windows.Forms.Button SaveProductTypeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Label label1;
    }
}
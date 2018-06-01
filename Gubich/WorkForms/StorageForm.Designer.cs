namespace Gubich.WorkForms
{
    partial class StorageForm
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
            this.StorageDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StorageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageDataGridView
            // 
            this.StorageDataGridView.AllowUserToAddRows = false;
            this.StorageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.ProductNameColumn,
            this.CountColumn});
            this.StorageDataGridView.Location = new System.Drawing.Point(12, 12);
            this.StorageDataGridView.Name = "StorageDataGridView";
            this.StorageDataGridView.Size = new System.Drawing.Size(252, 292);
            this.StorageDataGridView.TabIndex = 0;
            this.StorageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageDataGridView_CellClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Наименование";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Количество";
            this.CountColumn.Name = "CountColumn";
            // 
            // ProductsCountNumericUpDown
            // 
            this.ProductsCountNumericUpDown.Location = new System.Drawing.Point(12, 334);
            this.ProductsCountNumericUpDown.Name = "ProductsCountNumericUpDown";
            this.ProductsCountNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.ProductsCountNumericUpDown.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(149, 331);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество";
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductsCountNumericUpDown);
            this.Controls.Add(this.StorageDataGridView);
            this.Name = "StorageForm";
            this.Text = "Склад";
            this.Activated += new System.EventHandler(this.StorageForm_Activated);
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StorageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.NumericUpDown ProductsCountNumericUpDown;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
    }
}
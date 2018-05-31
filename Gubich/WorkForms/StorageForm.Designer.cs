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
            ((System.ComponentModel.ISupportInitialize)(this.StorageDataGridView)).BeginInit();
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
            this.StorageDataGridView.Size = new System.Drawing.Size(296, 150);
            this.StorageDataGridView.TabIndex = 0;
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
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.StorageDataGridView);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StorageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
    }
}
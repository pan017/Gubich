namespace Gubich.WorkForms
{
    partial class ClientsForm
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
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.EditClientButton = new System.Windows.Forms.Button();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetFindButton = new System.Windows.Forms.Button();
            this.FindQueryTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.OrganizationColumn,
            this.PhoneColumn,
            this.AdresColumn});
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(607, 211);
            this.clientsDataGridView.TabIndex = 0;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(12, 229);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(176, 23);
            this.AddClientButton.TabIndex = 1;
            this.AddClientButton.Text = "Новый клиент";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // EditClientButton
            // 
            this.EditClientButton.Location = new System.Drawing.Point(194, 229);
            this.EditClientButton.Name = "EditClientButton";
            this.EditClientButton.Size = new System.Drawing.Size(176, 23);
            this.EditClientButton.TabIndex = 3;
            this.EditClientButton.Text = "Изменить клиента";
            this.EditClientButton.UseVisualStyleBackColor = true;
            this.EditClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 150;
            // 
            // OrganizationColumn
            // 
            this.OrganizationColumn.HeaderText = "Организация";
            this.OrganizationColumn.Name = "OrganizationColumn";
            this.OrganizationColumn.Width = 150;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Телефон";
            this.PhoneColumn.Name = "PhoneColumn";
            // 
            // AdresColumn
            // 
            this.AdresColumn.HeaderText = "Адрес";
            this.AdresColumn.Name = "AdresColumn";
            this.AdresColumn.Width = 150;
            // 
            // ResetFindButton
            // 
            this.ResetFindButton.Location = new System.Drawing.Point(223, 255);
            this.ResetFindButton.Name = "ResetFindButton";
            this.ResetFindButton.Size = new System.Drawing.Size(75, 23);
            this.ResetFindButton.TabIndex = 8;
            this.ResetFindButton.Text = "Сброс";
            this.ResetFindButton.UseVisualStyleBackColor = true;
            this.ResetFindButton.Click += new System.EventHandler(this.ResetFindButton_Click);
            // 
            // FindQueryTextBox
            // 
            this.FindQueryTextBox.Location = new System.Drawing.Point(12, 258);
            this.FindQueryTextBox.Name = "FindQueryTextBox";
            this.FindQueryTextBox.Size = new System.Drawing.Size(124, 20);
            this.FindQueryTextBox.TabIndex = 7;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(142, 255);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 288);
            this.Controls.Add(this.ResetFindButton);
            this.Controls.Add(this.FindQueryTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.EditClientButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.clientsDataGridView);
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            this.Activated += new System.EventHandler(this.ClientsForm_Activated);
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button EditClientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresColumn;
        private System.Windows.Forms.Button ResetFindButton;
        private System.Windows.Forms.TextBox FindQueryTextBox;
        private System.Windows.Forms.Button FindButton;
    }
}
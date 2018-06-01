namespace Gubich.WorkForms
{
    partial class ManagersForm
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
            this.ManagersDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerBrithdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNewManagerButton = new System.Windows.Forms.Button();
            this.EditManagerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagersDataGridView
            // 
            this.ManagersDataGridView.AllowUserToAddRows = false;
            this.ManagersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.ManagerNameColumn,
            this.ManagerBrithdayColumn,
            this.EmailColumn,
            this.LoginColumn,
            this.PasswordColumn,
            this.RoleColumn});
            this.ManagersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ManagersDataGridView.Name = "ManagersDataGridView";
            this.ManagersDataGridView.Size = new System.Drawing.Size(650, 223);
            this.ManagersDataGridView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // ManagerNameColumn
            // 
            this.ManagerNameColumn.HeaderText = "ФИО";
            this.ManagerNameColumn.Name = "ManagerNameColumn";
            // 
            // ManagerBrithdayColumn
            // 
            this.ManagerBrithdayColumn.HeaderText = "Дата рождения";
            this.ManagerBrithdayColumn.Name = "ManagerBrithdayColumn";
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "e-mail";
            this.EmailColumn.Name = "EmailColumn";
            // 
            // LoginColumn
            // 
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.Name = "LoginColumn";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.HeaderText = "Пароль";
            this.PasswordColumn.Name = "PasswordColumn";
            // 
            // RoleColumn
            // 
            this.RoleColumn.HeaderText = "Роль";
            this.RoleColumn.Name = "RoleColumn";
            // 
            // AddNewManagerButton
            // 
            this.AddNewManagerButton.Location = new System.Drawing.Point(12, 250);
            this.AddNewManagerButton.Name = "AddNewManagerButton";
            this.AddNewManagerButton.Size = new System.Drawing.Size(179, 23);
            this.AddNewManagerButton.TabIndex = 1;
            this.AddNewManagerButton.Text = "Новый менеджер";
            this.AddNewManagerButton.UseVisualStyleBackColor = true;
            this.AddNewManagerButton.Click += new System.EventHandler(this.AddNewManagerButton_Click);
            // 
            // EditManagerButton
            // 
            this.EditManagerButton.Location = new System.Drawing.Point(206, 250);
            this.EditManagerButton.Name = "EditManagerButton";
            this.EditManagerButton.Size = new System.Drawing.Size(75, 23);
            this.EditManagerButton.TabIndex = 2;
            this.EditManagerButton.Text = "Изменть";
            this.EditManagerButton.UseVisualStyleBackColor = true;
            this.EditManagerButton.Click += new System.EventHandler(this.EditManagerButton_Click);
            // 
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 335);
            this.Controls.Add(this.EditManagerButton);
            this.Controls.Add(this.AddNewManagerButton);
            this.Controls.Add(this.ManagersDataGridView);
            this.Name = "ManagersForm";
            this.Text = "ManagersForm";
            this.Activated += new System.EventHandler(this.ManagersForm_Activated);
            this.Load += new System.EventHandler(this.ManagersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ManagersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerBrithdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.Button AddNewManagerButton;
        private System.Windows.Forms.Button EditManagerButton;
    }
}
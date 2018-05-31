namespace Gubich.WorkForms
{
    partial class UnitsForm
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
            this.UnitsDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveUnitsButton = new System.Windows.Forms.Button();
            this.WordkingTextBox = new System.Windows.Forms.TextBox();
            this.AddUnitsButton = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitsDataGridView
            // 
            this.UnitsDataGridView.AllowUserToAddRows = false;
            this.UnitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn,
            this.DescriptionColumn});
            this.UnitsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.UnitsDataGridView.MultiSelect = false;
            this.UnitsDataGridView.Name = "UnitsDataGridView";
            this.UnitsDataGridView.Size = new System.Drawing.Size(265, 237);
            this.UnitsDataGridView.TabIndex = 4;
            this.UnitsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnitsDataGridView_CellClick);
            this.UnitsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnitsDataGridView_CellContentClick);
            // 
            // SaveUnitsButton
            // 
            this.SaveUnitsButton.Location = new System.Drawing.Point(344, 174);
            this.SaveUnitsButton.Name = "SaveUnitsButton";
            this.SaveUnitsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveUnitsButton.TabIndex = 7;
            this.SaveUnitsButton.Text = "Сохранить";
            this.SaveUnitsButton.UseVisualStyleBackColor = true;
            this.SaveUnitsButton.Click += new System.EventHandler(this.SaveUnitsButton_Click);
            // 
            // WordkingTextBox
            // 
            this.WordkingTextBox.Location = new System.Drawing.Point(283, 72);
            this.WordkingTextBox.Name = "WordkingTextBox";
            this.WordkingTextBox.Size = new System.Drawing.Size(136, 20);
            this.WordkingTextBox.TabIndex = 6;
            // 
            // AddUnitsButton
            // 
            this.AddUnitsButton.Location = new System.Drawing.Point(344, 145);
            this.AddUnitsButton.Name = "AddUnitsButton";
            this.AddUnitsButton.Size = new System.Drawing.Size(75, 23);
            this.AddUnitsButton.TabIndex = 5;
            this.AddUnitsButton.Text = "Добавить";
            this.AddUnitsButton.UseVisualStyleBackColor = true;
            this.AddUnitsButton.Click += new System.EventHandler(this.AddUnitsButton_Click);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Еденица измерения";
            this.NameColumn.Name = "NameColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Описание";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(283, 119);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(136, 20);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Еденица измерения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Расшифровка";
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.UnitsDataGridView);
            this.Controls.Add(this.SaveUnitsButton);
            this.Controls.Add(this.WordkingTextBox);
            this.Controls.Add(this.AddUnitsButton);
            this.Name = "UnitsForm";
            this.Text = "Еденицы измерения";
            this.Activated += new System.EventHandler(this.UnitsForm_Activated);
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UnitsDataGridView;
        private System.Windows.Forms.Button SaveUnitsButton;
        private System.Windows.Forms.TextBox WordkingTextBox;
        private System.Windows.Forms.Button AddUnitsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
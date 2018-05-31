namespace Gubich.ModelForms
{
    partial class OrderWorkingForm
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
            this.OrderDateTime = new System.Windows.Forms.DateTimePicker();
            this.OrderCount = new System.Windows.Forms.NumericUpDown();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderCountLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.NewClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderCount)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDateTime
            // 
            this.OrderDateTime.Location = new System.Drawing.Point(12, 36);
            this.OrderDateTime.Name = "OrderDateTime";
            this.OrderDateTime.Size = new System.Drawing.Size(200, 20);
            this.OrderDateTime.TabIndex = 0;
            // 
            // OrderCount
            // 
            this.OrderCount.Location = new System.Drawing.Point(12, 81);
            this.OrderCount.Name = "OrderCount";
            this.OrderCount.Size = new System.Drawing.Size(120, 20);
            this.OrderCount.TabIndex = 1;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(12, 123);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClientComboBox.TabIndex = 2;
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(12, 162);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProductComboBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(165, 202);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(12, 20);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(33, 13);
            this.OrderDateLabel.TabIndex = 5;
            this.OrderDateLabel.Text = "Дата";
            // 
            // OrderCountLabel
            // 
            this.OrderCountLabel.AutoSize = true;
            this.OrderCountLabel.Location = new System.Drawing.Point(12, 65);
            this.OrderCountLabel.Name = "OrderCountLabel";
            this.OrderCountLabel.Size = new System.Drawing.Size(66, 13);
            this.OrderCountLabel.TabIndex = 6;
            this.OrderCountLabel.Text = "Количество";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(12, 107);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(43, 13);
            this.ClientLabel.TabIndex = 7;
            this.ClientLabel.Text = "Клиент";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(12, 146);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(38, 13);
            this.ProductLabel.TabIndex = 8;
            this.ProductLabel.Text = "Товар";
            // 
            // NewClientButton
            // 
            this.NewClientButton.Location = new System.Drawing.Point(149, 121);
            this.NewClientButton.Name = "NewClientButton";
            this.NewClientButton.Size = new System.Drawing.Size(123, 23);
            this.NewClientButton.TabIndex = 9;
            this.NewClientButton.Text = "Новый клиент";
            this.NewClientButton.UseVisualStyleBackColor = true;
            this.NewClientButton.Click += new System.EventHandler(this.NewClientButton_Click);
            // 
            // OrderWorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NewClientButton);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.OrderCountLabel);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.OrderCount);
            this.Controls.Add(this.OrderDateTime);
            this.Name = "OrderWorkingForm";
            this.Text = "OrderWorkingForm";
            this.Activated += new System.EventHandler(this.OrderWorkingForm_Activated);
            this.Load += new System.EventHandler(this.OrderWorkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker OrderDateTime;
        private System.Windows.Forms.NumericUpDown OrderCount;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label OrderCountLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Button NewClientButton;
    }
}
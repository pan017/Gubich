namespace Gubich.ModelForms
{
    partial class ProductWorkingForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CharacteristicTextBox = new System.Windows.Forms.TextBox();
            this.UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.ProductTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DesciptionLabel = new System.Windows.Forms.Label();
            this.CharacteristicLabel = new System.Windows.Forms.Label();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.ProductTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(12, 67);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(194, 20);
            this.PriceTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 105);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(194, 20);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // CharacteristicTextBox
            // 
            this.CharacteristicTextBox.Location = new System.Drawing.Point(12, 142);
            this.CharacteristicTextBox.Name = "CharacteristicTextBox";
            this.CharacteristicTextBox.Size = new System.Drawing.Size(194, 20);
            this.CharacteristicTextBox.TabIndex = 3;
            // 
            // UnitsComboBox
            // 
            this.UnitsComboBox.FormattingEnabled = true;
            this.UnitsComboBox.Location = new System.Drawing.Point(12, 180);
            this.UnitsComboBox.Name = "UnitsComboBox";
            this.UnitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.UnitsComboBox.TabIndex = 4;
            // 
            // ProductTypeComboBox
            // 
            this.ProductTypeComboBox.FormattingEnabled = true;
            this.ProductTypeComboBox.Location = new System.Drawing.Point(12, 228);
            this.ProductTypeComboBox.Name = "ProductTypeComboBox";
            this.ProductTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProductTypeComboBox.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(187, 250);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Наименование";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(12, 51);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Цена";
            // 
            // DesciptionLabel
            // 
            this.DesciptionLabel.AutoSize = true;
            this.DesciptionLabel.Location = new System.Drawing.Point(12, 90);
            this.DesciptionLabel.Name = "DesciptionLabel";
            this.DesciptionLabel.Size = new System.Drawing.Size(57, 13);
            this.DesciptionLabel.TabIndex = 9;
            this.DesciptionLabel.Text = "Описание";
            // 
            // CharacteristicLabel
            // 
            this.CharacteristicLabel.AutoSize = true;
            this.CharacteristicLabel.Location = new System.Drawing.Point(12, 126);
            this.CharacteristicLabel.Name = "CharacteristicLabel";
            this.CharacteristicLabel.Size = new System.Drawing.Size(90, 13);
            this.CharacteristicLabel.TabIndex = 10;
            this.CharacteristicLabel.Text = "Характеристика";
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.Location = new System.Drawing.Point(12, 164);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(46, 13);
            this.UnitsLabel.TabIndex = 11;
            this.UnitsLabel.Text = "Ед.изм.";
            // 
            // ProductTypeLabel
            // 
            this.ProductTypeLabel.AutoSize = true;
            this.ProductTypeLabel.Location = new System.Drawing.Point(12, 212);
            this.ProductTypeLabel.Name = "ProductTypeLabel";
            this.ProductTypeLabel.Size = new System.Drawing.Size(26, 13);
            this.ProductTypeLabel.TabIndex = 12;
            this.ProductTypeLabel.Text = "Тип";
            // 
            // ProductWorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.ProductTypeLabel);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.CharacteristicLabel);
            this.Controls.Add(this.DesciptionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductTypeComboBox);
            this.Controls.Add(this.UnitsComboBox);
            this.Controls.Add(this.CharacteristicTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "ProductWorkingForm";
            this.Text = "Продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox CharacteristicTextBox;
        private System.Windows.Forms.ComboBox UnitsComboBox;
        private System.Windows.Forms.ComboBox ProductTypeComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DesciptionLabel;
        private System.Windows.Forms.Label CharacteristicLabel;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.Label ProductTypeLabel;
    }
}
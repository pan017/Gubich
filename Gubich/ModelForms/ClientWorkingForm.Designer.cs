namespace Gubich.ModelForms
{
    partial class ClientWorkingForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OrganizationTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.OrgranizationLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(156, 212);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 35);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(219, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // OrganizationTextBox
            // 
            this.OrganizationTextBox.Location = new System.Drawing.Point(12, 81);
            this.OrganizationTextBox.Name = "OrganizationTextBox";
            this.OrganizationTextBox.Size = new System.Drawing.Size(219, 20);
            this.OrganizationTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 127);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(219, 20);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Location = new System.Drawing.Point(12, 172);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(219, 20);
            this.AdresTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "ФИО клиента";
            // 
            // OrgranizationLabel
            // 
            this.OrgranizationLabel.AutoSize = true;
            this.OrgranizationLabel.Location = new System.Drawing.Point(12, 65);
            this.OrgranizationLabel.Name = "OrgranizationLabel";
            this.OrgranizationLabel.Size = new System.Drawing.Size(74, 13);
            this.OrgranizationLabel.TabIndex = 6;
            this.OrgranizationLabel.Text = "Организация";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(9, 111);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Телефон";
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Location = new System.Drawing.Point(12, 156);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(38, 13);
            this.AdresLabel.TabIndex = 8;
            this.AdresLabel.Text = "Адрес";
            // 
            // ClientWorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 256);
            this.Controls.Add(this.AdresLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.OrgranizationLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AdresTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.OrganizationTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Name = "ClientWorkingForm";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox OrganizationTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label OrgranizationLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AdresLabel;
    }
}
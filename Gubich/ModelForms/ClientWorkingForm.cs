using Gubich.Models;
using System;
using System.Windows.Forms;

namespace Gubich.ModelForms
{
    public partial class ClientWorkingForm : Form
    {
        public ClientWorkingForm()
        {
            InitializeComponent();
        }
      
        Client client;
        public ClientWorkingForm(Client client)
        {
            InitializeComponent();
            this.client = client;
            NameTextBox.Text = client.Name;
            OrganizationTextBox.Text = client.Organization;
            AdresTextBox.Text = client.Adres;
            PhoneTextBox.Text = client.Phone;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length <2 || OrganizationTextBox.Text.Length < 2 || AdresTextBox.Text.Length < 2 || PhoneTextBox.Text.Length < 2)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return;
            }
            if (client != null)
            {
                if (Client.updateClient(new Client { Adres = AdresTextBox.Text, Name = NameTextBox.Text, Organization = OrganizationTextBox.Text, Phone = PhoneTextBox.Text, id= client.id }))
                {
                    MessageBox.Show("Данные успешно сохранены!", "Типография");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
                }
            }
            else
            {
                if (Client.insertNewClient(new Client { Adres = AdresTextBox.Text, Name = NameTextBox.Text, Organization = OrganizationTextBox.Text, Phone = PhoneTextBox.Text }))
                {
                    MessageBox.Show("Данные успешно добавлены!", "Типография");
                    this.Close();
                }
                else
                {
                    MessageBox.Show( "Проверьте правильность ввода данных", "Ошибка");
                }
            }
        }
    }
}

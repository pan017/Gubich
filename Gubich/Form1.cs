using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Gubich.Models.Account;

namespace Gubich
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
                {
                    connection.Open();
                    connection.Close();
                }
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Нет подключения к базе данных", "Ошибка");
                Application.Exit();
            }


        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
           
            List<Account> accountList = Account.getAccountsList();
            bool isAuth = false;
            foreach (var item in accountList)
            {
                if (LoginTextBox.Text == item.Login && PasswordTextBox.Text == item.Password)
                {
                    isAuth = true;
                    MainMenuForm mainMenuForm = new MainMenuForm(item);
                    mainMenuForm.Show();
                    
                    this.Hide();
                }
            }
            if (!isAuth)
                MessageBox.Show("Не верный логин или пароль", "Ошибка");
        }
    }
}

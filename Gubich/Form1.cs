using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //MainMenuForm mainMenuForm = new MainMenuForm(Account.getAccountsList().First());
            //mainMenuForm.Show();

            //string sqlExpression = "SELECT * FROM Roles";
            //using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    SqlDataReader reader = command.ExecuteReader();

            //    if (reader.HasRows) // если есть данные
            //    {
            //        // выводим названия столбцов
            //       // Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

            //        while (reader.Read()) // построчно считываем данные
            //        {

            //        }
            //    }

            //    reader.Close();
            //}

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
                MessageBox.Show("Ошибка", "Не верный логин или пароль");
        }
    }
}

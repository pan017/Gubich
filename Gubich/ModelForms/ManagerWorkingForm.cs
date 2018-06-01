using Gubich.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gubich.ModelForms
{
    public partial class ManagerWorkingForm : Form
    {
        Manager manager;
        List<Role> rolesList;
        public ManagerWorkingForm()
        {
            InitializeComponent();
            InitializeRolesComboBox();
        }
        public ManagerWorkingForm(Manager manager)
        {
            InitializeComponent();
            InitializeRolesComboBox();

            this.manager = manager;
            FullNameTextBox.Text = manager.FullName;
            BrithDayDateTimeP.Value = manager.BrithDay;
            LoginTextBox.Text = manager.Account.Login;
            PasswordTextBox.Text = manager.Account.Password;
            emailTextBox.Text = manager.Account.email;
            for (int i = 0; i < rolesList.Count; i++)
            {
                if (rolesList[i].id == manager.Account.RoleId)
                {
                    RoleComboBox.SelectedIndex = i;
                    break;
                }
            }
        }
        private void ManagerWorkingForm_Load(object sender, EventArgs e)
        {

        }
        void InitializeRolesComboBox()
        {
            rolesList = Role.getRolesList();
            foreach (var item in rolesList)
            {
                RoleComboBox.Items.Add(item);
            }
            if (RoleComboBox.Items.Count > 0)
                RoleComboBox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {


            if (manager != null)
            {
                Manager updatetManager = initializeManager();
                updatetManager.id = manager.id;
                updatetManager.AccountId = manager.AccountId;
                if (Manager.updateManager(updatetManager))
                {
                    MessageBox.Show("Данные сохранены!", "Типография");
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка ввода данных", "Типография");
            }
            else
            {
                insertNewManager();
            }
            //if (manager == null)
            //    insertNewManager();
            //else
            //    updateManager();
        }
        void updateManager()
        {
            Manager updatetManager = initializeManager();
            updatetManager.id = manager.id;
            updatetManager.AccountId = manager.AccountId;
            Manager.updateManager(updatetManager);
        }
        Manager initializeManager()
        {
            Manager manager = new Manager();
            manager.BrithDay = BrithDayDateTimeP.Value;
            manager.FullName = FullNameTextBox.Text;
            manager.Account = new Account
            {
                email = emailTextBox.Text,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                RoleId = ((Role)RoleComboBox.SelectedItem).id,
                Role = Role.getRole(((Role)RoleComboBox.SelectedItem).id)
            };
            return manager;
        }
        void insertNewManager()
        {
            if (LoginTextBox.Text.Length < 1 || PasswordTextBox.Text.Length < 1 || emailTextBox.Text.Length < 1
                || FullNameTextBox.Text.Length < 1 || RoleComboBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return;
            }
            Manager manager = new Manager();
            manager.BrithDay = BrithDayDateTimeP.Value;
            manager.FullName = FullNameTextBox.Text;
            manager.Account = new Account
            {
                email = emailTextBox.Text,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                RoleId = ((Role)RoleComboBox.SelectedItem).id,
                Role = Role.getRole(((Role)RoleComboBox.SelectedItem).id)
            };
            if (Manager.insertNewManager(manager))
            {
                MessageBox.Show("Данные успешно сохранены!", "Типография");
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
            }
        }
    }
}

using Gubich.ModelForms;
using Gubich.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gubich.WorkForms
{
    public partial class ManagersForm : Form
    {
        List<Manager> managersList;
        public ManagersForm()
        {
            InitializeComponent();
        }
        void updateDataGridView()
        {
            managersList = Manager.getManagersList();

            ManagersDataGridView.Rows.Clear();
            foreach (var item in managersList)
            {
                ManagersDataGridView.Rows.Add(item.id, item.FullName, item.BrithDay, item.Account.email, item.Account.Login, item.Account.Password, item.Account.Role.RoleName);
            }
        }

        private void AddNewManagerButton_Click(object sender, EventArgs e)
        {
            ManagerWorkingForm managerWorkingForm = new ManagerWorkingForm();
            managerWorkingForm.ShowDialog();
        }

        private void EditManagerButton_Click(object sender, EventArgs e)
        {
            try
            {


                ManagerWorkingForm productWorkingForm = new ManagerWorkingForm(managersList.FirstOrDefault(x => x.id == (int)ManagersDataGridView.CurrentRow.Cells[0].Value));
                productWorkingForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите пользователя для редактирования", "Ошибка");
            }
        }

        private void ManagersForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }
    }
}

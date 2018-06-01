using Gubich.ModelForms;
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
                //  item.ProductType = ProductType.getProductType(item.ProductTypeId);
                //  item.Unit = Unit.getUnit(item.UnitId);
                ManagersDataGridView.Rows.Add(item.id, item.FullName, item.BrithDay, item.Account.email, item.Account.Login, item.Account.Password, item.Account.Role.RoleName);
            }
        }
        private void ManagersForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddNewManagerButton_Click(object sender, EventArgs e)
        {
            ManagerWorkingForm managerWorkingForm = new ManagerWorkingForm();
            managerWorkingForm.ShowDialog();
        }

        private void EditManagerButton_Click(object sender, EventArgs e)
        {
            ManagerWorkingForm productWorkingForm = new ManagerWorkingForm(managersList.FirstOrDefault(x => x.id == (int)ManagersDataGridView.CurrentRow.Cells[0].Value));
            productWorkingForm.ShowDialog();
        }

        private void ManagersForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }
    }
}

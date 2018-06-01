using Gubich.ModelForms;
using Gubich.Models;
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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            clientsList = Client.getClientList();

        }
        public ClientsForm(Account account)
        {
            InitializeComponent();
            clientsList = Client.getClientList();
            //if (account.Role.RoleName != "admin")
            //{
            //    AddClientButton.Visible = false;
            //    EditClientButton.Visible = false;
            //}
        }
        List<Client> clientsList;
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            
        }
        void updateDataGridView()
        {
            clientsList = Client.getClientList();
            clientsDataGridView.Rows.Clear();
            foreach (var item in clientsList)
            {
                clientsDataGridView.Rows.Add(item.id, item.Name, item.Organization, item.Phone, item.Adres);
            }
        }
        private void ClientsForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            ClientWorkingForm clientWorkingForm = new ClientWorkingForm();
            clientWorkingForm.ShowDialog();
        }

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            ClientWorkingForm clientWorkingForm = new ClientWorkingForm(clientsList.FirstOrDefault(x => x.id == (int)clientsDataGridView.SelectedRows[0].Cells[0].Value));
            clientWorkingForm.ShowDialog();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clientsDataGridView.Rows.Count; i++)
            {
                clientsDataGridView.Rows[i].Visible = false;
                for (int c = 0; c < clientsDataGridView.Columns.Count; c++)
                {
                    if (clientsDataGridView[c, i].Value.ToString() == FindQueryTextBox.Text)
                    {
                        clientsDataGridView.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        private void ResetFindButton_Click(object sender, EventArgs e)
        {
            FindQueryTextBox.Text = "";
            updateDataGridView();
        }
    }
}

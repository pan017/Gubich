using Gubich.ModelForms;
using Gubich.Models;
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
        List<Client> clientsList;
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ClientsForm_Activated(object sender, EventArgs e)
        {
            clientsList = Client.getClientList();
            clientsDataGridView.Rows.Clear();
            foreach (var item in clientsList)
            {
                clientsDataGridView.Rows.Add(item.id, item.Name, item.Organization, item.Phone, item.Adres);
            }
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
    }
}

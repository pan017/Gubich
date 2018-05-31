using Gubich.Models.Account;
using Gubich.WorkForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gubich
{
    public partial class MainMenuForm : Form
    {
        private Account currentUser;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        
        public MainMenuForm(Account acc)
        {
            InitializeComponent();
            currentUser = acc;
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void ProductTypesButton_Click(object sender, EventArgs e)
        {
            ProductTypesForm productTypesForm = new ProductTypesForm();
            productTypesForm.ShowDialog();
        }

        private void UnitsButton_Click(object sender, EventArgs e)
        {
            UnitsForm unitsForm = new UnitsForm();
            unitsForm.ShowDialog();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }
    }
}

using Gubich.Models.Account;
using Gubich.WorkForms;
using System;
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
            if (currentUser.Role.RoleName != "admin")
            {
                AdminMenuButton.Visible = false;
            }
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm(currentUser);
            clientsForm.ShowDialog();
        }

        private void ProductTypesButton_Click(object sender, EventArgs e)
        {
            ProductTypesForm productTypesForm = new ProductTypesForm(currentUser);
            productTypesForm.ShowDialog();
        }

        private void UnitsButton_Click(object sender, EventArgs e)
        {
            UnitsForm unitsForm = new UnitsForm(currentUser);
            unitsForm.ShowDialog();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(currentUser);
            productsForm.ShowDialog();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(currentUser);
            orderForm.ShowDialog();
        }

        private void StorageButton_Click(object sender, EventArgs e)
        {
            StorageForm storageForm = new StorageForm(currentUser);
            storageForm.ShowDialog();
        }

        private void AdminMenuButton_Click(object sender, EventArgs e)
        {
            ManagersForm managersForm = new ManagersForm();
            managersForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

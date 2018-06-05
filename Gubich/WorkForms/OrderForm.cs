using Gubich.ModelForms;
using Gubich.Models;
using Gubich.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gubich.WorkForms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        Account currentUser;
        public OrderForm(Account account)
        {
            InitializeComponent();
            this.currentUser = account;
        }
        List<Order> ordersList;

        void updateDataGridView()
        {
            ordersList = Order.getOrdersList();
            OrderDataGridView.Rows.Clear();
            foreach (var item in ordersList)
            {
                OrderDataGridView.Rows.Add(item.id, item.OrderDate, item.Product.Name, item.Client.Name, item.Count, item.Manager.FullName);
            }
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            OrderWorkingForm orderWorkingForm = new OrderWorkingForm(currentUser);
            orderWorkingForm.ShowDialog();
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            OrderWorkingForm productWorkingForm = new OrderWorkingForm(ordersList.FirstOrDefault(x => x.id == (int)OrderDataGridView.CurrentRow.Cells[0].Value), currentUser);
            productWorkingForm.ShowDialog();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OrderDataGridView.Rows.Count; i++)
            {
                OrderDataGridView.Rows[i].Visible = false;
                for (int c = 0; c < OrderDataGridView.Columns.Count; c++)
                {
                    if (OrderDataGridView[c, i].Value.ToString() == FindQueryTextBox.Text)
                    {
                        OrderDataGridView.Rows[i].Visible = true;
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

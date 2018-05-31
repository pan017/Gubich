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

namespace Gubich.ModelForms
{
    public partial class OrderWorkingForm : Form
    {
        public OrderWorkingForm()
        {
            InitializeComponent();
           
        }
        public OrderWorkingForm(Order order)
        {
            InitializeComponent();
            this.order = order;
            OrderCount.Value = order.Count;
            OrderDateTime.Value = order.OrderDate;



            for (int i = 0; i < clientsList.Count; i++)
            {
                if (clientsList[i].id == order.ClientId)
                {
                    ClientComboBox.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].id == order.ProductId)
                {
                    ProductComboBox.SelectedIndex = i;
                    break;
                }
            }
        }
        Order order;
        List<Client> clientsList;
        List<Product> productList;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ClientComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выбирите клиента", "Ошибка");
                return;
            }
            if (ProductComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выбирите товар", "Ошибка");
                return;
            }
            if (OrderCount.Value <= 0)
            {
                MessageBox.Show("Выбирите товар", "Ошибка");
                return;
            }
            Order newOrder = new Order{
                Count = (int)OrderCount.Value,
                OrderDate = OrderDateTime.Value,
                ProductId = ((Product)ProductComboBox.SelectedItem).id,
                ClientId = ((Client)ClientComboBox.SelectedItem).id};
            if (order != null)
            {
                newOrder.id = order.id;
                if (Order.updateOrder(newOrder))
                {
                    MessageBox.Show("Данные сохранены!", "Типография");
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка ввода данных", "Типография");
            }
            else
            {
                if (Order.insertNewOrder(newOrder))
                {
                    MessageBox.Show("Заказ успешно добавлен", "Типография");
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка ввода данных", "Типография");
            }
           

        }

        void initializeComboBox()
        {
            clientsList = Client.getClientList();
            productList = Product.getProductsList();
            ClientComboBox.Items.Clear();
            ProductComboBox.Items.Clear();
            foreach (var item in clientsList)
            {
                ClientComboBox.Items.Add(item);
            }
            foreach (var item in productList)
            {
                ProductComboBox.Items.Add(item);
            }
        }

        private void OrderWorkingForm_Load(object sender, EventArgs e)
        {

        }

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            ClientWorkingForm clientWorkingForm = new ClientWorkingForm();
            clientWorkingForm.ShowDialog();
        }

        private void OrderWorkingForm_Activated(object sender, EventArgs e)
        {
            initializeComboBox();
        }
    }
}

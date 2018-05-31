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
    public partial class ProductTypesForm : Form
    {
        public ProductTypesForm()
        {
            InitializeComponent();
            
        }

        public ProductTypesForm(Models.Account.Account account)
        {
            InitializeComponent();
            if (account.Role.RoleName != "admin")
            {
                SaveProductTypeButton.Visible = false;
                WordkingTextBox.Visible = false;
                AddProductType.Visible = false;
                label1.Visible = false;
                this.Size = new Size { Height = this.Size.Height, Width = 402 };
            }

        }
        private List<ProductType> productTypesList;
        private void ProductTypesForm_Load(object sender, EventArgs e)
        {
            productTypesList = ProductType.getProductTypesList();
        }

        private void AddProductType_Click(object sender, EventArgs e)
        {
            if (WordkingTextBox.Text.Length <= 1)
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
                return;
            }
            if (ProductType.insertNewProductType(new ProductType { Name = WordkingTextBox.Text }))
                MessageBox.Show("Данные успешно добавлены!", "Типография");   
            else
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
            updateDataGridView();
        }

        private void SaveProductTypeButton_Click(object sender, EventArgs e)
        {
            if (WordkingTextBox.Text.Length <= 1)
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
                return;
            }
            if (ProductType.updateProductType(new ProductType { Name = WordkingTextBox.Text, id = productTypesList.FirstOrDefault(x => x.id == (int)ProductTypesDataGridView.CurrentRow.Cells[0].Value).id}))
                MessageBox.Show("Данные успешно добавлены!", "Типография");
            else
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
            updateDataGridView();
        }

        private void ProductTypesForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }
        void updateDataGridView()
        {
            ProductTypesDataGridView.Rows.Clear();
            productTypesList = ProductType.getProductTypesList();
            foreach (var item in productTypesList)
            {
                ProductTypesDataGridView.Rows.Add(item.id, item.Name);
            }
        }
        private void ProductTypesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ProductTypesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WordkingTextBox.Text = productTypesList.FirstOrDefault(x => x.id == (int)ProductTypesDataGridView.CurrentRow.Cells[0].Value).Name;
        }
    }
}

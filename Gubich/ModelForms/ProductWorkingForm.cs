using Gubich.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gubich.ModelForms
{
    public partial class ProductWorkingForm : Form
    {
        List<Unit> unitsList;
        List<ProductType> productTypesList;
        Product product;
        public ProductWorkingForm()
        {
            InitializeComponent();
            initializeComboBox();
            UnitsComboBox.SelectedIndex = 0;
            ProductTypeComboBox.SelectedIndex = 0;
        }
        public ProductWorkingForm(Product product)
        {
            InitializeComponent();
            initializeComboBox();
            this.product = product;
            NameTextBox.Text = product.Name;
            CharacteristicTextBox.Text = product.Characteristic;
            PriceTextBox.Text = product.Cost.ToString();
            DescriptionTextBox.Text = product.Description;

            for (int i = 0; i < productTypesList.Count; i++)
            {
                if (productTypesList[i].id == product.ProductTypeId)
                {
                    ProductTypeComboBox.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < unitsList.Count; i++)
            {
                if (unitsList[i].id == product.UnitId)
                {
                    UnitsComboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length < 2 || CharacteristicTextBox.Text.Length < 2 || PriceTextBox.Text.Length < 1 || DescriptionTextBox.Text.Length < 2)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return;
            }
            if (UnitsComboBox.SelectedIndex == -1 )
            {
                MessageBox.Show("Выберите еденицы измерения!", "Ошибка");
                return;
            }
            if (ProductTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип товара!", "Ошибка");
                return;
            }
            Product NewProduct = new Product();
                NewProduct.Characteristic = CharacteristicTextBox.Text;
                NewProduct.Cost = float.Parse(PriceTextBox.Text);
                NewProduct.Description = DescriptionTextBox.Text;
                NewProduct.Name = NameTextBox.Text;
                NewProduct.UnitId = ((Unit)(UnitsComboBox.SelectedItem)).id;
                NewProduct.ProductTypeId = ((ProductType)(ProductTypeComboBox.SelectedItem)).id;

            if (product != null)
            {
                NewProduct.id = product.id;
                Product.updateProduct(NewProduct);
            }
            else
                Product.insertNewProduct(NewProduct);
            this.Close();  
        }
        void initializeComboBox()
        {
            unitsList = Unit.getUnitsList();
            productTypesList = ProductType.getProductTypesList();
            foreach (var item in unitsList)
            {
                UnitsComboBox.Items.Add(item);
            }
            foreach (var item in productTypesList)
            {
                ProductTypeComboBox.Items.Add(item);
            }
        }
    }
}

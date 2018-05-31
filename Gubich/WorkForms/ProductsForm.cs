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
    public partial class ProductsForm : Form
    {
        List<Product> productsList;
        public ProductsForm()
        {
            InitializeComponent();
        }
        public ProductsForm(Models.Account.Account account)
        {
            InitializeComponent();
            if (account.Role.RoleName != "admin")
            {
                AddProductButton.Visible = false;
                EditProductButton.Visible = false;
            }
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
           // updateDataGridView();
        }

        void updateDataGridView()
        {
            productsList = Product.getProductsList();

            ProductDataGridView.Rows.Clear();
            foreach (var item in productsList)
            {
                item.ProductType = ProductType.getProductType(item.ProductTypeId);
                item.Unit = Unit.getUnit(item.UnitId);
                ProductDataGridView.Rows.Add(item.id, item.Name, item.Cost, item.Description, item.Characteristic, item.Unit.Name, item.ProductType.Name);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductWorkingForm productWorkingForm = new ProductWorkingForm();
            productWorkingForm.ShowDialog();
        }

        private void ProductsForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            ProductWorkingForm productWorkingForm = new ProductWorkingForm(productsList.FirstOrDefault(x => x.id == (int)ProductDataGridView.CurrentRow.Cells[0].Value));
            productWorkingForm.ShowDialog();
            //WordkingTextBox.Text = unitList.FirstOrDefault(x => x.id == (int)UnitsDataGridView.CurrentRow.Cells[0].Value).Name;
        }
    }
}

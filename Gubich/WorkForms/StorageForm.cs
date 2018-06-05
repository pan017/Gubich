using Gubich.Models;
using Gubich.Models.Account;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gubich.WorkForms
{
    public partial class StorageForm : Form
    {
        List<Storage> storageList;
        public StorageForm()
        {
            InitializeComponent();
        }
        public StorageForm(Account account)
        {
            InitializeComponent();
            if (account.Role.RoleName != "admin")
            {
                SaveButton.Visible = false;
                ProductsCountNumericUpDown.Visible = false;
                this.Size = new Size { Height = 360, Width = this.Size.Width };
                label1.Visible = false;
            }
        }
        private void StorageForm_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        void updateDataGridView()
        {
            StorageDataGridView.Rows.Clear();
            storageList = Storage.getStorageList();
            foreach (var item in storageList)
            {
                StorageDataGridView.Rows.Add(item.id, item.Product.Name, item.Count);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ProductsCountNumericUpDown.Value < 0)
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
                return;
            }
            if (Storage.updateStorageItem(
                new Storage {
                    Count = (int)ProductsCountNumericUpDown.Value,
                    id = storageList.FirstOrDefault(x => x.id == (int)StorageDataGridView.CurrentRow.Cells[0].Value).id,
                ProductId = storageList.FirstOrDefault(x => x.id == (int)StorageDataGridView.CurrentRow.Cells[0].Value).ProductId
                }))
                MessageBox.Show("Данные успешно добавлены!", "Типография");
            else
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
            updateDataGridView();
        }

        private void StorageForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void StorageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductsCountNumericUpDown.Value = storageList.FirstOrDefault(x => x.id == (int)StorageDataGridView.CurrentRow.Cells[0].Value).Count;
        }
    }
}

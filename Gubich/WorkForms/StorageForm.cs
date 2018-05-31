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

    }
}

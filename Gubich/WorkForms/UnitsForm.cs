﻿using Gubich.Models;
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
    public partial class UnitsForm : Form
    {
        public UnitsForm()
        {
            InitializeComponent();
            unitList = Unit.getUnitsList();
        }
        List<Unit> unitList;
        private void AddUnitsButton_Click(object sender, EventArgs e)
        {
            if (WordkingTextBox.Text.Length <= 1)
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
                return;
            }
            if (Unit.insertNewUnit(new Unit { Name = WordkingTextBox.Text }))
                MessageBox.Show("Данные успешно добавлены!", "Типография");
            else
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
            updateDataGridView();
        }

        private void SaveUnitsButton_Click(object sender, EventArgs e)
        {
            if (WordkingTextBox.Text.Length <= 1)
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
                return;
            }
            if (Unit.updateUnit(new Unit { Name = WordkingTextBox.Text, id = unitList.FirstOrDefault(x => x.id == (int)UnitsDataGridView.CurrentRow.Cells[0].Value).id }))
                MessageBox.Show("Данные успешно добавлены!", "Типография");
            else
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка");
            updateDataGridView();
        }

        private void UnitsForm_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }
        void updateDataGridView()
        {
            UnitsDataGridView.Rows.Clear();
            unitList = Unit.getUnitsList();
            foreach (var item in unitList)
            {
                UnitsDataGridView.Rows.Add(item.id, item.Name);
            }
        }

        private void UnitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  WordkingTextBox.Text = unitList.FirstOrDefault(x => x.id == (int)UnitsDataGridView.CurrentRow.Cells[0].Value).Name;
        }

        private void UnitsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WordkingTextBox.Text = unitList.FirstOrDefault(x => x.id == (int)UnitsDataGridView.CurrentRow.Cells[0].Value).Name;
        }
    }
}

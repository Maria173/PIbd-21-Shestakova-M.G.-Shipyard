﻿using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using ShipyardContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShipyardView
{
    public partial class FormCreateOrder : Form
    {
        private readonly IShipLogic _logicD;

        private readonly IOrderLogic _logicO;

        public FormCreateOrder(IShipLogic logicD, IOrderLogic logicO)
        {
            InitializeComponent();
            _logicD = logicD;
            _logicO = logicO;
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<ShipViewModel> list = _logicD.Read(null);
                if (list != null)
                {
                    comboBoxShipName.DisplayMember = "ShipName";
                    comboBoxShipName.ValueMember = "Id";
                    comboBoxShipName.DataSource = list;
                    comboBoxShipName.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список изделий");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcSum()
        {
            if (comboBoxShipName.SelectedValue != null && !string.IsNullOrEmpty(textBoxShipCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxShipName.SelectedValue);
                    ShipViewModel ship = _logicD.Read(new ShipBindingModel { Id = id })?[0];
                    int count = Convert.ToInt32(textBoxShipCount.Text);
                    textBoxSum.Text = (count * ship?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxShipCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void comboBoxShipName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxShipCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxShipName.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    ShipId = Convert.ToInt32(comboBoxShipName.SelectedValue),
                    Count = Convert.ToInt32(textBoxShipCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;

namespace ShipyardView
{
    public partial class FormMessages : Form
    {
        private readonly IMessageInfoLogic _messageInfoLogic;
        public FormMessages(IMessageInfoLogic messageInfoLogic)
        {
            InitializeComponent();
            _messageInfoLogic = messageInfoLogic;
        }

        private void FormMessages_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = _messageInfoLogic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
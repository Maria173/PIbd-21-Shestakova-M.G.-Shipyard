﻿using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using System;
using System.Windows.Forms;
using Unity;

namespace ShipyardView
{
    public partial class FormMain : Form
    {
        private readonly IOrderLogic _orderLogic;
        private readonly IReportLogic _reportLogic;
        private readonly IWorkProcess _workProcces;
        private readonly IImplementerLogic _implementerLogic;
        private readonly IBackUpLogic _backUpLogic;
        public FormMain(IOrderLogic orderLogic, IReportLogic reportLogic, IWorkProcess workProcess,
                        IImplementerLogic implementerLogic, IBackUpLogic backUpLogic)
        {
            InitializeComponent();
            _orderLogic = orderLogic;
            _reportLogic = reportLogic;
            _workProcces = workProcess;
            _implementerLogic = implementerLogic;
            _backUpLogic = backUpLogic;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(_orderLogic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void компонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormComponents>();
            form.ShowDialog();
        }

        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormShips>();
            form.ShowDialog();
        }
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void исполнителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormImplementers>();
            form.ShowDialog();
        }

        private void запускРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _workProcces.DoWork(_implementerLogic, _orderLogic);
            LoadData();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormCreateOrder>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonOrderDelivered_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    _orderLogic.DeliveryOrder(new ChangeStatusBindingModel { OrderId = id });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRefreshOrderList_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "docx|*.docx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _reportLogic.SaveComponentsToWordFile(new ReportBindingModel
                {
                    FileName = dialog.FileName
                });
                MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void ComponentShipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormReportShipComponents>();
            form.ShowDialog();
        }
        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormReportOrders>();
            form.ShowDialog();
        }

        private void почтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormMessages>();
            form.ShowDialog();
        }

        private void создатьБекапToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_backUpLogic != null)
                {
                    var fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        _backUpLogic.CreateBackUp(new
                        BackUpSaveBinidngModel
                        { FolderName = fbd.SelectedPath });
                        MessageBox.Show("Бекап создан", "Сообщение",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

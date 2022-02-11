using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using ShipyardContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ShipyardView
{
    public partial class FormShip : Form
    {
        public int Id
        {
            set { id = value; }
        }

        private readonly IShipLogic _logic;

        private int? id;

        private Dictionary<int, (string, int)> shipComponents;

        public FormShip(IShipLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void FormShip_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ShipViewModel view = _logic.Read(new ShipBindingModel { Id = id.Value })?[0];
                    if (view != null)
                    {
                        textBoxShipName.Text = view.ShipName;
                        textBoxShipPrice.Text = view.Price.ToString();
                        shipComponents = view.ShipComponents;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                shipComponents = new Dictionary<int, (string, int)>();
            }
        }

        private void LoadData()
        {
            try
            {
                if (shipComponents != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var pc in shipComponents)
                    {
                        dataGridView.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxShipName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxShipPrice.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (shipComponents == null || shipComponents.Count == 0)
            {
                MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logic.CreateOrUpdate(new ShipBindingModel
                {
                    Id = id,
                    ShipName = textBoxShipName.Text,
                    Price = Convert.ToDecimal(textBoxShipPrice.Text),
                    ShipComponents = shipComponents
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

        private void buttonAddComponent_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormShipComponent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (shipComponents.ContainsKey(form.Id))
                {
                    shipComponents[form.Id] = (form.ComponentName, form.Count);
                }
                else
                {
                    shipComponents.Add(form.Id, (form.ComponentName, form.Count));
                }
                LoadData();
            }
        }

        private void buttonEditComponent_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormShipComponent>();
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                form.Count = shipComponents[id].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    shipComponents[form.Id] = (form.ComponentName, form.Count);
                    LoadData();
                }
            }
        }

        private void buttonRemoveComponent_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        shipComponents.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpdateComponent_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

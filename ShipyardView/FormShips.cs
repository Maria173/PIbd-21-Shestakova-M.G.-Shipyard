using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using System;
using System.Windows.Forms;
using Unity;

namespace ShipyardView
{
    public partial class FormShips : Form
    {
        private readonly IShipLogic _logic;

        public FormShips(IShipLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void FormShips_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(_logic.Read(null), dataGridView);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddShip_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormShip>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonEditShip_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormShip>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDeleteShip_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _logic.Delete(new ShipBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpdateShip_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

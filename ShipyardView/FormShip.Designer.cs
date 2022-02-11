namespace ShipyardView
{
    partial class FormShip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelShipName = new System.Windows.Forms.Label();
            this.textBoxShipName = new System.Windows.Forms.TextBox();
            this.labelShipPrice = new System.Windows.Forms.Label();
            this.textBoxShipPrice = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ComponentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxComponents = new System.Windows.Forms.GroupBox();
            this.buttonUpdateComponent = new System.Windows.Forms.Button();
            this.buttonRemoveComponent = new System.Windows.Forms.Button();
            this.buttonEditComponent = new System.Windows.Forms.Button();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelShipName
            // 
            this.labelShipName.AutoSize = true;
            this.labelShipName.Location = new System.Drawing.Point(10, 12);
            this.labelShipName.Name = "labelShipName";
            this.labelShipName.Size = new System.Drawing.Size(62, 15);
            this.labelShipName.TabIndex = 0;
            this.labelShipName.Text = "Название:";
            // 
            // textBoxShipName
            // 
            this.textBoxShipName.Location = new System.Drawing.Point(88, 10);
            this.textBoxShipName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxShipName.Name = "textBoxShipName";
            this.textBoxShipName.Size = new System.Drawing.Size(182, 23);
            this.textBoxShipName.TabIndex = 1;
            // 
            // labelShipPrice
            // 
            this.labelShipPrice.AutoSize = true;
            this.labelShipPrice.Location = new System.Drawing.Point(11, 38);
            this.labelShipPrice.Name = "labelShipPrice";
            this.labelShipPrice.Size = new System.Drawing.Size(38, 15);
            this.labelShipPrice.TabIndex = 2;
            this.labelShipPrice.Text = "Цена:";
            // 
            // textBoxShipPrice
            // 
            this.textBoxShipPrice.Location = new System.Drawing.Point(88, 36);
            this.textBoxShipPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxShipPrice.Name = "textBoxShipPrice";
            this.textBoxShipPrice.Size = new System.Drawing.Size(182, 23);
            this.textBoxShipPrice.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentId,
            this.ComponentName,
            this.ComponentCount});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(5, 20);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(413, 235);
            this.dataGridView.TabIndex = 4;
            // 
            // ComponentId
            // 
            this.ComponentId.HeaderText = "Id";
            this.ComponentId.MinimumWidth = 6;
            this.ComponentId.Name = "ComponentId";
            this.ComponentId.ReadOnly = true;
            this.ComponentId.Visible = false;
            // 
            // ComponentName
            // 
            this.ComponentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentName.HeaderText = "Компонент";
            this.ComponentName.MinimumWidth = 8;
            this.ComponentName.Name = "ComponentName";
            this.ComponentName.ReadOnly = true;
            // 
            // ComponentCount
            // 
            this.ComponentCount.HeaderText = "Количество";
            this.ComponentCount.MinimumWidth = 8;
            this.ComponentCount.Name = "ComponentCount";
            this.ComponentCount.ReadOnly = true;
            // 
            // groupBoxComponents
            // 
            this.groupBoxComponents.Controls.Add(this.buttonUpdateComponent);
            this.groupBoxComponents.Controls.Add(this.buttonRemoveComponent);
            this.groupBoxComponents.Controls.Add(this.buttonEditComponent);
            this.groupBoxComponents.Controls.Add(this.buttonAddComponent);
            this.groupBoxComponents.Controls.Add(this.dataGridView);
            this.groupBoxComponents.Location = new System.Drawing.Point(11, 70);
            this.groupBoxComponents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxComponents.Name = "groupBoxComponents";
            this.groupBoxComponents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxComponents.Size = new System.Drawing.Size(524, 259);
            this.groupBoxComponents.TabIndex = 5;
            this.groupBoxComponents.TabStop = false;
            this.groupBoxComponents.Text = "Компоненты";
            // 
            // buttonUpdateComponent
            // 
            this.buttonUpdateComponent.Location = new System.Drawing.Point(424, 119);
            this.buttonUpdateComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateComponent.Name = "buttonUpdateComponent";
            this.buttonUpdateComponent.Size = new System.Drawing.Size(91, 28);
            this.buttonUpdateComponent.TabIndex = 8;
            this.buttonUpdateComponent.Text = "Обновить";
            this.buttonUpdateComponent.UseVisualStyleBackColor = true;
            this.buttonUpdateComponent.Click += new System.EventHandler(this.buttonUpdateComponent_Click);
            // 
            // buttonRemoveComponent
            // 
            this.buttonRemoveComponent.Location = new System.Drawing.Point(424, 86);
            this.buttonRemoveComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveComponent.Name = "buttonRemoveComponent";
            this.buttonRemoveComponent.Size = new System.Drawing.Size(91, 28);
            this.buttonRemoveComponent.TabIndex = 7;
            this.buttonRemoveComponent.Text = "Удалить";
            this.buttonRemoveComponent.UseVisualStyleBackColor = true;
            this.buttonRemoveComponent.Click += new System.EventHandler(this.buttonRemoveComponent_Click);
            // 
            // buttonEditComponent
            // 
            this.buttonEditComponent.Location = new System.Drawing.Point(424, 53);
            this.buttonEditComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditComponent.Name = "buttonEditComponent";
            this.buttonEditComponent.Size = new System.Drawing.Size(91, 28);
            this.buttonEditComponent.TabIndex = 6;
            this.buttonEditComponent.Text = "Изменить";
            this.buttonEditComponent.UseVisualStyleBackColor = true;
            this.buttonEditComponent.Click += new System.EventHandler(this.buttonEditComponent_Click);
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Location = new System.Drawing.Point(424, 20);
            this.buttonAddComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(91, 28);
            this.buttonAddComponent.TabIndex = 5;
            this.buttonAddComponent.Text = "Добавить";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.buttonAddComponent_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(435, 9);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 28);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(435, 42);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 338);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxComponents);
            this.Controls.Add(this.textBoxShipPrice);
            this.Controls.Add(this.labelShipPrice);
            this.Controls.Add(this.textBoxShipName);
            this.Controls.Add(this.labelShipName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormShip";
            this.Text = "Изделие";
            this.Load += new System.EventHandler(this.FormShip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxComponents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelShipName;

        private System.Windows.Forms.TextBox textBoxShipName;

        private System.Windows.Forms.Label labelShipPrice;

        private System.Windows.Forms.TextBox textBoxShipPrice;

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.GroupBox groupBoxComponents;

        private System.Windows.Forms.Button buttonAddComponent;

        private System.Windows.Forms.Button buttonEditComponent;

        private System.Windows.Forms.Button buttonRemoveComponent;

        private System.Windows.Forms.Button buttonUpdateComponent;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentId;

        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;

        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentCount;
    }
}

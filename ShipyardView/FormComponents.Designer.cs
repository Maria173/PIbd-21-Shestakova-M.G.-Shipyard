namespace ShipyardView
{
    partial class FormComponents
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.buttonEditComponent = new System.Windows.Forms.Button();
            this.buttonDeleteComponent = new System.Windows.Forms.Button();
            this.buttonUpdateComponent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(469, 425);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Location = new System.Drawing.Point(489, 13);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(110, 39);
            this.buttonAddComponent.TabIndex = 1;
            this.buttonAddComponent.Text = "Добавить";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.buttonAddComponent_Click);
            // 
            // buttonEditComponent
            // 
            this.buttonEditComponent.Location = new System.Drawing.Point(488, 58);
            this.buttonEditComponent.Name = "buttonEditComponent";
            this.buttonEditComponent.Size = new System.Drawing.Size(110, 39);
            this.buttonEditComponent.TabIndex = 2;
            this.buttonEditComponent.Text = "Изменить";
            this.buttonEditComponent.UseVisualStyleBackColor = true;
            this.buttonEditComponent.Click += new System.EventHandler(this.buttonEditComponent_Click);
            // 
            // buttonDeleteComponent
            // 
            this.buttonDeleteComponent.Location = new System.Drawing.Point(489, 103);
            this.buttonDeleteComponent.Name = "buttonDeleteComponent";
            this.buttonDeleteComponent.Size = new System.Drawing.Size(110, 39);
            this.buttonDeleteComponent.TabIndex = 3;
            this.buttonDeleteComponent.Text = "Удалить";
            this.buttonDeleteComponent.UseVisualStyleBackColor = true;
            this.buttonDeleteComponent.Click += new System.EventHandler(this.buttonDeleteComponent_Click);
            // 
            // buttonUpdateComponent
            // 
            this.buttonUpdateComponent.Location = new System.Drawing.Point(488, 148);
            this.buttonUpdateComponent.Name = "buttonUpdateComponent";
            this.buttonUpdateComponent.Size = new System.Drawing.Size(110, 39);
            this.buttonUpdateComponent.TabIndex = 4;
            this.buttonUpdateComponent.Text = "Обновить";
            this.buttonUpdateComponent.UseVisualStyleBackColor = true;
            this.buttonUpdateComponent.Click += new System.EventHandler(this.buttonUpdateComponent_Click);
            // 
            // FormComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.buttonUpdateComponent);
            this.Controls.Add(this.buttonDeleteComponent);
            this.Controls.Add(this.buttonEditComponent);
            this.Controls.Add(this.buttonAddComponent);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormComponents";
            this.Text = "Компоненты";
            this.Load += new System.EventHandler(this.FormComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.Button buttonAddComponent;

        private System.Windows.Forms.Button buttonEditComponent;

        private System.Windows.Forms.Button buttonDeleteComponent;

        private System.Windows.Forms.Button buttonUpdateComponent;
    }
}

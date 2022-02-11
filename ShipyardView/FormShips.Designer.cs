
namespace ShipyardView
{
    partial class FormShips
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUpdateShip = new System.Windows.Forms.Button();
            this.buttonDeleteShip = new System.Windows.Forms.Button();
            this.buttonEditShip = new System.Windows.Forms.Button();
            this.buttonAddShip = new System.Windows.Forms.Button();
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
            this.dataGridView.Location = new System.Drawing.Point(10, 9);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(433, 286);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonUpdateShip
            // 
            this.buttonUpdateShip.Location = new System.Drawing.Point(448, 110);
            this.buttonUpdateShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateShip.Name = "buttonUpdateShip";
            this.buttonUpdateShip.Size = new System.Drawing.Size(96, 29);
            this.buttonUpdateShip.TabIndex = 8;
            this.buttonUpdateShip.Text = "Обновить";
            this.buttonUpdateShip.UseVisualStyleBackColor = true;
            this.buttonUpdateShip.Click += new System.EventHandler(this.buttonUpdateShip_Click);
            // 
            // buttonDeleteShip
            // 
            this.buttonDeleteShip.Location = new System.Drawing.Point(449, 76);
            this.buttonDeleteShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteShip.Name = "buttonDeleteShip";
            this.buttonDeleteShip.Size = new System.Drawing.Size(96, 29);
            this.buttonDeleteShip.TabIndex = 7;
            this.buttonDeleteShip.Text = "Удалить";
            this.buttonDeleteShip.UseVisualStyleBackColor = true;
            this.buttonDeleteShip.Click += new System.EventHandler(this.buttonDeleteShip_Click);
            // 
            // buttonEditShip
            // 
            this.buttonEditShip.Location = new System.Drawing.Point(448, 43);
            this.buttonEditShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditShip.Name = "buttonEditShip";
            this.buttonEditShip.Size = new System.Drawing.Size(96, 29);
            this.buttonEditShip.TabIndex = 6;
            this.buttonEditShip.Text = "Изменить";
            this.buttonEditShip.UseVisualStyleBackColor = true;
            this.buttonEditShip.Click += new System.EventHandler(this.buttonEditShip_Click);
            // 
            // buttonAddShip
            // 
            this.buttonAddShip.Location = new System.Drawing.Point(449, 9);
            this.buttonAddShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddShip.Name = "buttonAddShip";
            this.buttonAddShip.Size = new System.Drawing.Size(96, 29);
            this.buttonAddShip.TabIndex = 5;
            this.buttonAddShip.Text = "Добавить";
            this.buttonAddShip.UseVisualStyleBackColor = true;
            this.buttonAddShip.Click += new System.EventHandler(this.buttonAddShip_Click);
            // 
            // FormShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 303);
            this.Controls.Add(this.buttonUpdateShip);
            this.Controls.Add(this.buttonDeleteShip);
            this.Controls.Add(this.buttonEditShip);
            this.Controls.Add(this.buttonAddShip);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormShips";
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.FormShips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonUpdateShip;
        private System.Windows.Forms.Button buttonDeleteShip;
        private System.Windows.Forms.Button buttonEditShip;
        private System.Windows.Forms.Button buttonAddShip;
    }
}
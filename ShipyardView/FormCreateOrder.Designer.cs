namespace ShipyardView
{
    partial class FormCreateOrder
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
            this.comboBoxShipName = new System.Windows.Forms.ComboBox();
            this.labelShipCount = new System.Windows.Forms.Label();
            this.textBoxShipCount = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelShipName
            // 
            this.labelShipName.AutoSize = true;
            this.labelShipName.Location = new System.Drawing.Point(11, 10);
            this.labelShipName.Name = "labelShipName";
            this.labelShipName.Size = new System.Drawing.Size(56, 15);
            this.labelShipName.TabIndex = 0;
            this.labelShipName.Text = "Изделие:";
            // 
            // comboBoxShipName
            // 
            this.comboBoxShipName.FormattingEnabled = true;
            this.comboBoxShipName.Location = new System.Drawing.Point(110, 8);
            this.comboBoxShipName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxShipName.Name = "comboBoxShipName";
            this.comboBoxShipName.Size = new System.Drawing.Size(291, 23);
            this.comboBoxShipName.TabIndex = 1;
            this.comboBoxShipName.SelectedIndexChanged += new System.EventHandler(this.comboBoxShipName_SelectedIndexChanged);
            // 
            // labelShipCount
            // 
            this.labelShipCount.AutoSize = true;
            this.labelShipCount.Location = new System.Drawing.Point(11, 38);
            this.labelShipCount.Name = "labelShipCount";
            this.labelShipCount.Size = new System.Drawing.Size(75, 15);
            this.labelShipCount.TabIndex = 2;
            this.labelShipCount.Text = "Количество:";
            // 
            // textBoxShipCount
            // 
            this.textBoxShipCount.Location = new System.Drawing.Point(110, 35);
            this.textBoxShipCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxShipCount.Name = "textBoxShipCount";
            this.textBoxShipCount.Size = new System.Drawing.Size(291, 23);
            this.textBoxShipCount.TabIndex = 3;
            this.textBoxShipCount.TextChanged += new System.EventHandler(this.textBoxShipCount_TextChanged);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(11, 64);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(48, 15);
            this.labelSum.TabIndex = 4;
            this.labelSum.Text = "Сумма:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSum.Location = new System.Drawing.Point(110, 62);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(291, 23);
            this.textBoxSum.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(94, 98);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 28);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(225, 98);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 136);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxShipCount);
            this.Controls.Add(this.labelShipCount);
            this.Controls.Add(this.comboBoxShipName);
            this.Controls.Add(this.labelShipName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelShipName;

        private System.Windows.Forms.ComboBox comboBoxShipName;

        private System.Windows.Forms.Label labelShipCount;

        private System.Windows.Forms.TextBox textBoxShipCount;

        private System.Windows.Forms.Label labelSum;

        private System.Windows.Forms.TextBox textBoxSum;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.Button buttonCancel;
    }
}

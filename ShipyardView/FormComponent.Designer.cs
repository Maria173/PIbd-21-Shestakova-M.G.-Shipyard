namespace ShipyardView
{
    partial class FormComponent
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
            this.labelComponentName = new System.Windows.Forms.Label();
            this.textBoxComponentName = new System.Windows.Forms.TextBox();
            this.buttonComponentSave = new System.Windows.Forms.Button();
            this.buttonComponentCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComponentName
            // 
            this.labelComponentName.AutoSize = true;
            this.labelComponentName.Location = new System.Drawing.Point(56, 32);
            this.labelComponentName.Name = "labelComponentName";
            this.labelComponentName.Size = new System.Drawing.Size(80, 20);
            this.labelComponentName.TabIndex = 0;
            this.labelComponentName.Text = "Название:";
            // 
            // textBoxComponentName
            // 
            this.textBoxComponentName.Location = new System.Drawing.Point(143, 32);
            this.textBoxComponentName.Name = "textBoxComponentName";
            this.textBoxComponentName.Size = new System.Drawing.Size(125, 27);
            this.textBoxComponentName.TabIndex = 1;
            // 
            // buttonComponentSave
            // 
            this.buttonComponentSave.Location = new System.Drawing.Point(56, 65);
            this.buttonComponentSave.Name = "buttonComponentSave";
            this.buttonComponentSave.Size = new System.Drawing.Size(102, 36);
            this.buttonComponentSave.TabIndex = 2;
            this.buttonComponentSave.Text = "Сохранить";
            this.buttonComponentSave.UseVisualStyleBackColor = true;
            this.buttonComponentSave.Click += new System.EventHandler(this.buttonComponentSave_Click);
            // 
            // buttonComponentCancel
            // 
            this.buttonComponentCancel.Location = new System.Drawing.Point(166, 65);
            this.buttonComponentCancel.Name = "buttonComponentCancel";
            this.buttonComponentCancel.Size = new System.Drawing.Size(102, 36);
            this.buttonComponentCancel.TabIndex = 3;
            this.buttonComponentCancel.Text = "Отмена";
            this.buttonComponentCancel.UseVisualStyleBackColor = true;
            this.buttonComponentCancel.Click += new System.EventHandler(this.buttonComponentCancel_Click);
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 135);
            this.Controls.Add(this.buttonComponentCancel);
            this.Controls.Add(this.buttonComponentSave);
            this.Controls.Add(this.textBoxComponentName);
            this.Controls.Add(this.labelComponentName);
            this.Name = "FormComponent";
            this.Text = "Компонент";
            this.Load += new System.EventHandler(this.FormComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelComponentName;

        private System.Windows.Forms.TextBox textBoxComponentName;

        private System.Windows.Forms.Button buttonComponentSave;

        private System.Windows.Forms.Button buttonComponentCancel;
    }
}

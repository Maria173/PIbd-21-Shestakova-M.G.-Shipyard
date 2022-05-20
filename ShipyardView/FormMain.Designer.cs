
namespace ShipyardView
{
    partial class FormMain
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
            this.menuStripGuide = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonOrderDelivered = new System.Windows.Forms.Button();
            this.buttonRefreshOrderList = new System.Windows.Forms.Button();
            this.почтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripGuide
            // 
            this.menuStripGuide.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripGuide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.запускРаботToolStripMenuItem,
            this.почтаToolStripMenuItem});
            this.menuStripGuide.Location = new System.Drawing.Point(0, 0);
            this.menuStripGuide.Name = "menuStripGuide";
            this.menuStripGuide.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripGuide.Size = new System.Drawing.Size(920, 24);
            this.menuStripGuide.TabIndex = 0;
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.изделияToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.исполнителиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
            // 
            // изделияToolStripMenuItem
            // 
            this.изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
            this.изделияToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.изделияToolStripMenuItem.Text = "Изделия";
            this.изделияToolStripMenuItem.Click += new System.EventHandler(this.изделияToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // исполнителиToolStripMenuItem
            // 
            this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
            this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.исполнителиToolStripMenuItem.Text = "Исполнители";
            this.исполнителиToolStripMenuItem.Click += new System.EventHandler(this.исполнителиToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComponentsToolStripMenuItem,
            this.ComponentShipsToolStripMenuItem,
            this.OrdersToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // ComponentsToolStripMenuItem
            // 
            this.ComponentsToolStripMenuItem.Name = "ComponentsToolStripMenuItem";
            this.ComponentsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ComponentsToolStripMenuItem.Text = "Список компонентов";
            this.ComponentsToolStripMenuItem.Click += new System.EventHandler(this.ComponentsToolStripMenuItem_Click);
            // 
            // ComponentShipsToolStripMenuItem
            // 
            this.ComponentShipsToolStripMenuItem.Name = "ComponentShipsToolStripMenuItem";
            this.ComponentShipsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ComponentShipsToolStripMenuItem.Text = "Компоненты по изделиям";
            this.ComponentShipsToolStripMenuItem.Click += new System.EventHandler(this.ComponentShipsToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.OrdersToolStripMenuItem.Text = "Список заказов";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // запускРаботToolStripMenuItem
            // 
            this.запускРаботToolStripMenuItem.Name = "запускРаботToolStripMenuItem";
            this.запускРаботToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.запускРаботToolStripMenuItem.Text = "Запуск работ";
            this.запускРаботToolStripMenuItem.Click += new System.EventHandler(this.запускРаботToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(11, 24);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(698, 258);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(715, 46);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(194, 33);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonOrderDelivered
            // 
            this.buttonOrderDelivered.Location = new System.Drawing.Point(715, 83);
            this.buttonOrderDelivered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrderDelivered.Name = "buttonOrderDelivered";
            this.buttonOrderDelivered.Size = new System.Drawing.Size(194, 33);
            this.buttonOrderDelivered.TabIndex = 5;
            this.buttonOrderDelivered.Text = "Заказ выдан";
            this.buttonOrderDelivered.UseVisualStyleBackColor = true;
            this.buttonOrderDelivered.Click += new System.EventHandler(this.buttonOrderDelivered_Click);
            // 
            // buttonRefreshOrderList
            // 
            this.buttonRefreshOrderList.Location = new System.Drawing.Point(715, 120);
            this.buttonRefreshOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefreshOrderList.Name = "buttonRefreshOrderList";
            this.buttonRefreshOrderList.Size = new System.Drawing.Size(194, 33);
            this.buttonRefreshOrderList.TabIndex = 6;
            this.buttonRefreshOrderList.Text = "Обновить список";
            this.buttonRefreshOrderList.UseVisualStyleBackColor = true;
            this.buttonRefreshOrderList.Click += new System.EventHandler(this.buttonRefreshOrderList_Click);
            // 
            // почтаToolStripMenuItem
            // 
            this.почтаToolStripMenuItem.Name = "почтаToolStripMenuItem";
            this.почтаToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.почтаToolStripMenuItem.Text = "Почта";
            this.почтаToolStripMenuItem.Click += new System.EventHandler(this.почтаToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 292);
            this.Controls.Add(this.buttonRefreshOrderList);
            this.Controls.Add(this.buttonOrderDelivered);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStripGuide);
            this.MainMenuStrip = this.menuStripGuide;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Верфь";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripGuide.ResumeLayout(false);
            this.menuStripGuide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGuide;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonOrderDelivered;
        private System.Windows.Forms.Button buttonRefreshOrderList;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentShipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исполнителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускРаботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem почтаToolStripMenuItem;
    }
}
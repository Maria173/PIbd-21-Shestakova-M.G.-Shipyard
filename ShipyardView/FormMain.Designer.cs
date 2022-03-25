
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
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonOrderFinished = new System.Windows.Forms.Button();
            this.buttonOrderDelivered = new System.Windows.Forms.Button();
            this.buttonRefreshOrderList = new System.Windows.Forms.Button();
            this.menuStripGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripGuide
            // 
            this.menuStripGuide.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripGuide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStripGuide.Location = new System.Drawing.Point(0, 0);
            this.menuStripGuide.Name = "menuStripGuide";
            this.menuStripGuide.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStripGuide.Size = new System.Drawing.Size(1051, 30);
            this.menuStripGuide.TabIndex = 0;
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.изделияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
            // 
            // изделияToolStripMenuItem
            // 
            this.изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
            this.изделияToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.изделияToolStripMenuItem.Text = "Изделия";
            this.изделияToolStripMenuItem.Click += new System.EventHandler(this.изделияToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComponentsToolStripMenuItem,
            this.ComponentShipsToolStripMenuItem,
            this.OrdersToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // ComponentsToolStripMenuItem
            // 
            this.ComponentsToolStripMenuItem.Name = "ComponentsToolStripMenuItem";
            this.ComponentsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.ComponentsToolStripMenuItem.Text = "Список компонентов";
            this.ComponentsToolStripMenuItem.Click += new System.EventHandler(this.ComponentsToolStripMenuItem_Click);
            // 
            // ComponentShipsToolStripMenuItem
            // 
            this.ComponentShipsToolStripMenuItem.Name = "ComponentShipsToolStripMenuItem";
            this.ComponentShipsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.ComponentShipsToolStripMenuItem.Text = "Компоненты по изделиям";
            this.ComponentShipsToolStripMenuItem.Click += new System.EventHandler(this.ComponentShipsToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.OrdersToolStripMenuItem.Text = "Список заказов";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(13, 32);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(798, 344);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(817, 61);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(222, 44);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(817, 123);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(222, 44);
            this.buttonTakeOrderInWork.TabIndex = 3;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonOrderFinished
            // 
            this.buttonOrderFinished.Location = new System.Drawing.Point(817, 187);
            this.buttonOrderFinished.Name = "buttonOrderFinished";
            this.buttonOrderFinished.Size = new System.Drawing.Size(222, 44);
            this.buttonOrderFinished.TabIndex = 4;
            this.buttonOrderFinished.Text = "Заказ готов";
            this.buttonOrderFinished.UseVisualStyleBackColor = true;
            this.buttonOrderFinished.Click += new System.EventHandler(this.buttonOrderFinished_Click);
            // 
            // buttonOrderDelivered
            // 
            this.buttonOrderDelivered.Location = new System.Drawing.Point(817, 251);
            this.buttonOrderDelivered.Name = "buttonOrderDelivered";
            this.buttonOrderDelivered.Size = new System.Drawing.Size(222, 44);
            this.buttonOrderDelivered.TabIndex = 5;
            this.buttonOrderDelivered.Text = "Заказ выдан";
            this.buttonOrderDelivered.UseVisualStyleBackColor = true;
            this.buttonOrderDelivered.Click += new System.EventHandler(this.buttonOrderDelivered_Click);
            // 
            // buttonRefreshOrderList
            // 
            this.buttonRefreshOrderList.Location = new System.Drawing.Point(817, 317);
            this.buttonRefreshOrderList.Name = "buttonRefreshOrderList";
            this.buttonRefreshOrderList.Size = new System.Drawing.Size(222, 44);
            this.buttonRefreshOrderList.TabIndex = 6;
            this.buttonRefreshOrderList.Text = "Обновить список";
            this.buttonRefreshOrderList.UseVisualStyleBackColor = true;
            this.buttonRefreshOrderList.Click += new System.EventHandler(this.buttonRefreshOrderList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 389);
            this.Controls.Add(this.buttonRefreshOrderList);
            this.Controls.Add(this.buttonOrderDelivered);
            this.Controls.Add(this.buttonOrderFinished);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStripGuide);
            this.MainMenuStrip = this.menuStripGuide;
            this.Name = "FormMain";
            this.Text = "Пошив платьев";
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
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonOrderFinished;
        private System.Windows.Forms.Button buttonOrderDelivered;
        private System.Windows.Forms.Button buttonRefreshOrderList;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentShipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
    }
}
namespace WowCaseApp.Forms.View
{
    partial class ViewForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChildTable = new System.Windows.Forms.ComboBox();
            this.buttontoStockAll = new System.Windows.Forms.Button();
            this.buttonToStock = new System.Windows.Forms.Button();
            this.buttonToCurrentAll = new System.Windows.Forms.Button();
            this.buttonToCurrent = new System.Windows.Forms.Button();
            this.labelCurrentAttributes = new System.Windows.Forms.Label();
            this.listBoxCurrent = new System.Windows.Forms.ListBox();
            this.listBoxStock = new System.Windows.Forms.ListBox();
            this.labelTableAttributes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMainTable = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelViewPage = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(503, 315);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxChildTable);
            this.tabPage1.Controls.Add(this.buttontoStockAll);
            this.tabPage1.Controls.Add(this.buttonToStock);
            this.tabPage1.Controls.Add(this.buttonToCurrentAll);
            this.tabPage1.Controls.Add(this.buttonToCurrent);
            this.tabPage1.Controls.Add(this.labelCurrentAttributes);
            this.tabPage1.Controls.Add(this.listBoxCurrent);
            this.tabPage1.Controls.Add(this.listBoxStock);
            this.tabPage1.Controls.Add(this.labelTableAttributes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxMainTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(495, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "Attributes";
            this.tabPage1.Text = "Атрибуты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Подчинённая таблица";
            // 
            // comboBoxChildTable
            // 
            this.comboBoxChildTable.FormattingEnabled = true;
            this.comboBoxChildTable.Location = new System.Drawing.Point(256, 22);
            this.comboBoxChildTable.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxChildTable.Name = "comboBoxChildTable";
            this.comboBoxChildTable.Size = new System.Drawing.Size(201, 21);
            this.comboBoxChildTable.TabIndex = 10;
            this.comboBoxChildTable.SelectedValueChanged += new System.EventHandler(this.comboBoxTables_SelectedValueChanged);
            // 
            // buttontoStockAll
            // 
            this.buttontoStockAll.Location = new System.Drawing.Point(221, 174);
            this.buttontoStockAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttontoStockAll.Name = "buttontoStockAll";
            this.buttontoStockAll.Size = new System.Drawing.Size(32, 20);
            this.buttontoStockAll.TabIndex = 9;
            this.buttontoStockAll.Text = "<<";
            this.buttontoStockAll.UseVisualStyleBackColor = true;
            this.buttontoStockAll.Click += new System.EventHandler(this.buttontoStockAll_Click);
            // 
            // buttonToStock
            // 
            this.buttonToStock.Enabled = false;
            this.buttonToStock.Location = new System.Drawing.Point(221, 150);
            this.buttonToStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonToStock.Name = "buttonToStock";
            this.buttonToStock.Size = new System.Drawing.Size(32, 20);
            this.buttonToStock.TabIndex = 8;
            this.buttonToStock.Text = "<";
            this.buttonToStock.UseVisualStyleBackColor = true;
            this.buttonToStock.Click += new System.EventHandler(this.buttonToStock_Click);
            // 
            // buttonToCurrentAll
            // 
            this.buttonToCurrentAll.Location = new System.Drawing.Point(221, 106);
            this.buttonToCurrentAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonToCurrentAll.Name = "buttonToCurrentAll";
            this.buttonToCurrentAll.Size = new System.Drawing.Size(32, 20);
            this.buttonToCurrentAll.TabIndex = 7;
            this.buttonToCurrentAll.Text = ">>";
            this.buttonToCurrentAll.UseVisualStyleBackColor = true;
            this.buttonToCurrentAll.Click += new System.EventHandler(this.buttonToCurrentAll_Click);
            // 
            // buttonToCurrent
            // 
            this.buttonToCurrent.Enabled = false;
            this.buttonToCurrent.Location = new System.Drawing.Point(221, 83);
            this.buttonToCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonToCurrent.Name = "buttonToCurrent";
            this.buttonToCurrent.Size = new System.Drawing.Size(32, 20);
            this.buttonToCurrent.TabIndex = 6;
            this.buttonToCurrent.Text = ">";
            this.buttonToCurrent.UseVisualStyleBackColor = true;
            this.buttonToCurrent.Click += new System.EventHandler(this.buttonToCurrent_Click);
            // 
            // labelCurrentAttributes
            // 
            this.labelCurrentAttributes.AutoSize = true;
            this.labelCurrentAttributes.Location = new System.Drawing.Point(309, 46);
            this.labelCurrentAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentAttributes.Name = "labelCurrentAttributes";
            this.labelCurrentAttributes.Size = new System.Drawing.Size(102, 13);
            this.labelCurrentAttributes.TabIndex = 5;
            this.labelCurrentAttributes.Text = "Текущие атрибуты";
            // 
            // listBoxCurrent
            // 
            this.listBoxCurrent.FormattingEnabled = true;
            this.listBoxCurrent.Location = new System.Drawing.Point(296, 64);
            this.listBoxCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCurrent.Name = "listBoxCurrent";
            this.listBoxCurrent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCurrent.Size = new System.Drawing.Size(130, 173);
            this.listBoxCurrent.TabIndex = 4;
            this.listBoxCurrent.Click += new System.EventHandler(this.listBoxCurrent_Click);
            // 
            // listBoxStock
            // 
            this.listBoxStock.FormattingEnabled = true;
            this.listBoxStock.Location = new System.Drawing.Point(51, 64);
            this.listBoxStock.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStock.Name = "listBoxStock";
            this.listBoxStock.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStock.Size = new System.Drawing.Size(130, 173);
            this.listBoxStock.TabIndex = 3;
            this.listBoxStock.Click += new System.EventHandler(this.listBoxStock_Click);
            // 
            // labelTableAttributes
            // 
            this.labelTableAttributes.AutoSize = true;
            this.labelTableAttributes.Location = new System.Drawing.Point(84, 47);
            this.labelTableAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTableAttributes.Name = "labelTableAttributes";
            this.labelTableAttributes.Size = new System.Drawing.Size(55, 13);
            this.labelTableAttributes.TabIndex = 2;
            this.labelTableAttributes.Text = "Атрибуты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главная таблица";
            // 
            // comboBoxMainTable
            // 
            this.comboBoxMainTable.FormattingEnabled = true;
            this.comboBoxMainTable.Location = new System.Drawing.Point(10, 22);
            this.comboBoxMainTable.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMainTable.Name = "comboBoxMainTable";
            this.comboBoxMainTable.Size = new System.Drawing.Size(201, 21);
            this.comboBoxMainTable.TabIndex = 0;
            this.comboBoxMainTable.SelectedValueChanged += new System.EventHandler(this.comboBoxTables_SelectedValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelViewPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(495, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "Form";
            this.tabPage2.Text = "Форма";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelViewPage
            // 
            this.PanelViewPage.AutoScroll = true;
            this.PanelViewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelViewPage.Location = new System.Drawing.Point(2, 2);
            this.PanelViewPage.Margin = new System.Windows.Forms.Padding(2);
            this.PanelViewPage.Name = "PanelViewPage";
            this.PanelViewPage.Size = new System.Drawing.Size(491, 285);
            this.PanelViewPage.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(495, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "Table";
            this.tabPage3.Text = "Таблица";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 315);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewForm";
            this.Text = "VIewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttontoStockAll;
        private System.Windows.Forms.Button buttonToStock;
        private System.Windows.Forms.Button buttonToCurrentAll;
        private System.Windows.Forms.Button buttonToCurrent;
        private System.Windows.Forms.Label labelCurrentAttributes;
        private System.Windows.Forms.ListBox listBoxCurrent;
        private System.Windows.Forms.ListBox listBoxStock;
        private System.Windows.Forms.Label labelTableAttributes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMainTable;
        private System.Windows.Forms.Panel PanelViewPage;
        private System.Windows.Forms.ComboBox comboBoxChildTable;
        private System.Windows.Forms.Label label2;
    }
}
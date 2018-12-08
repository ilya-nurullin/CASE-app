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
            this.buttontoStockAll = new System.Windows.Forms.Button();
            this.buttonToStock = new System.Windows.Forms.Button();
            this.buttonToCurrentAll = new System.Windows.Forms.Button();
            this.buttonToCurrent = new System.Windows.Forms.Button();
            this.labelCurrentAttributes = new System.Windows.Forms.Label();
            this.listBoxCurrent = new System.Windows.Forms.ListBox();
            this.listBoxStock = new System.Windows.Forms.ListBox();
            this.labelTableAttributes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
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
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttontoStockAll);
            this.tabPage1.Controls.Add(this.buttonToStock);
            this.tabPage1.Controls.Add(this.buttonToCurrentAll);
            this.tabPage1.Controls.Add(this.buttonToCurrent);
            this.tabPage1.Controls.Add(this.labelCurrentAttributes);
            this.tabPage1.Controls.Add(this.listBoxCurrent);
            this.tabPage1.Controls.Add(this.listBoxStock);
            this.tabPage1.Controls.Add(this.labelTableAttributes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxTables);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "Attributes";
            this.tabPage1.Text = "Атрибуты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttontoStockAll
            // 
            this.buttontoStockAll.Location = new System.Drawing.Point(213, 214);
            this.buttontoStockAll.Name = "buttontoStockAll";
            this.buttontoStockAll.Size = new System.Drawing.Size(43, 24);
            this.buttontoStockAll.TabIndex = 9;
            this.buttontoStockAll.Text = "<<";
            this.buttontoStockAll.UseVisualStyleBackColor = true;
            this.buttontoStockAll.Click += new System.EventHandler(this.buttontoStockAll_Click);
            // 
            // buttonToStock
            // 
            this.buttonToStock.Location = new System.Drawing.Point(213, 185);
            this.buttonToStock.Name = "buttonToStock";
            this.buttonToStock.Size = new System.Drawing.Size(43, 24);
            this.buttonToStock.TabIndex = 8;
            this.buttonToStock.Text = "<";
            this.buttonToStock.UseVisualStyleBackColor = true;
            this.buttonToStock.Click += new System.EventHandler(this.buttonToStock_Click);
            // 
            // buttonToCurrentAll
            // 
            this.buttonToCurrentAll.Location = new System.Drawing.Point(213, 131);
            this.buttonToCurrentAll.Name = "buttonToCurrentAll";
            this.buttonToCurrentAll.Size = new System.Drawing.Size(43, 24);
            this.buttonToCurrentAll.TabIndex = 7;
            this.buttonToCurrentAll.Text = ">>";
            this.buttonToCurrentAll.UseVisualStyleBackColor = true;
            this.buttonToCurrentAll.Click += new System.EventHandler(this.buttonToCurrentAll_Click);
            // 
            // buttonToCurrent
            // 
            this.buttonToCurrent.Enabled = false;
            this.buttonToCurrent.Location = new System.Drawing.Point(213, 102);
            this.buttonToCurrent.Name = "buttonToCurrent";
            this.buttonToCurrent.Size = new System.Drawing.Size(43, 24);
            this.buttonToCurrent.TabIndex = 6;
            this.buttonToCurrent.Text = ">";
            this.buttonToCurrent.UseVisualStyleBackColor = true;
            this.buttonToCurrent.Click += new System.EventHandler(this.buttonToCurrent_Click);
            // 
            // labelCurrentAttributes
            // 
            this.labelCurrentAttributes.AutoSize = true;
            this.labelCurrentAttributes.Location = new System.Drawing.Point(282, 57);
            this.labelCurrentAttributes.Name = "labelCurrentAttributes";
            this.labelCurrentAttributes.Size = new System.Drawing.Size(133, 17);
            this.labelCurrentAttributes.TabIndex = 5;
            this.labelCurrentAttributes.Text = "Текущие атрибуты";
            // 
            // listBoxCurrent
            // 
            this.listBoxCurrent.FormattingEnabled = true;
            this.listBoxCurrent.ItemHeight = 16;
            this.listBoxCurrent.Location = new System.Drawing.Point(282, 79);
            this.listBoxCurrent.Name = "listBoxCurrent";
            this.listBoxCurrent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCurrent.Size = new System.Drawing.Size(172, 212);
            this.listBoxCurrent.TabIndex = 4;
            this.listBoxCurrent.Click += new System.EventHandler(this.listBoxCurrent_Click);
            // 
            // listBoxStock
            // 
            this.listBoxStock.FormattingEnabled = true;
            this.listBoxStock.ItemHeight = 16;
            this.listBoxStock.Location = new System.Drawing.Point(14, 79);
            this.listBoxStock.Name = "listBoxStock";
            this.listBoxStock.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStock.Size = new System.Drawing.Size(172, 212);
            this.listBoxStock.TabIndex = 3;
            this.listBoxStock.Click += new System.EventHandler(this.listBoxStock_Click);
            // 
            // labelTableAttributes
            // 
            this.labelTableAttributes.AutoSize = true;
            this.labelTableAttributes.Location = new System.Drawing.Point(11, 58);
            this.labelTableAttributes.Name = "labelTableAttributes";
            this.labelTableAttributes.Size = new System.Drawing.Size(72, 17);
            this.labelTableAttributes.TabIndex = 2;
            this.labelTableAttributes.Text = "Атрибуты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(14, 27);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(440, 24);
            this.comboBoxTables.TabIndex = 0;
            this.comboBoxTables.SelectedValueChanged += new System.EventHandler(this.comboBoxTables_SelectedValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelViewPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "Form";
            this.tabPage2.Text = "Форма";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelViewPage
            // 
            this.PanelViewPage.AutoScroll = true;
            this.PanelViewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelViewPage.Location = new System.Drawing.Point(3, 3);
            this.PanelViewPage.Name = "PanelViewPage";
            this.PanelViewPage.Size = new System.Drawing.Size(786, 415);
            this.PanelViewPage.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
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
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Panel PanelViewPage;
    }
}
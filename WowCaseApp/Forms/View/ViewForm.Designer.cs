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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelViewPage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.buttonNextVal = new System.Windows.Forms.Button();
            this.buttonPrevVal = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.PanelViewPage);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(663, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "Form";
            this.tabPage2.Text = "Форма";
            // 
            // PanelViewPage
            // 
            this.PanelViewPage.AutoScroll = true;
            this.PanelViewPage.BackColor = System.Drawing.Color.White;
            this.PanelViewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelViewPage.Location = new System.Drawing.Point(3, 50);
            this.PanelViewPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelViewPage.Name = "PanelViewPage";
            this.PanelViewPage.Size = new System.Drawing.Size(657, 305);
            this.PanelViewPage.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.countLabel);
            this.panel1.Controls.Add(this.buttonNextVal);
            this.panel1.Controls.Add(this.buttonPrevVal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 48);
            this.panel1.TabIndex = 0;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(173, 16);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(28, 17);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "1/1";
            // 
            // buttonNextVal
            // 
            this.buttonNextVal.Location = new System.Drawing.Point(236, 5);
            this.buttonNextVal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNextVal.Name = "buttonNextVal";
            this.buttonNextVal.Size = new System.Drawing.Size(133, 39);
            this.buttonNextVal.TabIndex = 1;
            this.buttonNextVal.Text = "Следующий >";
            this.buttonNextVal.UseVisualStyleBackColor = true;
            this.buttonNextVal.Click += new System.EventHandler(this.buttonNextVal_Click);
            // 
            // buttonPrevVal
            // 
            this.buttonPrevVal.Location = new System.Drawing.Point(9, 5);
            this.buttonPrevVal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevVal.Name = "buttonPrevVal";
            this.buttonPrevVal.Size = new System.Drawing.Size(133, 39);
            this.buttonPrevVal.TabIndex = 0;
            this.buttonPrevVal.Text = "< Предыдущий";
            this.buttonPrevVal.UseVisualStyleBackColor = true;
            this.buttonPrevVal.Click += new System.EventHandler(this.buttonPrevVal_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.downButton);
            this.tabPage1.Controls.Add(this.upButton);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(663, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "Attributes";
            this.tabPage1.Text = "Атрибуты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Enabled = false;
            this.downButton.Location = new System.Drawing.Point(599, 169);
            this.downButton.Margin = new System.Windows.Forms.Padding(4);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(32, 28);
            this.downButton.TabIndex = 13;
            this.downButton.Text = "▼";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Enabled = false;
            this.upButton.Location = new System.Drawing.Point(599, 127);
            this.upButton.Margin = new System.Windows.Forms.Padding(4);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(32, 28);
            this.upButton.TabIndex = 12;
            this.upButton.Text = "▲";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Подчинённая таблица";
            // 
            // comboBoxChildTable
            // 
            this.comboBoxChildTable.FormattingEnabled = true;
            this.comboBoxChildTable.Location = new System.Drawing.Point(341, 27);
            this.comboBoxChildTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChildTable.Name = "comboBoxChildTable";
            this.comboBoxChildTable.Size = new System.Drawing.Size(267, 24);
            this.comboBoxChildTable.TabIndex = 10;
            this.comboBoxChildTable.SelectedValueChanged += new System.EventHandler(this.comboBoxTables_SelectedValueChanged);
            // 
            // buttontoStockAll
            // 
            this.buttontoStockAll.Location = new System.Drawing.Point(295, 214);
            this.buttontoStockAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttontoStockAll.Name = "buttontoStockAll";
            this.buttontoStockAll.Size = new System.Drawing.Size(43, 25);
            this.buttontoStockAll.TabIndex = 9;
            this.buttontoStockAll.Text = "<<";
            this.buttontoStockAll.UseVisualStyleBackColor = true;
            this.buttontoStockAll.Click += new System.EventHandler(this.buttontoStockAll_Click);
            // 
            // buttonToStock
            // 
            this.buttonToStock.Enabled = false;
            this.buttonToStock.Location = new System.Drawing.Point(295, 185);
            this.buttonToStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonToStock.Name = "buttonToStock";
            this.buttonToStock.Size = new System.Drawing.Size(43, 25);
            this.buttonToStock.TabIndex = 8;
            this.buttonToStock.Text = "<";
            this.buttonToStock.UseVisualStyleBackColor = true;
            this.buttonToStock.Click += new System.EventHandler(this.buttonToStock_Click);
            // 
            // buttonToCurrentAll
            // 
            this.buttonToCurrentAll.Location = new System.Drawing.Point(295, 130);
            this.buttonToCurrentAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonToCurrentAll.Name = "buttonToCurrentAll";
            this.buttonToCurrentAll.Size = new System.Drawing.Size(43, 25);
            this.buttonToCurrentAll.TabIndex = 7;
            this.buttonToCurrentAll.Text = ">>";
            this.buttonToCurrentAll.UseVisualStyleBackColor = true;
            this.buttonToCurrentAll.Click += new System.EventHandler(this.buttonToCurrentAll_Click);
            // 
            // buttonToCurrent
            // 
            this.buttonToCurrent.Enabled = false;
            this.buttonToCurrent.Location = new System.Drawing.Point(295, 102);
            this.buttonToCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonToCurrent.Name = "buttonToCurrent";
            this.buttonToCurrent.Size = new System.Drawing.Size(43, 25);
            this.buttonToCurrent.TabIndex = 6;
            this.buttonToCurrent.Text = ">";
            this.buttonToCurrent.UseVisualStyleBackColor = true;
            this.buttonToCurrent.Click += new System.EventHandler(this.buttonToCurrent_Click);
            // 
            // labelCurrentAttributes
            // 
            this.labelCurrentAttributes.AutoSize = true;
            this.labelCurrentAttributes.Location = new System.Drawing.Point(412, 57);
            this.labelCurrentAttributes.Name = "labelCurrentAttributes";
            this.labelCurrentAttributes.Size = new System.Drawing.Size(133, 17);
            this.labelCurrentAttributes.TabIndex = 5;
            this.labelCurrentAttributes.Text = "Текущие атрибуты";
            // 
            // listBoxCurrent
            // 
            this.listBoxCurrent.FormattingEnabled = true;
            this.listBoxCurrent.ItemHeight = 16;
            this.listBoxCurrent.Location = new System.Drawing.Point(395, 79);
            this.listBoxCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCurrent.Name = "listBoxCurrent";
            this.listBoxCurrent.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxCurrent.Size = new System.Drawing.Size(172, 212);
            this.listBoxCurrent.TabIndex = 4;
            this.listBoxCurrent.Click += new System.EventHandler(this.listBoxCurrent_Click);
            // 
            // listBoxStock
            // 
            this.listBoxStock.FormattingEnabled = true;
            this.listBoxStock.ItemHeight = 16;
            this.listBoxStock.Location = new System.Drawing.Point(68, 79);
            this.listBoxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxStock.Name = "listBoxStock";
            this.listBoxStock.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStock.Size = new System.Drawing.Size(172, 212);
            this.listBoxStock.TabIndex = 3;
            this.listBoxStock.Click += new System.EventHandler(this.listBoxStock_Click);
            // 
            // labelTableAttributes
            // 
            this.labelTableAttributes.AutoSize = true;
            this.labelTableAttributes.Location = new System.Drawing.Point(112, 58);
            this.labelTableAttributes.Name = "labelTableAttributes";
            this.labelTableAttributes.Size = new System.Drawing.Size(72, 17);
            this.labelTableAttributes.TabIndex = 2;
            this.labelTableAttributes.Text = "Атрибуты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главная таблица";
            // 
            // comboBoxMainTable
            // 
            this.comboBoxMainTable.FormattingEnabled = true;
            this.comboBoxMainTable.Location = new System.Drawing.Point(13, 27);
            this.comboBoxMainTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMainTable.Name = "comboBoxMainTable";
            this.comboBoxMainTable.Size = new System.Drawing.Size(267, 24);
            this.comboBoxMainTable.TabIndex = 0;
            this.comboBoxMainTable.SelectedValueChanged += new System.EventHandler(this.comboBoxTables_SelectedValueChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(671, 388);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 388);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewForm";
            this.Text = "VIewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewForm_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelViewPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button buttonNextVal;
        private System.Windows.Forms.Button buttonPrevVal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChildTable;
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
        private System.Windows.Forms.TabControl tabControl;
    }
}
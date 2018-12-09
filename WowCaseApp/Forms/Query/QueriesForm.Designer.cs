namespace WowCaseApp
{
    partial class QueriesForm
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
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.labelTables = new System.Windows.Forms.Label();
            this.labelAllFields = new System.Windows.Forms.Label();
            this.labelSelectedFields = new System.Windows.Forms.Label();
            this.listBoxAvailable = new System.Windows.Forms.ListBox();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.btnAddSelected = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.labelJoins = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.CreateQuery = new System.Windows.Forms.Button();
            this.cmbItems1 = new System.Windows.Forms.ComboBox();
            this.cmbOperations1 = new System.Windows.Forms.ComboBox();
            this.txbValues1 = new System.Windows.Forms.TextBox();
            this.cmbJoins1 = new System.Windows.Forms.ComboBox();
            this.cmbJoins2 = new System.Windows.Forms.ComboBox();
            this.txbValues2 = new System.Windows.Forms.TextBox();
            this.cmbOperations2 = new System.Windows.Forms.ComboBox();
            this.cmbItems2 = new System.Windows.Forms.ComboBox();
            this.cmbJoins3 = new System.Windows.Forms.ComboBox();
            this.txbValues3 = new System.Windows.Forms.TextBox();
            this.cmbOperations3 = new System.Windows.Forms.ComboBox();
            this.cmbItems3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Items.AddRange(new object[] {
            "БД 1",
            "БД 2",
            "БД 3"});
            this.cmbTables.Location = new System.Drawing.Point(301, 29);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(351, 24);
            this.cmbTables.TabIndex = 0;
            // 
            // labelTables
            // 
            this.labelTables.AutoSize = true;
            this.labelTables.Location = new System.Drawing.Point(54, 36);
            this.labelTables.Name = "labelTables";
            this.labelTables.Size = new System.Drawing.Size(77, 17);
            this.labelTables.TabIndex = 1;
            this.labelTables.Text = "Таблица : ";
            // 
            // labelAllFields
            // 
            this.labelAllFields.AutoSize = true;
            this.labelAllFields.Location = new System.Drawing.Point(54, 90);
            this.labelAllFields.Name = "labelAllFields";
            this.labelAllFields.Size = new System.Drawing.Size(118, 17);
            this.labelAllFields.TabIndex = 2;
            this.labelAllFields.Text = "Доступные поля";
            // 
            // labelSelectedFields
            // 
            this.labelSelectedFields.AutoSize = true;
            this.labelSelectedFields.Location = new System.Drawing.Point(531, 90);
            this.labelSelectedFields.Name = "labelSelectedFields";
            this.labelSelectedFields.Size = new System.Drawing.Size(121, 17);
            this.labelSelectedFields.TabIndex = 3;
            this.labelSelectedFields.Text = "Выбранные поля";
            // 
            // listBoxAvailable
            // 
            this.listBoxAvailable.FormattingEnabled = true;
            this.listBoxAvailable.ItemHeight = 16;
            this.listBoxAvailable.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBoxAvailable.Location = new System.Drawing.Point(57, 135);
            this.listBoxAvailable.Name = "listBoxAvailable";
            this.listBoxAvailable.Size = new System.Drawing.Size(228, 164);
            this.listBoxAvailable.TabIndex = 4;
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 16;
            this.listBoxSelected.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBoxSelected.Location = new System.Drawing.Point(424, 135);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(228, 164);
            this.listBoxSelected.TabIndex = 5;
            // 
            // btnAddSelected
            // 
            this.btnAddSelected.Location = new System.Drawing.Point(337, 148);
            this.btnAddSelected.Name = "btnAddSelected";
            this.btnAddSelected.Size = new System.Drawing.Size(43, 23);
            this.btnAddSelected.TabIndex = 6;
            this.btnAddSelected.Text = ">";
            this.btnAddSelected.UseVisualStyleBackColor = true;
            this.btnAddSelected.Click += new System.EventHandler(this.btnAddSelected_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAll.Location = new System.Drawing.Point(337, 177);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(43, 23);
            this.btnAddAll.TabIndex = 7;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(337, 227);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(43, 23);
            this.btnDeleteSelected.TabIndex = 8;
            this.btnDeleteSelected.Text = "<";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(337, 256);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(43, 23);
            this.btnDeleteAll.TabIndex = 9;
            this.btnDeleteAll.Text = "<<";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // labelJoins
            // 
            this.labelJoins.AutoSize = true;
            this.labelJoins.Location = new System.Drawing.Point(298, 338);
            this.labelJoins.Name = "labelJoins";
            this.labelJoins.Size = new System.Drawing.Size(126, 17);
            this.labelJoins.TabIndex = 11;
            this.labelJoins.Text = "Выбрать условия:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // CreateQuery
            // 
            this.CreateQuery.Location = new System.Drawing.Point(497, 308);
            this.CreateQuery.Name = "CreateQuery";
            this.CreateQuery.Size = new System.Drawing.Size(155, 23);
            this.CreateQuery.TabIndex = 13;
            this.CreateQuery.Text = "Создать запрос";
            this.CreateQuery.UseVisualStyleBackColor = true;
            this.CreateQuery.Click += new System.EventHandler(this.CreateQuery_Click);
            // 
            // cmbItems1
            // 
            this.cmbItems1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems1.FormattingEnabled = true;
            this.cmbItems1.Location = new System.Drawing.Point(57, 374);
            this.cmbItems1.Name = "cmbItems1";
            this.cmbItems1.Size = new System.Drawing.Size(228, 24);
            this.cmbItems1.TabIndex = 14;
            // 
            // cmbOperations1
            // 
            this.cmbOperations1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperations1.FormattingEnabled = true;
            this.cmbOperations1.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "IS NULL",
            "IS NOT NULL",
            "=",
            "!="});
            this.cmbOperations1.Location = new System.Drawing.Point(291, 374);
            this.cmbOperations1.Name = "cmbOperations1";
            this.cmbOperations1.Size = new System.Drawing.Size(79, 24);
            this.cmbOperations1.TabIndex = 15;
            // 
            // txbValues1
            // 
            this.txbValues1.Location = new System.Drawing.Point(376, 374);
            this.txbValues1.Name = "txbValues1";
            this.txbValues1.Size = new System.Drawing.Size(199, 22);
            this.txbValues1.TabIndex = 16;
            // 
            // cmbJoins1
            // 
            this.cmbJoins1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoins1.FormattingEnabled = true;
            this.cmbJoins1.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoins1.Location = new System.Drawing.Point(581, 374);
            this.cmbJoins1.Name = "cmbJoins1";
            this.cmbJoins1.Size = new System.Drawing.Size(71, 24);
            this.cmbJoins1.TabIndex = 17;
            // 
            // cmbJoins2
            // 
            this.cmbJoins2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoins2.FormattingEnabled = true;
            this.cmbJoins2.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoins2.Location = new System.Drawing.Point(581, 404);
            this.cmbJoins2.Name = "cmbJoins2";
            this.cmbJoins2.Size = new System.Drawing.Size(71, 24);
            this.cmbJoins2.TabIndex = 21;
            // 
            // txbValues2
            // 
            this.txbValues2.Location = new System.Drawing.Point(376, 404);
            this.txbValues2.Name = "txbValues2";
            this.txbValues2.Size = new System.Drawing.Size(199, 22);
            this.txbValues2.TabIndex = 20;
            // 
            // cmbOperations2
            // 
            this.cmbOperations2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperations2.FormattingEnabled = true;
            this.cmbOperations2.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "IS NULL",
            "IS NOT NULL",
            "=",
            "!="});
            this.cmbOperations2.Location = new System.Drawing.Point(291, 404);
            this.cmbOperations2.Name = "cmbOperations2";
            this.cmbOperations2.Size = new System.Drawing.Size(79, 24);
            this.cmbOperations2.TabIndex = 19;
            // 
            // cmbItems2
            // 
            this.cmbItems2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems2.FormattingEnabled = true;
            this.cmbItems2.Location = new System.Drawing.Point(57, 404);
            this.cmbItems2.Name = "cmbItems2";
            this.cmbItems2.Size = new System.Drawing.Size(228, 24);
            this.cmbItems2.TabIndex = 18;
            // 
            // cmbJoins3
            // 
            this.cmbJoins3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoins3.FormattingEnabled = true;
            this.cmbJoins3.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoins3.Location = new System.Drawing.Point(581, 434);
            this.cmbJoins3.Name = "cmbJoins3";
            this.cmbJoins3.Size = new System.Drawing.Size(71, 24);
            this.cmbJoins3.TabIndex = 25;
            // 
            // txbValues3
            // 
            this.txbValues3.Location = new System.Drawing.Point(376, 434);
            this.txbValues3.Name = "txbValues3";
            this.txbValues3.Size = new System.Drawing.Size(199, 22);
            this.txbValues3.TabIndex = 24;
            // 
            // cmbOperations3
            // 
            this.cmbOperations3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperations3.FormattingEnabled = true;
            this.cmbOperations3.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "IS NULL",
            "IS NOT NULL",
            "=",
            "!="});
            this.cmbOperations3.Location = new System.Drawing.Point(291, 434);
            this.cmbOperations3.Name = "cmbOperations3";
            this.cmbOperations3.Size = new System.Drawing.Size(79, 24);
            this.cmbOperations3.TabIndex = 23;
            // 
            // cmbItems3
            // 
            this.cmbItems3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems3.FormattingEnabled = true;
            this.cmbItems3.Location = new System.Drawing.Point(57, 434);
            this.cmbItems3.Name = "cmbItems3";
            this.cmbItems3.Size = new System.Drawing.Size(228, 24);
            this.cmbItems3.TabIndex = 22;
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 584);
            this.Controls.Add(this.cmbJoins3);
            this.Controls.Add(this.txbValues3);
            this.Controls.Add(this.cmbOperations3);
            this.Controls.Add(this.cmbItems3);
            this.Controls.Add(this.cmbJoins2);
            this.Controls.Add(this.txbValues2);
            this.Controls.Add(this.cmbOperations2);
            this.Controls.Add(this.cmbItems2);
            this.Controls.Add(this.cmbJoins1);
            this.Controls.Add(this.txbValues1);
            this.Controls.Add(this.cmbOperations1);
            this.Controls.Add(this.cmbItems1);
            this.Controls.Add(this.CreateQuery);
            this.Controls.Add(this.labelJoins);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAddSelected);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.listBoxAvailable);
            this.Controls.Add(this.labelSelectedFields);
            this.Controls.Add(this.labelAllFields);
            this.Controls.Add(this.labelTables);
            this.Controls.Add(this.cmbTables);
            this.Name = "QueriesForm";
            this.Text = "ChildForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label labelTables;
        private System.Windows.Forms.Label labelAllFields;
        private System.Windows.Forms.Label labelSelectedFields;
        private System.Windows.Forms.ListBox listBoxAvailable;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.Button btnAddSelected;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label labelJoins;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button CreateQuery;
        private System.Windows.Forms.ComboBox cmbItems1;
        private System.Windows.Forms.ComboBox cmbOperations1;
        private System.Windows.Forms.TextBox txbValues1;
        private System.Windows.Forms.ComboBox cmbJoins1;
        private System.Windows.Forms.ComboBox cmbJoins2;
        private System.Windows.Forms.TextBox txbValues2;
        private System.Windows.Forms.ComboBox cmbOperations2;
        private System.Windows.Forms.ComboBox cmbItems2;
        private System.Windows.Forms.ComboBox cmbJoins3;
        private System.Windows.Forms.TextBox txbValues3;
        private System.Windows.Forms.ComboBox cmbOperations3;
        private System.Windows.Forms.ComboBox cmbItems3;
    }
}
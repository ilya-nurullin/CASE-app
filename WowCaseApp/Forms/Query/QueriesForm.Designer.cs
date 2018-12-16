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
            this.tabControlQuery = new System.Windows.Forms.TabControl();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.btnAddJoin = new System.Windows.Forms.Button();
            this.cmbJoins3 = new System.Windows.Forms.ComboBox();
            this.txbValues3 = new System.Windows.Forms.TextBox();
            this.cmbOperations3 = new System.Windows.Forms.ComboBox();
            this.cmbItems3 = new System.Windows.Forms.ComboBox();
            this.cmbJoins2 = new System.Windows.Forms.ComboBox();
            this.txbValues2 = new System.Windows.Forms.TextBox();
            this.cmbOperations2 = new System.Windows.Forms.ComboBox();
            this.cmbItems2 = new System.Windows.Forms.ComboBox();
            this.cmbJoins1 = new System.Windows.Forms.ComboBox();
            this.txbValues1 = new System.Windows.Forms.TextBox();
            this.cmbOperations1 = new System.Windows.Forms.ComboBox();
            this.cmbItems1 = new System.Windows.Forms.ComboBox();
            this.CreateQuery = new System.Windows.Forms.Button();
            this.labelJoins = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAddSelected = new System.Windows.Forms.Button();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.listBoxAvailable = new System.Windows.Forms.ListBox();
            this.labelSelectedFields = new System.Windows.Forms.Label();
            this.labelAllFields = new System.Windows.Forms.Label();
            this.labelTables = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.listBoxJoins = new System.Windows.Forms.ListBox();
            this.labelForListBoxJoin = new System.Windows.Forms.Label();
            this.btnDeleteJoin = new System.Windows.Forms.Button();
            this.btnClearJoin = new System.Windows.Forms.Button();
            this.tabControlQuery.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlQuery
            // 
            this.tabControlQuery.Controls.Add(this.tabPageQuery);
            this.tabControlQuery.Controls.Add(this.tabPageResult);
            this.tabControlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQuery.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuery.Name = "tabControlQuery";
            this.tabControlQuery.SelectedIndex = 0;
            this.tabControlQuery.Size = new System.Drawing.Size(1221, 584);
            this.tabControlQuery.TabIndex = 0;
            this.tabControlQuery.SelectedIndexChanged += new System.EventHandler(this.Query_SelectedIndexChanged);
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.btnClearJoin);
            this.tabPageQuery.Controls.Add(this.btnDeleteJoin);
            this.tabPageQuery.Controls.Add(this.labelForListBoxJoin);
            this.tabPageQuery.Controls.Add(this.listBoxJoins);
            this.tabPageQuery.Controls.Add(this.btnAddJoin);
            this.tabPageQuery.Controls.Add(this.cmbJoins3);
            this.tabPageQuery.Controls.Add(this.txbValues3);
            this.tabPageQuery.Controls.Add(this.cmbOperations3);
            this.tabPageQuery.Controls.Add(this.cmbItems3);
            this.tabPageQuery.Controls.Add(this.cmbJoins2);
            this.tabPageQuery.Controls.Add(this.txbValues2);
            this.tabPageQuery.Controls.Add(this.cmbOperations2);
            this.tabPageQuery.Controls.Add(this.cmbItems2);
            this.tabPageQuery.Controls.Add(this.cmbJoins1);
            this.tabPageQuery.Controls.Add(this.txbValues1);
            this.tabPageQuery.Controls.Add(this.cmbOperations1);
            this.tabPageQuery.Controls.Add(this.cmbItems1);
            this.tabPageQuery.Controls.Add(this.CreateQuery);
            this.tabPageQuery.Controls.Add(this.labelJoins);
            this.tabPageQuery.Controls.Add(this.btnDeleteAll);
            this.tabPageQuery.Controls.Add(this.btnDeleteSelected);
            this.tabPageQuery.Controls.Add(this.btnAddAll);
            this.tabPageQuery.Controls.Add(this.btnAddSelected);
            this.tabPageQuery.Controls.Add(this.listBoxSelected);
            this.tabPageQuery.Controls.Add(this.listBoxAvailable);
            this.tabPageQuery.Controls.Add(this.labelSelectedFields);
            this.tabPageQuery.Controls.Add(this.labelAllFields);
            this.tabPageQuery.Controls.Add(this.labelTables);
            this.tabPageQuery.Controls.Add(this.cmbTables);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuery.Size = new System.Drawing.Size(1213, 555);
            this.tabPageQuery.TabIndex = 0;
            this.tabPageQuery.Text = "Конструктор запроса";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // btnAddJoin
            // 
            this.btnAddJoin.Location = new System.Drawing.Point(84, 326);
            this.btnAddJoin.Name = "btnAddJoin";
            this.btnAddJoin.Size = new System.Drawing.Size(144, 23);
            this.btnAddJoin.TabIndex = 51;
            this.btnAddJoin.Text = "Добавить связь";
            this.btnAddJoin.UseVisualStyleBackColor = true;
            this.btnAddJoin.Click += new System.EventHandler(this.btnAddJoin_Click);
            // 
            // cmbJoins3
            // 
            this.cmbJoins3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoins3.FormattingEnabled = true;
            this.cmbJoins3.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoins3.Location = new System.Drawing.Point(608, 452);
            this.cmbJoins3.Name = "cmbJoins3";
            this.cmbJoins3.Size = new System.Drawing.Size(71, 24);
            this.cmbJoins3.TabIndex = 50;
            // 
            // txbValues3
            // 
            this.txbValues3.Location = new System.Drawing.Point(403, 452);
            this.txbValues3.Name = "txbValues3";
            this.txbValues3.Size = new System.Drawing.Size(199, 22);
            this.txbValues3.TabIndex = 49;
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
            this.cmbOperations3.Location = new System.Drawing.Point(318, 452);
            this.cmbOperations3.Name = "cmbOperations3";
            this.cmbOperations3.Size = new System.Drawing.Size(79, 24);
            this.cmbOperations3.TabIndex = 48;
            // 
            // cmbItems3
            // 
            this.cmbItems3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems3.FormattingEnabled = true;
            this.cmbItems3.Location = new System.Drawing.Point(84, 452);
            this.cmbItems3.Name = "cmbItems3";
            this.cmbItems3.Size = new System.Drawing.Size(228, 24);
            this.cmbItems3.TabIndex = 47;
            // 
            // cmbJoins2
            // 
            this.cmbJoins2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoins2.FormattingEnabled = true;
            this.cmbJoins2.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoins2.Location = new System.Drawing.Point(608, 422);
            this.cmbJoins2.Name = "cmbJoins2";
            this.cmbJoins2.Size = new System.Drawing.Size(71, 24);
            this.cmbJoins2.TabIndex = 46;
            // 
            // txbValues2
            // 
            this.txbValues2.Location = new System.Drawing.Point(403, 422);
            this.txbValues2.Name = "txbValues2";
            this.txbValues2.Size = new System.Drawing.Size(199, 22);
            this.txbValues2.TabIndex = 45;
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
            this.cmbOperations2.Location = new System.Drawing.Point(318, 422);
            this.cmbOperations2.Name = "cmbOperations2";
            this.cmbOperations2.Size = new System.Drawing.Size(79, 24);
            this.cmbOperations2.TabIndex = 44;
            // 
            // cmbItems2
            // 
            this.cmbItems2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems2.FormattingEnabled = true;
            this.cmbItems2.Location = new System.Drawing.Point(84, 422);
            this.cmbItems2.Name = "cmbItems2";
            this.cmbItems2.Size = new System.Drawing.Size(228, 24);
            this.cmbItems2.TabIndex = 43;
            // 
            // cmbJoins1
            // 
            this.cmbJoins1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoins1.FormattingEnabled = true;
            this.cmbJoins1.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoins1.Location = new System.Drawing.Point(608, 392);
            this.cmbJoins1.Name = "cmbJoins1";
            this.cmbJoins1.Size = new System.Drawing.Size(71, 24);
            this.cmbJoins1.TabIndex = 42;
            // 
            // txbValues1
            // 
            this.txbValues1.Location = new System.Drawing.Point(403, 392);
            this.txbValues1.Name = "txbValues1";
            this.txbValues1.Size = new System.Drawing.Size(199, 22);
            this.txbValues1.TabIndex = 41;
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
            this.cmbOperations1.Location = new System.Drawing.Point(318, 392);
            this.cmbOperations1.Name = "cmbOperations1";
            this.cmbOperations1.Size = new System.Drawing.Size(79, 24);
            this.cmbOperations1.TabIndex = 40;
            // 
            // cmbItems1
            // 
            this.cmbItems1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems1.FormattingEnabled = true;
            this.cmbItems1.Location = new System.Drawing.Point(84, 392);
            this.cmbItems1.Name = "cmbItems1";
            this.cmbItems1.Size = new System.Drawing.Size(228, 24);
            this.cmbItems1.TabIndex = 39;
            // 
            // CreateQuery
            // 
            this.CreateQuery.Location = new System.Drawing.Point(729, 446);
            this.CreateQuery.Name = "CreateQuery";
            this.CreateQuery.Size = new System.Drawing.Size(310, 28);
            this.CreateQuery.TabIndex = 38;
            this.CreateQuery.Text = "Выполнить запрос";
            this.CreateQuery.UseVisualStyleBackColor = true;
            this.CreateQuery.Click += new System.EventHandler(this.CreateQuery_Click);
            // 
            // labelJoins
            // 
            this.labelJoins.AutoSize = true;
            this.labelJoins.Location = new System.Drawing.Point(325, 356);
            this.labelJoins.Name = "labelJoins";
            this.labelJoins.Size = new System.Drawing.Size(126, 17);
            this.labelJoins.TabIndex = 37;
            this.labelJoins.Text = "Выбрать условия:";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(364, 274);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(43, 23);
            this.btnDeleteAll.TabIndex = 36;
            this.btnDeleteAll.Text = "<<";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(364, 245);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(43, 23);
            this.btnDeleteSelected.TabIndex = 35;
            this.btnDeleteSelected.Text = "<";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAll.Location = new System.Drawing.Point(364, 195);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(43, 23);
            this.btnAddAll.TabIndex = 34;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAddSelected
            // 
            this.btnAddSelected.Location = new System.Drawing.Point(364, 166);
            this.btnAddSelected.Name = "btnAddSelected";
            this.btnAddSelected.Size = new System.Drawing.Size(43, 23);
            this.btnAddSelected.TabIndex = 33;
            this.btnAddSelected.Text = ">";
            this.btnAddSelected.UseVisualStyleBackColor = true;
            this.btnAddSelected.Click += new System.EventHandler(this.btnAddSelected_Click);
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 16;
            this.listBoxSelected.Location = new System.Drawing.Point(451, 153);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(228, 164);
            this.listBoxSelected.TabIndex = 32;
            // 
            // listBoxAvailable
            // 
            this.listBoxAvailable.FormattingEnabled = true;
            this.listBoxAvailable.ItemHeight = 16;
            this.listBoxAvailable.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBoxAvailable.Location = new System.Drawing.Point(84, 153);
            this.listBoxAvailable.Name = "listBoxAvailable";
            this.listBoxAvailable.Size = new System.Drawing.Size(228, 164);
            this.listBoxAvailable.TabIndex = 31;
            // 
            // labelSelectedFields
            // 
            this.labelSelectedFields.AutoSize = true;
            this.labelSelectedFields.Location = new System.Drawing.Point(448, 108);
            this.labelSelectedFields.Name = "labelSelectedFields";
            this.labelSelectedFields.Size = new System.Drawing.Size(121, 17);
            this.labelSelectedFields.TabIndex = 30;
            this.labelSelectedFields.Text = "Выбранные поля";
            // 
            // labelAllFields
            // 
            this.labelAllFields.AutoSize = true;
            this.labelAllFields.Location = new System.Drawing.Point(81, 108);
            this.labelAllFields.Name = "labelAllFields";
            this.labelAllFields.Size = new System.Drawing.Size(118, 17);
            this.labelAllFields.TabIndex = 29;
            this.labelAllFields.Text = "Доступные поля";
            // 
            // labelTables
            // 
            this.labelTables.AutoSize = true;
            this.labelTables.Location = new System.Drawing.Point(81, 54);
            this.labelTables.Name = "labelTables";
            this.labelTables.Size = new System.Drawing.Size(77, 17);
            this.labelTables.TabIndex = 28;
            this.labelTables.Text = "Таблица : ";
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Items.AddRange(new object[] {
            "БД 1",
            "БД 2",
            "БД 3"});
            this.cmbTables.Location = new System.Drawing.Point(328, 47);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(351, 24);
            this.cmbTables.TabIndex = 27;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.dgvResult);
            this.tabPageResult.Location = new System.Drawing.Point(4, 25);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(1116, 555);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "Результат";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(1110, 549);
            this.dgvResult.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // listBoxJoins
            // 
            this.listBoxJoins.FormattingEnabled = true;
            this.listBoxJoins.ItemHeight = 16;
            this.listBoxJoins.Location = new System.Drawing.Point(729, 153);
            this.listBoxJoins.Name = "listBoxJoins";
            this.listBoxJoins.Size = new System.Drawing.Size(310, 164);
            this.listBoxJoins.TabIndex = 52;
            // 
            // labelForListBoxJoin
            // 
            this.labelForListBoxJoin.AutoSize = true;
            this.labelForListBoxJoin.Location = new System.Drawing.Point(726, 108);
            this.labelForListBoxJoin.Name = "labelForListBoxJoin";
            this.labelForListBoxJoin.Size = new System.Drawing.Size(47, 17);
            this.labelForListBoxJoin.TabIndex = 53;
            this.labelForListBoxJoin.Text = "Связи";
            // 
            // btnDeleteJoin
            // 
            this.btnDeleteJoin.AccessibleDescription = "";
            this.btnDeleteJoin.Location = new System.Drawing.Point(729, 326);
            this.btnDeleteJoin.Name = "btnDeleteJoin";
            this.btnDeleteJoin.Size = new System.Drawing.Size(310, 27);
            this.btnDeleteJoin.TabIndex = 54;
            this.btnDeleteJoin.Text = "Удалить выбранную связь";
            this.btnDeleteJoin.UseVisualStyleBackColor = true;
            this.btnDeleteJoin.Click += new System.EventHandler(this.btnDeleteJoin_Click);
            // 
            // btnClearJoin
            // 
            this.btnClearJoin.Location = new System.Drawing.Point(729, 355);
            this.btnClearJoin.Name = "btnClearJoin";
            this.btnClearJoin.Size = new System.Drawing.Size(310, 27);
            this.btnClearJoin.TabIndex = 55;
            this.btnClearJoin.Text = "Очистить связи";
            this.btnClearJoin.UseVisualStyleBackColor = true;
            this.btnClearJoin.Click += new System.EventHandler(this.btnClearJoin_Click);
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 584);
            this.Controls.Add(this.tabControlQuery);
            this.Name = "QueriesForm";
            this.Text = "Queries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlQuery.ResumeLayout(false);
            this.tabPageQuery.ResumeLayout(false);
            this.tabPageQuery.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQuery;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.Button btnAddJoin;
        private System.Windows.Forms.ComboBox cmbJoins3;
        private System.Windows.Forms.TextBox txbValues3;
        private System.Windows.Forms.ComboBox cmbOperations3;
        private System.Windows.Forms.ComboBox cmbJoins2;
        private System.Windows.Forms.TextBox txbValues2;
        private System.Windows.Forms.ComboBox cmbOperations2;
        private System.Windows.Forms.ComboBox cmbJoins1;
        private System.Windows.Forms.TextBox txbValues1;
        private System.Windows.Forms.ComboBox cmbOperations1;
        private System.Windows.Forms.ComboBox cmbItems1;
        private System.Windows.Forms.Button CreateQuery;
        private System.Windows.Forms.Label labelJoins;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAddSelected;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.ListBox listBoxAvailable;
        private System.Windows.Forms.Label labelSelectedFields;
        private System.Windows.Forms.Label labelAllFields;
        private System.Windows.Forms.Label labelTables;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.ComboBox cmbItems3;
        private System.Windows.Forms.ComboBox cmbItems2;
        private System.Windows.Forms.Button btnClearJoin;
        private System.Windows.Forms.Button btnDeleteJoin;
        private System.Windows.Forms.Label labelForListBoxJoin;
        private System.Windows.Forms.ListBox listBoxJoins;
    }
}
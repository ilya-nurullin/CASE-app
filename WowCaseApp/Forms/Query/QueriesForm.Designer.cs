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
            this.btnAddNewJoin = new System.Windows.Forms.Button();
            this.labelJoins = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.JoinGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateQuery = new System.Windows.Forms.Button();
            this.JoinGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Items.AddRange(new object[] {
            "БД 1",
            "БД 2",
            "БД 3"});
            this.cmbTables.Location = new System.Drawing.Point(301, 29);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(351, 24);
            this.cmbTables.TabIndex = 0;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
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
            "4",
            "5",
            "6"});
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
            // btnAddNewJoin
            // 
            this.btnAddNewJoin.Location = new System.Drawing.Point(337, 328);
            this.btnAddNewJoin.Name = "btnAddNewJoin";
            this.btnAddNewJoin.Size = new System.Drawing.Size(43, 23);
            this.btnAddNewJoin.TabIndex = 10;
            this.btnAddNewJoin.Text = "+";
            this.btnAddNewJoin.UseVisualStyleBackColor = true;
            this.btnAddNewJoin.Click += new System.EventHandler(this.btnAddNewJoin_Click);
            // 
            // labelJoins
            // 
            this.labelJoins.AutoSize = true;
            this.labelJoins.Location = new System.Drawing.Point(309, 308);
            this.labelJoins.Name = "labelJoins";
            this.labelJoins.Size = new System.Drawing.Size(112, 17);
            this.labelJoins.TabIndex = 11;
            this.labelJoins.Text = "Добавить связь";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // JoinGroupBox
            // 
            this.JoinGroupBox.Controls.Add(this.comboBox4);
            this.JoinGroupBox.Controls.Add(this.comboBox3);
            this.JoinGroupBox.Controls.Add(this.comboBox2);
            this.JoinGroupBox.Controls.Add(this.comboBox1);
            this.JoinGroupBox.Location = new System.Drawing.Point(57, 337);
            this.JoinGroupBox.Name = "JoinGroupBox";
            this.JoinGroupBox.Size = new System.Drawing.Size(595, 141);
            this.JoinGroupBox.TabIndex = 12;
            this.JoinGroupBox.TabStop = false;
            this.JoinGroupBox.Text = "Добавление группировки";
            this.JoinGroupBox.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "4"});
            this.comboBox4.Location = new System.Drawing.Point(367, 88);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(222, 24);
            this.comboBox4.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2"});
            this.comboBox3.Location = new System.Drawing.Point(6, 88);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(222, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "3"});
            this.comboBox2.Location = new System.Drawing.Point(367, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1"});
            this.comboBox1.Location = new System.Drawing.Point(6, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 4;
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
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 584);
            this.Controls.Add(this.CreateQuery);
            this.Controls.Add(this.JoinGroupBox);
            this.Controls.Add(this.labelJoins);
            this.Controls.Add(this.btnAddNewJoin);
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
            this.JoinGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAddNewJoin;
        private System.Windows.Forms.Label labelJoins;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.GroupBox JoinGroupBox;
        private System.Windows.Forms.Button CreateQuery;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
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
            this.btnAddNewJoin.Location = new System.Drawing.Point(337, 329);
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
            this.labelJoins.Location = new System.Drawing.Point(309, 309);
            this.labelJoins.Name = "labelJoins";
            this.labelJoins.Size = new System.Drawing.Size(112, 17);
            this.labelJoins.TabIndex = 11;
            this.labelJoins.Text = "Добавить связь";
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 510);
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
    }
}
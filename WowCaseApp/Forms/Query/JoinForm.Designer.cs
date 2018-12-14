namespace WowCaseApp.Forms.Query
{
    partial class JoinForm
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
            this.cmbT1 = new System.Windows.Forms.ComboBox();
            this.cmbT2 = new System.Windows.Forms.ComboBox();
            this.cmbA1 = new System.Windows.Forms.ComboBox();
            this.cmbA2 = new System.Windows.Forms.ComboBox();
            this.labelFromTable = new System.Windows.Forms.Label();
            this.labelToTable = new System.Windows.Forms.Label();
            this.labelFromAtrr = new System.Windows.Forms.Label();
            this.labelToAttr = new System.Windows.Forms.Label();
            this.cmbJoinTypes = new System.Windows.Forms.ComboBox();
            this.CreateJoin = new System.Windows.Forms.Button();
            this.labelJoinType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbT1
            // 
            this.cmbT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbT1.FormattingEnabled = true;
            this.cmbT1.Location = new System.Drawing.Point(29, 52);
            this.cmbT1.Name = "cmbT1";
            this.cmbT1.Size = new System.Drawing.Size(184, 24);
            this.cmbT1.TabIndex = 0;
            // 
            // cmbT2
            // 
            this.cmbT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbT2.FormattingEnabled = true;
            this.cmbT2.Location = new System.Drawing.Point(270, 52);
            this.cmbT2.Name = "cmbT2";
            this.cmbT2.Size = new System.Drawing.Size(184, 24);
            this.cmbT2.TabIndex = 1;
            // 
            // cmbA1
            // 
            this.cmbA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA1.FormattingEnabled = true;
            this.cmbA1.Location = new System.Drawing.Point(29, 118);
            this.cmbA1.Name = "cmbA1";
            this.cmbA1.Size = new System.Drawing.Size(184, 24);
            this.cmbA1.TabIndex = 2;
            // 
            // cmbA2
            // 
            this.cmbA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA2.FormattingEnabled = true;
            this.cmbA2.Location = new System.Drawing.Point(270, 118);
            this.cmbA2.Name = "cmbA2";
            this.cmbA2.Size = new System.Drawing.Size(184, 24);
            this.cmbA2.TabIndex = 3;
            // 
            // labelFromTable
            // 
            this.labelFromTable.AutoSize = true;
            this.labelFromTable.Location = new System.Drawing.Point(26, 32);
            this.labelFromTable.Name = "labelFromTable";
            this.labelFromTable.Size = new System.Drawing.Size(77, 17);
            this.labelFromTable.TabIndex = 4;
            this.labelFromTable.Text = "Таблица 1";
            // 
            // labelToTable
            // 
            this.labelToTable.AutoSize = true;
            this.labelToTable.Location = new System.Drawing.Point(267, 32);
            this.labelToTable.Name = "labelToTable";
            this.labelToTable.Size = new System.Drawing.Size(77, 17);
            this.labelToTable.TabIndex = 5;
            this.labelToTable.Text = "Таблица 2";
            // 
            // labelFromAtrr
            // 
            this.labelFromAtrr.AutoSize = true;
            this.labelFromAtrr.Location = new System.Drawing.Point(26, 98);
            this.labelFromAtrr.Name = "labelFromAtrr";
            this.labelFromAtrr.Size = new System.Drawing.Size(54, 17);
            this.labelFromAtrr.TabIndex = 6;
            this.labelFromAtrr.Text = "Поле 1";
            // 
            // labelToAttr
            // 
            this.labelToAttr.AutoSize = true;
            this.labelToAttr.Location = new System.Drawing.Point(267, 98);
            this.labelToAttr.Name = "labelToAttr";
            this.labelToAttr.Size = new System.Drawing.Size(54, 17);
            this.labelToAttr.TabIndex = 7;
            this.labelToAttr.Text = "Поле 2";
            // 
            // cmbJoinTypes
            // 
            this.cmbJoinTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoinTypes.FormattingEnabled = true;
            this.cmbJoinTypes.Items.AddRange(new object[] {
            "INNER JOIN",
            "LEFT JOIN",
            "RIGHT JOIN",
            "FULL OUTER JOIN"});
            this.cmbJoinTypes.Location = new System.Drawing.Point(120, 175);
            this.cmbJoinTypes.Name = "cmbJoinTypes";
            this.cmbJoinTypes.Size = new System.Drawing.Size(334, 24);
            this.cmbJoinTypes.TabIndex = 8;
            // 
            // CreateJoin
            // 
            this.CreateJoin.Location = new System.Drawing.Point(164, 216);
            this.CreateJoin.Name = "CreateJoin";
            this.CreateJoin.Size = new System.Drawing.Size(147, 23);
            this.CreateJoin.TabIndex = 9;
            this.CreateJoin.Text = "Добавить связь";
            this.CreateJoin.UseVisualStyleBackColor = true;
            this.CreateJoin.Click += new System.EventHandler(this.CreateJoin_Click);
            // 
            // labelJoinType
            // 
            this.labelJoinType.AutoSize = true;
            this.labelJoinType.Location = new System.Drawing.Point(26, 175);
            this.labelJoinType.Name = "labelJoinType";
            this.labelJoinType.Size = new System.Drawing.Size(63, 17);
            this.labelJoinType.TabIndex = 10;
            this.labelJoinType.Text = "Вид Join";
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 251);
            this.Controls.Add(this.labelJoinType);
            this.Controls.Add(this.CreateJoin);
            this.Controls.Add(this.cmbJoinTypes);
            this.Controls.Add(this.labelToAttr);
            this.Controls.Add(this.labelFromAtrr);
            this.Controls.Add(this.labelToTable);
            this.Controls.Add(this.labelFromTable);
            this.Controls.Add(this.cmbA2);
            this.Controls.Add(this.cmbA1);
            this.Controls.Add(this.cmbT2);
            this.Controls.Add(this.cmbT1);
            this.Name = "JoinForm";
            this.Text = "JoinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbT1;
        private System.Windows.Forms.ComboBox cmbT2;
        private System.Windows.Forms.ComboBox cmbA1;
        private System.Windows.Forms.ComboBox cmbA2;
        private System.Windows.Forms.Label labelFromTable;
        private System.Windows.Forms.Label labelToTable;
        private System.Windows.Forms.Label labelFromAtrr;
        private System.Windows.Forms.Label labelToAttr;
        private System.Windows.Forms.ComboBox cmbJoinTypes;
        private System.Windows.Forms.Button CreateJoin;
        private System.Windows.Forms.Label labelJoinType;
    }
}
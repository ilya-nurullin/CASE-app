namespace WowCaseApp
{
    partial class NewTableForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttrType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsPK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsIndexed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.AttrType,
            this.IsPK,
            this.IsNullable,
            this.IsIndexed});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 577);
            this.dataGridView1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Frozen = true;
            this.Title.HeaderText = "Название столбца";
            this.Title.Name = "Title";
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Title.Width = 200;
            // 
            // AttrType
            // 
            this.AttrType.Frozen = true;
            this.AttrType.HeaderText = "Тип";
            this.AttrType.Items.AddRange(new object[] {
            "Строка",
            "Текст",
            "Целое число со знаком",
            "Целое число без знака",
            "Дробное число",
            "Дата",
            "Дата и время",
            "Да/нет"});
            this.AttrType.Name = "AttrType";
            this.AttrType.Width = 200;
            // 
            // IsPK
            // 
            this.IsPK.HeaderText = "Является ПК?";
            this.IsPK.Name = "IsPK";
            this.IsPK.Width = 120;
            // 
            // IsNullable
            // 
            this.IsNullable.HeaderText = "Может быть пустым?";
            this.IsNullable.Name = "IsNullable";
            this.IsNullable.Width = 170;
            // 
            // IsIndexed
            // 
            this.IsIndexed.HeaderText = "Индексируется?";
            this.IsIndexed.Name = "IsIndexed";
            this.IsIndexed.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьСсылкуНаДругуюТаблицыToolStripMenuItem
            // 
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem.Name = "добавитьСсылкуНаДругуюТаблицыToolStripMenuItem";
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem.Text = "Добавить ссылку на другую таблицу";
            // 
            // NewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание новой таблицы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn AttrType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNullable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsIndexed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСсылкуНаДругуюТаблицыToolStripMenuItem;
    }
}
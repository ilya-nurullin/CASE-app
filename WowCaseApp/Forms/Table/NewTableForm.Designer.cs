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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttrType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsPK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsIndexed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.AttrType,
            this.IsPK,
            this.IsNullable,
            this.IsIndexed,
            this.DefaultValue});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 28);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1128, 577);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // добавитьСсылкуНаДругуюТаблицыToolStripMenuItem
            // 
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem.Name = "добавитьСсылкуНаДругуюТаблицыToolStripMenuItem";
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.добавитьСсылкуНаДругуюТаблицыToolStripMenuItem.Text = "Добавить ссылку на другую таблицу";
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
            this.AttrType.Width = 150;
            // 
            // IsPK
            // 
            this.IsPK.HeaderText = "Является ПК?";
            this.IsPK.Name = "IsPK";
            this.IsPK.Width = 110;
            // 
            // IsNullable
            // 
            this.IsNullable.HeaderText = "Может быть пустым?";
            this.IsNullable.Name = "IsNullable";
            this.IsNullable.Width = 160;
            // 
            // IsIndexed
            // 
            this.IsIndexed.HeaderText = "Индексируется?";
            this.IsIndexed.Name = "IsIndexed";
            this.IsIndexed.Width = 130;
            // 
            // DefaultValue
            // 
            this.DefaultValue.HeaderText = "По умолчанию";
            this.DefaultValue.Name = "DefaultValue";
            this.DefaultValue.Width = 150;
            // 
            // NewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 605);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание новой таблицы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСсылкуНаДругуюТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn AttrType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNullable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsIndexed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
    }
}
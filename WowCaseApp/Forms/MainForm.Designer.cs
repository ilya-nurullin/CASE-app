namespace WowCaseApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Таблицы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Формы");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Запросы");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Отчеты");
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовуюТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовыйЗапросToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.tablesContextMenu.SuspendLayout();
            this.queriesMenuStrip.SuspendLayout();
            this.viewsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTreeView.Location = new System.Drawing.Point(0, 28);
            this.MainTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTreeView.Name = "MainTreeView";
            treeNode5.Name = "Tables";
            treeNode5.Tag = "Tables";
            treeNode5.Text = "Таблицы";
            treeNode6.Name = "Forms";
            treeNode6.Tag = "Views";
            treeNode6.Text = "Формы";
            treeNode7.Name = "Queries";
            treeNode7.Tag = "Queries";
            treeNode7.Text = "Запросы";
            treeNode8.Name = "Reports";
            treeNode8.Tag = "Reports";
            treeNode8.Text = "Отчеты";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.MainTreeView.Size = new System.Drawing.Size(145, 707);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainTreeView_MouseUp);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(1377, 28);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьНовыйToolStripMenuItem
            // 
            this.создатьНовыйToolStripMenuItem.Name = "создатьНовыйToolStripMenuItem";
            this.создатьНовыйToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.создатьНовыйToolStripMenuItem.Text = "Создать новый";
            this.создатьНовыйToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйToolStripMenuItem_Click);
            // 
            // tablesContextMenu
            // 
            this.tablesContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tablesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюТаблицуToolStripMenuItem});
            this.tablesContextMenu.Name = "tablesContextMenu";
            this.tablesContextMenu.Size = new System.Drawing.Size(243, 28);
            // 
            // создатьНовуюТаблицуToolStripMenuItem
            // 
            this.создатьНовуюТаблицуToolStripMenuItem.Name = "создатьНовуюТаблицуToolStripMenuItem";
            this.создатьНовуюТаблицуToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.создатьНовуюТаблицуToolStripMenuItem.Text = "Создать новую таблицу";
            this.создатьНовуюТаблицуToolStripMenuItem.Click += new System.EventHandler(this.создатьНовуюТаблицуToolStripMenuItem_Click);
            // 
            // queriesMenuStrip
            // 
            this.queriesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.queriesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйЗапросToolStripMenuItem1});
            this.queriesMenuStrip.Name = "queriesMenuStrip";
            this.queriesMenuStrip.Size = new System.Drawing.Size(237, 28);
            // 
            // создатьНовыйЗапросToolStripMenuItem1
            // 
            this.создатьНовыйЗапросToolStripMenuItem1.Name = "создатьНовыйЗапросToolStripMenuItem1";
            this.создатьНовыйЗапросToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.создатьНовыйЗапросToolStripMenuItem1.Text = "Создать новый запрос";
            this.создатьНовыйЗапросToolStripMenuItem1.Click += new System.EventHandler(this.создатьНовыйЗапросToolStripMenuItem1_Click);
            // 
            // viewsMenuStrip
            // 
            this.viewsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.viewsMenuStrip.Name = "queriesMenuStrip";
            this.viewsMenuStrip.Size = new System.Drawing.Size(233, 28);
            this.viewsMenuStrip.Tag = "Views";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 24);
            this.toolStripMenuItem1.Text = "Создать новую форму";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 735);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wow Case App";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tablesContextMenu.ResumeLayout(false);
            this.queriesMenuStrip.ResumeLayout(false);
            this.viewsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip tablesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem создатьНовуюТаблицуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip queriesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйЗапросToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip viewsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


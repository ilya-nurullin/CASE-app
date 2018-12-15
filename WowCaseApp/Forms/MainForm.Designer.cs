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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Таблицы");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Формы");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Запросы");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Отчеты");
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовуюТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовыйЗапросToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовуюФормуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.childNodesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuStrip.SuspendLayout();
            this.tablesContextMenu.SuspendLayout();
            this.queriesMenuStrip.SuspendLayout();
            this.viewsMenuStrip.SuspendLayout();
            this.childNodesMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTreeView.Location = new System.Drawing.Point(0, 24);
            this.MainTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainTreeView.Name = "MainTreeView";
            treeNode17.Name = "Tables";
            treeNode17.Tag = "Tables";
            treeNode17.Text = "Таблицы";
            treeNode18.Name = "Forms";
            treeNode18.Tag = "Views";
            treeNode18.Text = "Формы";
            treeNode19.Name = "Queries";
            treeNode19.Tag = "Queries";
            treeNode19.Text = "Запросы";
            treeNode20.Name = "Reports";
            treeNode20.Tag = "Reports";
            treeNode20.Text = "Отчеты";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.MainTreeView.Size = new System.Drawing.Size(110, 573);
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
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(1033, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьНовыйToolStripMenuItem
            // 
            this.создатьНовыйToolStripMenuItem.Name = "создатьНовыйToolStripMenuItem";
            this.создатьНовыйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.создатьНовыйToolStripMenuItem.Text = "Создать новый";
            this.создатьНовыйToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйToolStripMenuItem_Click);
            // 
            // tablesContextMenu
            // 
            this.tablesContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tablesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюТаблицуToolStripMenuItem});
            this.tablesContextMenu.Name = "tablesContextMenu";
            this.tablesContextMenu.Size = new System.Drawing.Size(205, 26);
            // 
            // создатьНовуюТаблицуToolStripMenuItem
            // 
            this.создатьНовуюТаблицуToolStripMenuItem.Name = "создатьНовуюТаблицуToolStripMenuItem";
            this.создатьНовуюТаблицуToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.создатьНовуюТаблицуToolStripMenuItem.Text = "Создать новую таблицу";
            this.создатьНовуюТаблицуToolStripMenuItem.Click += new System.EventHandler(this.создатьНовуюТаблицуToolStripMenuItem_Click);
            // 
            // queriesMenuStrip
            // 
            this.queriesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.queriesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйЗапросToolStripMenuItem1});
            this.queriesMenuStrip.Name = "queriesMenuStrip";
            this.queriesMenuStrip.Size = new System.Drawing.Size(198, 26);
            // 
            // создатьНовыйЗапросToolStripMenuItem1
            // 
            this.создатьНовыйЗапросToolStripMenuItem1.Name = "создатьНовыйЗапросToolStripMenuItem1";
            this.создатьНовыйЗапросToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.создатьНовыйЗапросToolStripMenuItem1.Text = "Создать новый запрос";
            this.создатьНовыйЗапросToolStripMenuItem1.Click += new System.EventHandler(this.создатьНовыйЗапросToolStripMenuItem1_Click);
            // 
            // viewsMenuStrip
            // 
            this.viewsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюФормуToolStripMenuItem1});
            this.viewsMenuStrip.Name = "queriesMenuStrip";
            this.viewsMenuStrip.Size = new System.Drawing.Size(198, 26);
            this.viewsMenuStrip.Tag = "Views";
            // 
            // создатьНовуюФормуToolStripMenuItem1
            // 
            this.создатьНовуюФормуToolStripMenuItem1.Name = "создатьНовуюФормуToolStripMenuItem1";
            this.создатьНовуюФормуToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.создатьНовуюФормуToolStripMenuItem1.Text = "Создать новую форму";
            this.создатьНовуюФормуToolStripMenuItem1.Click += new System.EventHandler(this.создатьНовуюФормуToolStripMenuItem1_Click);
            // 
            // childNodesMenuStrip
            // 
            this.childNodesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.toolStripSeparator1,
            this.удалитьToolStripMenuItem});
            this.childNodesMenuStrip.Name = "childNodesMenuStrip";
            this.childNodesMenuStrip.Size = new System.Drawing.Size(162, 76);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 597);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wow Case App";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tablesContextMenu.ResumeLayout(false);
            this.queriesMenuStrip.ResumeLayout(false);
            this.viewsMenuStrip.ResumeLayout(false);
            this.childNodesMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem создатьНовуюФормуToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip childNodesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


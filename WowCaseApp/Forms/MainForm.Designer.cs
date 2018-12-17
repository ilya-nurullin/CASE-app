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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Таблицы");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Формы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Запросы");
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.tablesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовуюТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовыйЗапросToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовуюФормуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.childNodesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesContextMenu.SuspendLayout();
            this.queriesMenuStrip.SuspendLayout();
            this.viewsMenuStrip.SuspendLayout();
            this.childNodesMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTreeView.Name = "MainTreeView";
            treeNode1.Name = "Tables";
            treeNode1.Tag = "Tables";
            treeNode1.Text = "Таблицы";
            treeNode2.Name = "Forms";
            treeNode2.Tag = "Views";
            treeNode2.Text = "Формы";
            treeNode3.Name = "Queries";
            treeNode3.Tag = "Queries";
            treeNode3.Text = "Запросы";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.MainTreeView.Size = new System.Drawing.Size(110, 735);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainTreeView_MouseUp);
            // 
            // tablesContextMenu
            // 
            this.tablesContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tablesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюТаблицуToolStripMenuItem,
            this.добавитьЗначенияToolStripMenuItem});
            this.tablesContextMenu.Name = "tablesContextMenu";
            this.tablesContextMenu.Size = new System.Drawing.Size(205, 70);
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
            this.childNodesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.childNodesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.toolStripSeparator1,
            this.удалитьToolStripMenuItem});
            this.childNodesMenuStrip.Name = "childNodesMenuStrip";
            this.childNodesMenuStrip.Size = new System.Drawing.Size(191, 82);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // добавитьЗначенияToolStripMenuItem
            // 
            this.добавитьЗначенияToolStripMenuItem.Name = "добавитьЗначенияToolStripMenuItem";
            this.добавитьЗначенияToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавитьЗначенияToolStripMenuItem.Text = "Добавить значения";
            this.добавитьЗначенияToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗначенияToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 597);
            this.Controls.Add(this.MainTreeView);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wow Case App";
            this.tablesContextMenu.ResumeLayout(false);
            this.queriesMenuStrip.ResumeLayout(false);
            this.viewsMenuStrip.ResumeLayout(false);
            this.childNodesMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView MainTreeView;
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
        private System.Windows.Forms.ToolStripMenuItem добавитьЗначенияToolStripMenuItem;
    }
}


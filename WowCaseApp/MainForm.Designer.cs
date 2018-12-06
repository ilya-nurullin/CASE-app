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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Отчеты");
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.tablesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьНовуюТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainMenuStrip.SuspendLayout();
            this.tablesContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTreeView.Location = new System.Drawing.Point(0, 28);
            this.MainTreeView.Name = "MainTreeView";
            treeNode1.Name = "Tables";
            treeNode1.Tag = "Tables";
            treeNode1.Text = "Таблицы";
            treeNode2.Name = "Forms";
            treeNode2.Text = "Формы";
            treeNode3.Name = "Queries";
            treeNode3.Tag = "Queries";
            treeNode3.Text = "Запросы";
            treeNode4.Name = "Reports";
            treeNode4.Text = "Отчеты";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.MainTreeView.Size = new System.Drawing.Size(146, 626);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.MainTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainTreeView_MouseUp);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1196, 28);
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
            this.tablesContextMenu.Size = new System.Drawing.Size(243, 52);
            // 
            // создатьНовуюТаблицуToolStripMenuItem
            // 
            this.создатьНовуюТаблицуToolStripMenuItem.Name = "создатьНовуюТаблицуToolStripMenuItem";
            this.создатьНовуюТаблицуToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.создатьНовуюТаблицуToolStripMenuItem.Text = "Создать новую таблицу";
            this.создатьНовуюТаблицуToolStripMenuItem.Click += new System.EventHandler(this.создатьНовуюТаблицуToolStripMenuItem_Click);
            // 
            // создатьНовыйЗапросToolStripMenuItem
            // 
            this.создатьНовыйЗапросToolStripMenuItem.Name = "создатьНовыйЗапросToolStripMenuItem";
            this.создатьНовыйЗапросToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.создатьНовыйЗапросToolStripMenuItem.Text = "Создать новый запрос";
            this.создатьНовыйЗапросToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйЗапросToolStripMenuItem_Click);
            // 
            // queriesContextMenu
            // 
            this.queriesContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.queriesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйЗапросToolStripMenuItem});
            this.queriesContextMenu.Name = "queriesContextMenu";
            this.queriesContextMenu.Size = new System.Drawing.Size(211, 32);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 654);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Wow Case App";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tablesContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйToolStripMenuItem;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.ContextMenuStrip tablesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem создатьНовуюТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйЗапросToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip queriesContextMenu;
    }
}


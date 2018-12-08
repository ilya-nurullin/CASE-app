using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WowCaseApp.Forms.View;

namespace WowCaseApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            создатьНовуюТаблицуToolStripMenuItem_Click(null, null); // todo: remove
        }

        private void создатьНовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text.ToLower())
            {
                case "таблицы": { break; }
                case "формы": { break; }
                case "запросы": { break; }
                case "отчеты": { break; }


            }
        }

        private TreeNode m_OldSelectNode;

        private void MainTreeView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                // Point where the mouse is clicked.
                Point p = new Point(e.X, e.Y);

                // Get the node that the user has clicked.
                TreeNode node = MainTreeView.GetNodeAt(p);
                if (node != null)
                {

                    // Select the node the user has clicked.
                    // The node appears selected until the menu is displayed on the screen.
                    m_OldSelectNode = MainTreeView.SelectedNode;
                    MainTreeView.SelectedNode = node;

                    // Find the appropriate ContextMenu depending on the selected node.
                    switch (Convert.ToString(node.Tag))
                    {
                        case "Tables":
                            tablesContextMenu.Show(MainTreeView, p);
                            break;

                        case "Queries":
                            tablesContextMenu.Show(MainTreeView, p);
                            break;

                        case "Views":
                            tablesContextMenu.Show(MainTreeView, p);
                            break;

                        case "Reports":
                            tablesContextMenu.Show(MainTreeView, p);
                            break;
                    }
                }
            }
        }

        private void создатьНовуюТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTableForm form = new NewTableForm();
            form.MdiParent = this;
            form.Show();
        }
        private void создатьНовыйЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueriesForm childForm = new QueriesForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void создатьНовуюФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm childForm = new ViewForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void создатьНовыйОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

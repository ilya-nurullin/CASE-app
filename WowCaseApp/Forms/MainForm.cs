using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
using WowCaseApp.Forms.View;
using WowCaseApp.Model;

namespace WowCaseApp
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MainForm));
        private static readonly MetaDataDBContainer metaDbContainer = new MetaDataDBContainer();
        private static readonly SqlConnection dbConnection = new SqlConnection(Env.GetString("DBConnectionString"));

        public MainForm()
        {
            InitializeComponent();
            dbConnection.Open();
            log.Debug("App started");
            log.Debug("Total tables in MetaDB: " + metaDbContainer.TableSet.Count());
            log.Debug("Working DB name is " + dbConnection.Database);
        }

        private void создатьНовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
                            { 
                            tablesContextMenu.Show(MainTreeView, p);
                            break;
                            }

                        case "Queries": { queriesMenuStrip.Show(MainTreeView, p); break; }
                        case "Views": { viewsMenuStrip.Show(MainTreeView, p); break; }

                    }
                }
            }
        }

        private void создатьНовуюТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTableForm form = new NewTableForm(metaDbContainer, dbConnection);
            form.MdiParent = this;
            form.Show();
        }
         
      

        private void создатьНовыйЗапросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QueriesForm childForm = new QueriesForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewForm childForm = new ViewForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}

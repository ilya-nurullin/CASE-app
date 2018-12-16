using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
using WowCaseApp.Forms;
using WowCaseApp.Forms.View;
using WowCaseApp.Model;
using View = WowCaseApp.Model.View;

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

            LoadTreeView();
        }
        ~MainForm()
        {
            dbConnection.Close();
            log.Debug("App stopped");
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
                    string tag = Convert.ToString(node.Tag);
                    switch (tag)
                    {
                        case "Tables":{tablesContextMenu.Show(MainTreeView, p);break;}
                        case "Queries": { queriesMenuStrip.Show(MainTreeView, p); break; }
                        case "Views": { viewsMenuStrip.Show(MainTreeView, p); break; }
                        default:
                        {
                            childNodesMenuStrip.Tag = node.Tag;
                            childNodesMenuStrip.Show(MainTreeView, p);break;
                        }
                    }
                }
            }
        }

        public void LoadTreeView()
        {
            var nodes = MainTreeView.Nodes; 
            foreach (TreeNode node in nodes)
            {
                node.Nodes.Clear();
                switch (node.Tag)
                {
                    case "Tables":
                    {
                        foreach (var t in metaDbContainer.TableSet)
                        {
                            TreeNode tn = new TreeNode(t.Name);
                            tn.Tag = $"[tabl]{t.RealName}";
                            node.Nodes.Add(tn);
                        }
                        break;
                    }
                    case "Queries":
                    {
                        foreach (var q in metaDbContainer.QuerySet)
                        {
                            TreeNode tn = new TreeNode(q.Name);
                            tn.Tag = $"[quer]{q.Name}";
                            node.Nodes.Add(tn);
                        }
                        break;
                    }
                    case "Views":
                    {
                        foreach (var v in metaDbContainer.ViewSet)
                        {
                            TreeNode tn = new TreeNode(v.Name);
                            tn.Tag = $"[view]{v.Name}";
                            node.Nodes.Add(tn);
                        }
                        break;
                    }
                    case "Reports":
                    {
                        foreach (var r in metaDbContainer.ReportSet)
                        {
                            TreeNode tn = new TreeNode(r.Name);
                            tn.Tag = $"[repo]{r.Name}";
                            node.Nodes.Add(tn);
                        }
                        break;
                    }
                }
            }
            MainTreeView.ExpandAll();
        }

        private void создатьНовуюТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTableForm form = new NewTableForm(metaDbContainer, dbConnection);
            form.MdiParent = this;
            form.Show();
        }
        private void создатьНовыйЗапросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QueriesForm childForm = new QueriesForm(metaDbContainer, dbConnection);
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void создатьНовуюФормуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetStringForm gsf = new GetStringForm("Создание формы","Введите название формы");
            if (gsf.ShowDialog() != DialogResult.OK)
                return;

            if (metaDbContainer.ViewSet.Any(x => x.Name == gsf.Value))
            {
                MessageBox.Show("ФОрма с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                создатьНовуюФормуToolStripMenuItem1_Click(null, null);
                return;
            }

            ViewForm childForm = new ViewForm(metaDbContainer,dbConnection, gsf.Value);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip tsmi = ((ToolStripMenuItem)sender).GetCurrentParent();

            switch (tsmi.Tag.ToString().Substring(0, 6))
            {
                case "[tabl]":
                {
                    OpenTable(tsmi.Tag.ToString().Substring(6)); 
                    break;
                }
                case "[quer]":
                {
                    OpenQuery(tsmi.Tag.ToString().Substring(6));
                    break;
                }
                case "[view]":
                {
                    OpenView(tsmi.Tag.ToString().Substring(6));
                    break;
                }
                case "[repo]":
                {
                    OpenReport(tsmi.Tag.ToString().Substring(6));
                    break;
                }
            }
        }
        private void OpenTable(string name)
        {
            var form = new TableInfoForm(name, metaDbContainer, dbConnection);
            form.MdiParent = this;
            form.Show();
        }
        private void OpenQuery(string name)
        {
            //TODO
        }
        private void OpenView(string name)
        {
            View v = metaDbContainer.ViewSet.First(x=>x.Name == name);
            ViewForm vf = new ViewForm(metaDbContainer,dbConnection, v);
            vf.MdiParent = this;
            vf.Show();
        }
        private void OpenReport(string name)
        {
            //TODO
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip tsmi = ((ToolStripMenuItem)sender).GetCurrentParent();

            switch (tsmi.Tag.ToString().Substring(0, 6))
            {
                case "[tabl]":
                {
                    DeleteTable(tsmi.Tag.ToString().Substring(6));
                    break;
                }
                case "[quer]":
                {
                    DeleteQuery(tsmi.Tag.ToString().Substring(6));
                    break;
                }
                case "[view]":
                {
                    DeleteView(tsmi.Tag.ToString().Substring(6));
                    break;
                }
                case "[repo]":
                {
                    DeleteReport(tsmi.Tag.ToString().Substring(6));
                    break;
                }
            }
        }
        private void DeleteTable(string name)
        {
            if (MessageBox.Show("Удалить таблицу?", "Удаление таблицы", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlExecutor.ExecuteNonQuery(dbConnection, $"DROP TABLE {name}");
                Table.Remove(metaDbContainer, name);

                var parentNode = MainTreeView.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals("Tables"));
                parentNode.Nodes.Remove(parentNode.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals($"[tabl]{name}")));
            }
            catch (SqlException e)
            {
                if (e.Message.Contains("because it is referenced by a FOREIGN KEY constraint"))
                {
                    MessageBox.Show("Не могу удалить таблицу, т.к. от неё зависят другие таблицы");
                }
                else
                    throw e;
            }

        }
        private void DeleteQuery(string name)
        {
            if (MessageBox.Show("Удалить запрос?", "Удаление запроса",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Query.Remove(metaDbContainer, name);

            var parentNode = MainTreeView.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals("Queries"));
            parentNode.Nodes.Remove(parentNode.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals($"[quer]{name}")));
        }
        private void DeleteView(string name)
        {
            if (MessageBox.Show("Удалить форму?", "Удаление формы",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            View.Remove(metaDbContainer, name);

            var parentNode = MainTreeView.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals("Views"));
            parentNode.Nodes.Remove(parentNode.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals($"[view]{name}")));
        }
        private void DeleteReport(string name)
        {
            if (MessageBox.Show("Удалить отчёт?", "Удаление отчёта",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Report.Remove(metaDbContainer, name);

            var parentNode = MainTreeView.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals("Reports"));
            parentNode.Nodes.Remove(parentNode.Nodes.Cast<TreeNode>().First(x => x.Tag.Equals($"[repo]{name}")));
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip ts = ((ToolStripMenuItem)sender).GetCurrentParent();

            string name = ts.Tag.ToString().Substring(6);
            TreeNode node = MainTreeView.Nodes.Cast<TreeNode>()
                .SelectMany(x => x.Nodes.Cast<TreeNode>())
                .First(t => t.Tag.Equals($"{ts.Tag}"));

            GetStringForm gst = new GetStringForm("Введите новое имя", "Переименование");
            gst.SetValue(node.Text);

            if (gst.ShowDialog() == DialogResult.Cancel || gst.Value == node.Text)
                return;

            string newName = gst.Value;
            switch (ts.Tag.ToString().Substring(0, 6))
            {
                case "[tabl]":
                {
                    if (metaDbContainer.TableSet.Any(x => x.Name == newName))
                    {
                        MessageBox.Show("Таблица с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        переименоватьToolStripMenuItem_Click(sender, null);
                    }

                    var t = metaDbContainer.TableSet.First(x => x.RealName == name);
                    t.Name = newName;
                    metaDbContainer.Entry(t).State = EntityState.Modified;
                    metaDbContainer.SaveChanges();
                    break;
                }
                case "[quer]":
                {
                    if (metaDbContainer.QuerySet.Any(x => x.Name == newName))
                    {
                        MessageBox.Show("Запрос с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        переименоватьToolStripMenuItem_Click(sender, null);
                    }

                    var q = metaDbContainer.QuerySet.First(x => x.Name == name);
                    q.Name = newName;
                    metaDbContainer.Entry(q).State = EntityState.Modified;
                    metaDbContainer.SaveChanges();
                    break;
                }
                case "[view]":
                {
                    if (metaDbContainer.ViewSet.Any(x => x.Name == newName))
                    {
                        MessageBox.Show("Форма с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        переименоватьToolStripMenuItem_Click(sender, null);
                    }

                    var v = metaDbContainer.ViewSet.First(x => x.Name == name);
                    v.Name = newName;
                    metaDbContainer.Entry(v).State = EntityState.Modified;
                    metaDbContainer.SaveChanges();
                    break;
                }
                case "[repo]":
                {
                    if (metaDbContainer.ReportSet.Any(x => x.Name == newName))
                    {
                        MessageBox.Show("Отчёт с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        переименоватьToolStripMenuItem_Click(sender, null);
                    }

                    var r = metaDbContainer.ReportSet.First(x => x.Name == name);
                    r.Name = newName;
                    metaDbContainer.Entry(r).State = EntityState.Modified;
                    metaDbContainer.SaveChanges();
                    break;
                }
            }

            node.Text = newName;
        }

        private void добавитьЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nvf = new NewValueForm(metaDbContainer, dbConnection);
            nvf.ShowDialog();
        }
    }
}

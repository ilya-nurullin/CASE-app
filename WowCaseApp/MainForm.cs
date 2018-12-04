using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowCaseApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void создатьНовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Show();
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
    }
}

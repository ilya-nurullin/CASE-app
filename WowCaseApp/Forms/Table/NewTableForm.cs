using log4net;
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
    public partial class NewTableForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(NewTableForm));

        public NewTableForm()
        {
            InitializeComponent();
            log.Debug("NewTableForm opened");
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indexOf = new Dictionary<String, int>()
            {
                { "title", 0 },
                { "type", 1},
                { "isPK", 2},
                { "isNullable", 3},
                { "isIndexed", 4},
            };
            DataGridViewRowCollection attributes = dataGridView.Rows;

            foreach (DataGridViewRow attribute in attributes)
            {
                log.Debug(attribute.Cells[indexOf["title"]].EditedFormattedValue.ToString());
                log.Debug(attribute.Cells[indexOf["type"]].EditedFormattedValue.ToString());
                log.Debug(attribute.Cells[indexOf["isPK"]].EditedFormattedValue.ToString());
                log.Debug(attribute.Cells[indexOf["isNullable"]].EditedFormattedValue.ToString());
                log.Debug(attribute.Cells[indexOf["isIndexed"]].EditedFormattedValue.ToString());
            }
        }
    }
}

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
using WowCaseApp.Model;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp
{
    public partial class TableInfoForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(NewTableForm));
        private readonly MetaDataDBContainer metaDbContainer;
        private readonly SqlConnection dbConnection;
        private readonly Table currenTable;

        public TableInfoForm(string realTableName, MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection)
        {
            InitializeComponent();
            this.metaDbContainer = metaDataDbContainer;
            this.dbConnection = dbConnection;
            currenTable = metaDbContainer.TableSet.Where(t => t.RealName == realTableName).First();
            Text = $"Просмотр таблицы {currenTable.Name}";

            var allAttrs = currenTable.Attributes.ToList();
            int allAttrsCount = allAttrs.Count;

            if (allAttrsCount > 0)
            {
                dataGridView1.Rows.Add(allAttrsCount);

                for (int i = 0; i < allAttrsCount; i++)
                {
                    var cells = dataGridView1.Rows[i].Cells;
                    cells[0].Value = allAttrs[i].Name;
                    cells[0].Tag = allAttrs[i];
                    cells[1].Value = (allAttrs[i].Type.StartsWith("t")) ? "Ссылка на таблицу" : allAttrs[i].Type;
                    cells[2].Value = allAttrs[i].IsPKey;
                    cells[3].Value = allAttrs[i].IsNullable;
                    cells[4].Value = allAttrs[i].IsIndexed;
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.ToString() == "")
            {
                MessageBox.Show("Имя не может быть пустым");
                e.Cancel = true;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                var nameCell = rows[i].Cells[0];
                var attr = (Attribute)nameCell.Tag;
                attr.Name = nameCell.EditedFormattedValue.ToString();
            }

            metaDbContainer.SaveChanges();
            MessageBox.Show("Изменения успешно сохранены");
            Close();
        }
    }
}

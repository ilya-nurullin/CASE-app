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
        private readonly Table currentTable;

        public TableInfoForm(string realTableName, MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection)
        {
            InitializeComponent();
            this.metaDbContainer = metaDataDbContainer;
            this.dbConnection = dbConnection;
            currentTable = metaDbContainer.TableSet.Where(t => t.RealName == realTableName).First();
            Text = $"Просмотр таблицы {currentTable.Name}";

            var allAttrs = currentTable.Attributes.ToList();
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

        public void Rerender()
        {
            var allAttrs = currentTable.Attributes.ToList();
            int allAttrsCount = allAttrs.Count;
            dataGridView1.Rows.Clear();

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

        private void удалитьВыбранноеПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cells = dataGridView1.SelectedCells.Cast<DataGridViewCell>();
            var cell = cells.First();
            if (! cells.All(c => c.RowIndex == cell.RowIndex) || cells.Count() == 0)
            {
                MessageBox.Show("Выберите ячейки одной строки");
                return;
            }


            Attribute attribute = ((Attribute) dataGridView1.Rows[cell.RowIndex].Cells[0].Tag);
            if (attribute.IsPKey)
            {
                MessageBox.Show("Нельзя удалять первичный ключ");
                return;
            }

            
            metaDbContainer.AttributeSet.Remove(attribute);
            currentTable.Attributes.Remove(attribute);
            metaDbContainer.SaveChanges();

            if (attribute.IsFKey)
            {
                Table parentTable = metaDbContainer.TableSet.Where(t => t.RealName == attribute.Type)
                    .First();
                currentTable.ParentTables.Remove(parentTable);
                parentTable.ChildTables.Remove(currentTable);
                SqlExecutor.ExecuteNonQuery(dbConnection, $"ALTER TABLE {currentTable.RealName} DROP constraint [FK_{currentTable.RealName}_{attribute.RealName}]");
                metaDbContainer.SaveChanges();
            }

            SqlExecutor.ExecuteNonQuery(dbConnection, $"ALTER TABLE {currentTable.RealName} DROP COLUMN {attribute.RealName}");
            dataGridView1.Rows.RemoveAt(cell.RowIndex);
            MessageBox.Show("Колонка успешно удалена");
        }

        private void создатьАтрибутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewAttributeForm(metaDbContainer, dbConnection, currentTable);
            if (form.ShowDialog() != DialogResult.Cancel)
            {
                Rerender();
            }
        }
    }
}

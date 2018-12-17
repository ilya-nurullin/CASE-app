using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WowCaseApp.Model;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp
{
    public partial class NewTableForm : System.Windows.Forms.Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(NewTableForm));
        private readonly MetaDataDBContainer metaDbContainer;
        private readonly SqlConnection dbConnection;
        private static readonly Dictionary<String, int> indexOf = new Dictionary<String, int>()
        {
            { "title", 0 },
            { "type", 1},
            { "isPK", 2},
            { "isNullable", 3},
            { "isIndexed", 4},
            { "defaultValue", 5},
        };

        private readonly Dictionary<string, string> tableRealName2Name;

        private readonly SqlExecutor sqlExecutor;

        /*
Давать возможность изменять структуру данных целевого приложения, с которым будет работать конечный пользователь.
Как минимум - создавать новые таблицы, добавлять в таблицы новые атрибуты, индексировать по ним, а также создавать связи между таблицами - на положительную оценку.
На хорошую оценку - задавать ограничения на значения атрибутов, начальные значения и пр.
На отличную - давать возможность и удалять поля в таблицах и сами таблицы, связи (или изменять, но это можно сделать и через удаление-добавление).
Схема БД фиксируется в метаданных. Операции над структурой БД должны выполняться с учётом поддержания целостности метаданных, 
т.е. метаданные также нормализуются, как и данные в обычных БД, но описывают они не состояние объекта предметной области, а состояние БД, её структуру.
         */
        public NewTableForm(MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection)
        {
            InitializeComponent();
            log.Debug("NewTableForm opened");
            this.metaDbContainer = metaDataDbContainer;
            this.dbConnection = dbConnection;
            sqlExecutor = new SqlExecutor(dbConnection);
            tableRealName2Name = GetTableNames();
            ((DataGridViewComboBoxColumn)fkDataGridView.Columns[0]).Items.AddRange(tableRealName2Name.Keys.Select(x => x.ToString()).ToArray());
        }

        private Dictionary<string, string> GetTableNames()
        {
            return metaDbContainer.TableSet.Where(t => t.Attributes.Any(a => a.IsPKey)).ToList().Aggregate(new Dictionary<string, string>(), (d, t) =>
            {
                d.Add(t.Name, t.RealName);
                return d;
            });
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection attributes = dataGridView.Rows;

            System.Collections.IList list = attributes;
            var tableName = tableNameTextBox.Text;
            var realTableName = "t" + DateTime.Now.ToString("ddMMyyyy_HHmmss");

            if (!CheckValidity())
                return;

            var dataGridViewRows = attributes.Cast<DataGridViewRow>()
                .Where(row => (string)row.Cells[0].EditedFormattedValue != "");

            var createCols = dataGridViewRows
                .Select((row, index) => Row2SqlCreateTable(row, index));

            var fkStartIndex = dataGridViewRows.Count();
            var fkAttributes = fkDataGridView.Rows.Cast<DataGridViewRow>().Where(row => (string)row.Cells[0].EditedFormattedValue != "");
            var fkCols = fkAttributes.Select((row, index) => FKRow2SqlCreateTable(row, index + fkStartIndex));

            var colsInTable = createCols.Union(fkCols).ToList();

            // create table
            sqlExecutor.ExecuteNonQuery($"CREATE TABLE {realTableName}({string.Join(", ", colsInTable)})");

            // create indexes
            dataGridViewRows
                .Select((row, index) => Row2SqlCreateIndex(row, index, realTableName))
                .Where(x => x != "")
                .Select(sqlExecutor.ExecuteNonQuery).ToList();

            // create PK
            dataGridViewRows
                .Select((row, index) => Row2SqlPK(row, index, realTableName))
                .Where(x => x != "")
                .Select(sqlExecutor.ExecuteNonQuery).ToList();

            // add constraint on FK for current table
            if (fkAttributes.Count() > 0)
                sqlExecutor.ExecuteNonQuery($"ALTER TABLE {realTableName} ADD "
                                            + string.Join(", ", fkAttributes.Select((row, index) => Row2FKSql(row, index + fkStartIndex, realTableName)))
                                            );

            // create EF Table
            var efTable = new Table(tableName, realTableName);
            efTable.Attributes = dataGridViewRows
                .Select((row, index) => Row2Attribute(row, index))
                .Union(
                    fkAttributes.Select((row, index) => Row2FKAttribute(row, index + fkStartIndex))
                )
                .ToList();
            efTable.ParentTables = fkAttributes.Select(row => Row2ParentTable(row)).ToList();

            metaDbContainer.TableSet.Add(efTable);
            metaDbContainer.SaveChanges();

            fkAttributes.Select(row =>
            {
                string tn = row.Cells[0].EditedFormattedValue.ToString();
                string realName = tableRealName2Name[tn];

                metaDbContainer.TableSet.Where(x => x.RealName == realName).First().ChildTables.Add(efTable);
                return 0;
            }).ToList();

            metaDbContainer.SaveChanges();

            log.Info($"Table {tableName} ({realTableName}) was created successfully");
            MessageBox.Show("Таблица успешно создана!");
            ((MainForm)Parent.Parent).LoadTreeView();
            this.Close();
        }

        private Table Row2ParentTable(DataGridViewRow row)
        {
            string tableName = row.Cells[0].EditedFormattedValue.ToString();
            string realName = tableRealName2Name[tableName];

            return metaDbContainer.TableSet.Where(x => x.RealName == realName).First();
        }

        private Attribute Row2FKAttribute(DataGridViewRow row, int index)
        {
            string tableName = row.Cells[0].EditedFormattedValue.ToString();
            string realName = tableRealName2Name[tableName];

            return new Attribute(
                name: $"Ссылка на {tableName}",
                realname: $"col{index}",
                type: realName,
                isIndexed: true,
                isNullable: false,
                isPKey: false,
                isFKey: true
            );
        }

        private string Row2FKSql(DataGridViewRow row, int index, string realTableName)
        {
            string tableName = row.Cells[0].EditedFormattedValue.ToString();
            string realName = tableRealName2Name[tableName];
            string pkName = metaDbContainer.TableSet.Where(t => t.RealName == realName).First().Attributes
                .Where(a => a.IsPKey).First().RealName;

            return $" CONSTRAINT FK_{realTableName}_col{index} FOREIGN KEY (col{index}) REFERENCES {realName}({pkName})";
        }

        private bool CheckValidity()
        {
            return CheckTableName() && CheckRows();
        }

        private bool CheckRows()
        {
            DataGridViewRowCollection attributes = dataGridView.Rows;
            System.Collections.IList list = attributes;

            var rowsExceptTheLastOne = list.Cast<DataGridViewRow>().Reverse().Skip(1);

            if (attributes.Count == 0 || rowsExceptTheLastOne.Count() == 0)
            {
                MessageBox.Show("Требуется создать хотя бы один столбец");
                return false;
            }

            bool hasErrorLines = rowsExceptTheLastOne.Any(x => x.Cells[0].EditedFormattedValue.ToString() == ""
                                                                              && x.Cells[1].EditedFormattedValue.ToString() != "");
            if (hasErrorLines)
            {
                MessageBox.Show("Имя столбца не может быть пустым");
                return false;
            }

            return true;
        }

        private bool CheckTableName()
        {
            if (tableNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Имя таблицы не может быть пустым");
                return false;
            }

            return true;
        }

        private Attribute Row2Attribute(DataGridViewRow row, int rowIndex)
        {
            return new Attribute(
                name: row.Cells[indexOf["title"]].EditedFormattedValue.ToString(),
                realname: $"col{rowIndex}",
                type: row.Cells[indexOf["type"]].EditedFormattedValue.ToString(),
                isIndexed: (bool)row.Cells[indexOf["isIndexed"]].EditedFormattedValue,
                isNullable: (bool)row.Cells[indexOf["isNullable"]].EditedFormattedValue,
                isPKey: (bool)row.Cells[indexOf["isPK"]].EditedFormattedValue
                );
        }

        private string Row2SqlCreateTable(DataGridViewRow row, int rowIndex)
        {
            string type = row.Cells[indexOf["type"]].EditedFormattedValue.ToString();
            string attrName = row.Cells[indexOf["title"]].EditedFormattedValue.ToString();
            bool isNullable = (bool)row.Cells[indexOf["isNullable"]].EditedFormattedValue;

            return $"col{rowIndex} {Type2Sql(type)} {NotNull2Sql(isNullable)} {Default2Sql(row)}";
        }

        private string FKRow2SqlCreateTable(DataGridViewRow row, int rowIndex)
        {
            string tableName = row.Cells[0].EditedFormattedValue.ToString();
            string realName = tableRealName2Name[tableName];

            string type = Type2Sql(metaDbContainer.TableSet.Where(t => t.RealName == realName).First().Attributes
                .Where(a => a.IsPKey).First().Type, true);

            return $"col{rowIndex} {type} NOT NULL";
        }

        private string Row2SqlCreateIndex(DataGridViewRow row, int rowIndex, string tableName)
        {
            bool isIndexed = (bool)row.Cells[indexOf["isIndexed"]].EditedFormattedValue;

            if (!isIndexed)
                return "";

            if (new string[] { "Строка", "Текст" }.Contains(Row2Val<string>(row, "type")))
            {
                return "";
            }

            return $"CREATE INDEX i{rowIndex} ON {tableName} (col{rowIndex});";
        }

        private string Type2Sql(string type, bool forFK = false)
        {
            switch (type)
            {
                case "Автоинкремент": return (forFK) ? "INT" : "INT IDENTITY (1,1)";
                case "Строка": return "nvarchar(max)";
                case "Текст": return "text";
                case "Дата": return "date";
                case "Дата и время": return "datetime";
                case "Дробное число": return "real";
                case "Целое число со знаком": return "int";
                case "Да/нет": return "bit";
            }

            return "";
        }

        private string NotNull2Sql(bool flag)
        {
            return (flag) ? "NULL" : "NOT NULL";
        }

        private string Default2Sql(DataGridViewRow row)
        {
            string type = row.Cells[indexOf["type"]].EditedFormattedValue.ToString();

            string defaultValue;
            string defaultVal = Row2Val<string>(row, "defaultValue");
            if (type == "Автоинкремент" || defaultVal == "")
            {
                defaultValue = "";
            }
            else
            {
                defaultValue = $"DEFAULT N'{defaultVal}'";
            }

            return defaultValue;
        }

        private string Row2SqlPK(DataGridViewRow row, int rowIndex, string tableName)
        {
            if (Row2Val<bool>(row, "isPK"))
                return $"ALTER TABLE {tableName} ADD CONSTRAINT PK_{tableName} PRIMARY KEY (col{rowIndex});";
            return "";
        }

        private T Row2Val<T>(DataGridViewRow row, string key)
        {
            return (T)row.Cells[indexOf[key]].EditedFormattedValue;
        }



        private void tableNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(SpaceCheck);
        private static void SpaceCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (e.KeyChar == (int)Keys.Space)
                e.Handled = true;
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if( dataGridView.CurrentCell.ColumnIndex ==0)
                e.Control.KeyPress += SpaceCheck;

        }
    }
}

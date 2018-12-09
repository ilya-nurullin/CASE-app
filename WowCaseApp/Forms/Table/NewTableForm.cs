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
    public partial class NewTableForm : System.Windows.Forms.Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(NewTableForm));
        private readonly MetaDataDBContainer metaDbContainer;
        private readonly SqlConnection dbConnection;
        private static readonly Dictionary<String, int>  indexOf = new Dictionary<String, int>()
        {
            { "title", 0 },
            { "type", 1},
            { "isPK", 2},
            { "isNullable", 3},
            { "isIndexed", 4},
            { "defaultValue", 5},
        };

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
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection attributes = dataGridView.Rows;

            System.Collections.IList list = attributes;
            var tableName = tableNameTextBox.Text;
            var realTableName = "t"+DateTime.Now.ToString("ddMMyyyy_HHmmss");

            var dataGridViewRows = attributes.Cast<DataGridViewRow>()
                .Where(row => (string)row.Cells[0].EditedFormattedValue != "");
            var createCols = dataGridViewRows
                .Select((row, index) => Row2SqlCreateTable(row, index));

            // create table
            sqlExecutor.ExecuteNonQuery($"CREATE TABLE {realTableName}({string.Join(", ", createCols)})");

            // create indexes
            var s = dataGridViewRows
                .Select((row, index) => Row2SqlCreateIndex(row, index, realTableName))
                .Where(x => x != "")
                .Select(sqlExecutor.ExecuteNonQuery);

            // create PK
            var d = dataGridViewRows
                .Select((row, index) => Row2SqlPK(row, index, realTableName))
                .Where(x => x != "")
                .Select(sqlExecutor.ExecuteNonQuery);

            // create EF Table
            var efTable = new Table(tableName, realTableName);
            efTable.Attributes = dataGridViewRows.Select((row, index) => Row2Attribute(row, index)).ToList();

            metaDbContainer.TableSet.Add(efTable);
            metaDbContainer.SaveChanges();

            log.Info($"Table {tableName} ({realTableName}) was created successfully");
            MessageBox.Show("Таблица успешно создана!");
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

        private string Row2SqlCreateIndex(DataGridViewRow row, int rowIndex, string tableName)
        {
            bool isIndexed = (bool) row.Cells[indexOf["isIndexed"]].EditedFormattedValue;

            if (!isIndexed)
                return "";

            if (new string[] { "Строка", "Текст" }.Contains(Row2Val<string>(row, "type")))
            {
                return "";
            }

            return $"CREATE INDEX i{rowIndex} ON {tableName} (col{rowIndex});";
        }

        private string Type2Sql(string type)
        {
            switch (type)
            {
                case "Автоинкремент": return "INT IDENTITY (1,1)";
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
            return (T) row.Cells[indexOf[key]].EditedFormattedValue;
        }
    }
}

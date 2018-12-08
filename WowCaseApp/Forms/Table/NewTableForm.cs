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

namespace WowCaseApp
{
    public partial class NewTableForm : System.Windows.Forms.Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(NewTableForm));
        private static MetaDataDBContainer metaDbContainer;
        private static SqlConnection dbConnection;
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
            NewTableForm.metaDbContainer = metaDataDbContainer;
            NewTableForm.dbConnection = dbConnection;
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
                { "DefaultValue", 5},
            };
            DataGridViewRowCollection attributes = dataGridView.Rows;

            foreach (DataGridViewRow attribute in attributes)
            {
                string attrName = attribute.Cells[indexOf["title"]].EditedFormattedValue.ToString();
                log.Debug(attrName);
                log.Debug(attribute.Cells[indexOf["type"]].EditedFormattedValue.ToString());
                log.Debug(attribute.Cells[indexOf["isPK"]].EditedFormattedValue.ToString());
                log.Debug(attribute.Cells[indexOf["isNullable"]].EditedFormattedValue.ToString());
                log.Debug(attribute.Cells[indexOf["isIndexed"]].EditedFormattedValue.ToString());
            }
        }
    }
}

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
    public partial class NewAttributeForm : Form
    {
        private readonly Dictionary<string, string> tableRealName2Name;
        private readonly MetaDataDBContainer metaDbContainer;
        private readonly SqlConnection dbConnection;
        private readonly Table currentTable;

        public NewAttributeForm(MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection, Table currentTable)
        {
            InitializeComponent();
            this.metaDbContainer = metaDataDbContainer;
            this.dbConnection = dbConnection;
            this.currentTable = currentTable;
            tableRealName2Name = metaDbContainer.TableSet
                .Where(t => t.Attributes.Any(a => a.IsPKey)).ToList().Where(t => !currentTable.ParentTables.Contains(t) && t.RealName != currentTable.RealName)
                .Aggregate(new Dictionary<string, string>(), (d, t) =>
                {
                    d.Add("Ссылка на " + t.Name, t.RealName);
                    return d;
                });
        }

        private void NewAttributeForm_Load(object sender, EventArgs e)
        {
            var items = new List<string>
            {
                "Строка",
                "Текст",
                "Дата",
                "Дата и время",
                "Дробное число",
                "Целое число со знаком",
                "Да/нет"
            };

            items.AddRange(tableRealName2Name.Keys);

            typeComboBox.Items.AddRange(items.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите имя атрибута");
                return;
            }
            if (typeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Укажите выберите тип атрибута");
                return;
            }

            int sqlResCode = SqlExecutor.ExecuteNonQuery(dbConnection,
                $"ALTER TABLE {currentTable.RealName} ADD col{currentTable.Attributes.Count} {MapType(typeComboBox.Text)} {((!isNullableCheckBox.Checked) ? "NOT" : "")} NULL");

            bool itIsFK = typeComboBox.Text.StartsWith("Ссылка на");
            if (sqlResCode > -1 && itIsFK)
            {
                string realName = tableRealName2Name[typeComboBox.Text];
                string pkName = metaDbContainer.TableSet.Where(t => t.RealName == realName).First().Attributes
                    .Where(a => a.IsPKey).First().RealName;
                sqlResCode = SqlExecutor.ExecuteNonQuery(dbConnection,
                    $"ALTER TABLE {currentTable.RealName} ADD CONSTRAINT FK_{currentTable.RealName}_col{currentTable.Attributes.Count} FOREIGN KEY (col{currentTable.Attributes.Count}) REFERENCES {realName}({pkName})");
            }

            if (sqlResCode < 0)
            {
                return;
            }
            currentTable.Attributes.Add(new Model.Attribute(
                name: nameTextBox.Text,
                realname: $"col{currentTable.Attributes.Count}",
                type: MapAttrType(typeComboBox.Text),
                isIndexed: (itIsFK) ? true : isIndexedCheckBox.Checked,
                isNullable: isNullableCheckBox.Checked,
                isPKey: false
            ));
            metaDbContainer.SaveChanges();

            if (itIsFK)
            {
                var prn = tableRealName2Name[typeComboBox.Text];
                var parent = metaDbContainer.TableSet.First(t => t.RealName == prn);
                currentTable.ParentTables.Add(parent);
                parent.ChildTables.Add(currentTable);
            }

            MessageBox.Show("Атрибут успешно добавлен");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string MapAttrType(string input)
        {
            if (input.StartsWith("Ссылка на "))
                return tableRealName2Name[input];
            else
            {
                return input;
            }
        }

        private string MapType(string input, bool forFK = false)
        {
            switch (input)
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

            var rtn = tableRealName2Name[input];

            return MapType(metaDbContainer.TableSet.First(t => t.RealName == rtn).Attributes
                .First(a => a.IsPKey).Type, true);
        }
    }
}

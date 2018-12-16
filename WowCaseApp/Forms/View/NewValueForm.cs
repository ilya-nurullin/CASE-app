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
using log4net;
using WowCaseApp.Model;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp.Forms.View
{
    public partial class NewValueForm : Form
    {
        static readonly ILog _log = LogManager.GetLogger(typeof(ViewForm));
        MetaDataDBContainer _container;
        SqlConnection _dbConnection;

        public NewValueForm(MetaDataDBContainer Container, SqlConnection dbConnection)
        {
            InitializeComponent();
            _container = Container;
            _dbConnection = dbConnection;
        }

        private void NewValueForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (var t in _container.TableSet)
                comboBox1.Items.Add(t);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Table t = comboBox1.SelectedItem as Table;

            flowLayoutPanel1.Controls.Clear();
            GenerateComponents(t?.Attributes);
        }

        void GenerateComponents(IEnumerable<Attribute> attributes)
        {
            foreach (var a in attributes)
            {
                if (a.IsPKey && a.Type == "Автоинкремент")
                    continue;

                Control c = new Control();
                string type = a.Type;
                if (a.IsFKey)
                    type = _container.TableSet.First(x => x.RealName == a.Type).Attributes.First(x => x.IsPKey).Type;
                switch (type)
                {
                    case "Автоинкремент":
                    case "Целое число со знаком":
                    case "Дробное число":
                    c = new TextBox();
                    break;

                    case "Строка":
                    case "Текст":
                    c = new TextBox();
                    break;

                    case "Дата":
                    case "Дата и время":
                    c = new DateTimePicker();
                    break;

                    case "Да/нет":
                    c = new CheckBox();
                    ((CheckBox)c).CheckedChanged += (o, e) =>
                    {
                        ((CheckBox)o).Text = ((CheckBox)o).Checked.ToString();
                    };
                    break;
                }

                c.Name = $"{a.RealName}";

                c.Margin = new Padding(50, 5, 0, 5);

                Control label = new Label() { Text = a.Name, Margin = new Padding(50,5,0,5), AutoSize = true};
                label.BackColor = Color.Transparent;

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.SelectedItem is Table t)) return;

            var cols = "";
            var values = "";

            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Label) continue;

                cols += $"{c.Name}, ";

                if (c is DateTimePicker dtp)
                    values += $"'{dtp.Value.ToShortDateString()}', ";
                else values += $"'{c.Text}', ";
            }

            cols = cols.Trim(',', ' ');
            values = values.Trim(',', ' ');

            var sql = $"INSERT INTO {t.RealName} ({cols}) VALUES ({values})";

            try
            {
                SqlExecutor.ExecuteNonQuery(_dbConnection,sql);

                MessageBox.Show($"Значение добавлено в таблицу '{t.Name}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при записи значения, возможно запрос некорректный","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _log.Error(ex);
            }
        }
    }
}

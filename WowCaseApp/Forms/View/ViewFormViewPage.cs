

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WowCaseApp.Model;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm
    {
        private static int _indexValue=0;

        public void InitializeViewPage()
        {
            _indexValue = 0;
            GenerateView((Table)comboBoxMainTable.SelectedItem, (Table)comboBoxChildTable.SelectedItem, listBoxCurrent.Items.Cast<Attribute>());
        }

        public void GenerateView(Table mainT, Table childT, IEnumerable<Attribute> currentAttribs)
        {
            if (!currentAttribs.Any())
            {
                MessageBox.Show("Нечего показывать");
                tabControl.SelectedIndex = 0;
                return;
            }


            var mainAttributes = currentAttribs.Intersect(mainT.Attributes);
            var childAttributes = currentAttribs.Except(mainT.Attributes);

            PanelViewPage.Controls.Clear();

            GenerateComponentsOneValue(mainAttributes);
            // main is a Parent
            if (mainT.ChildTables.Contains(childT))
            {
                GenerateComponentsManyValues(childT, childAttributes);
            }
            else
            {
                GenerateComponentsOneValue(childAttributes);
            }

            LoadData(0, mainT,childT,mainAttributes, childAttributes);
        }
        public void GenerateComponentsOneValue(IEnumerable<Attribute> attributes)
        {
            foreach (var a in attributes)
            {
                Control c = new Control();
                switch (a.Type)
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
                        break;

                }

                c.Name = a.Name;
                
                PanelViewPage.Controls.Add(new Label() { Text = a.Name, Name = a.RealName + "_label" });
                PanelViewPage.Controls.Add(c);
            }
        }
        public void GenerateComponentsManyValues(Table table,IEnumerable<Attribute> attributes)
        {
            if (attributes.Any())
            {
                PanelViewPage.Controls.Add(new Label() {Name = table.Name+"_label"});
                PanelViewPage.Controls.Add(new DataGridView(){Name = table.Name + "_dgv" });
            }
        }

        public void LoadData(Table mainT, Table childT, IEnumerable<Attribute> mainAttributes, IEnumerable<Attribute> childAttributes)
        {
            foreach (var a in mainAttributes)
            {
                LoadDataOneValue(mainT, a, PanelViewPage.Controls[a.RealName]);
            }

            // main is a Parent
            if (mainT.ChildTables.Contains(childT))
            {
                LoadDataManyValue(mainT,  childT, childAttributes, (DataGridView)PanelViewPage.Controls[childT.RealName+"_dgv"]);
            }
            else
            {
                foreach (var a in childAttributes)
                {
                    LoadDataOneValue(childT, a, PanelViewPage.Controls[a.RealName]);
                }
            }
        }
        public void LoadDataOneValue(Table sourceTable, Attribute attribute, Control control)
        {
            string text = $"Select top {_indexValue+ 1} * from [{sourceTable.RealName}]";

            var command = new SqlCommand(text, _dbConnection);
            var sqlreader = command.ExecuteReader();
            try
            {
                if (!sqlreader.Read())
                    throw new Exception($"LoadDataOneValue[ViewForm] - no data (index was {_indexValue})");

                for (int i = 0; i < _indexValue; i++)
                {
                    sqlreader.Read();
                }
                
                control.Text = sqlreader[attribute.RealName].ToString();
            }
            catch (Exception e)
            {
                _log.Error(e);
                return;
            }
            finally
            {
                sqlreader.Close();
            }
        }
        public void LoadDataManyValue(Table mainT, Table sourceTable, IEnumerable<Attribute> attributes, DataGridView dgv)
        {
            string attribs = "";

            foreach (var a in attributes)
            {
                attribs += a.RealName + ", ";
            }

            attribs = attribs.Any()? attribs.Trim(',', ' '):"*";

            string text = $"Select {attribs} from {sourceTable.RealName}";

            var command = new SqlCommand(text, _dbConnection);

            SqlDataAdapter sqlDataAdapter =new SqlDataAdapter(command);

            DataSet ds =new DataSet();

            sqlDataAdapter.Fill(ds, mainT.RealName);

            // where {mainT.RealName}_FK = {getValueIdFromTable(mainT)}

            dgv.DataSource = new DataView(ds.Tables[0], $"{mainT.RealName}_FK = {getValueIdFromTable(mainT)}", "", DataViewRowState.CurrentRows);
        }

        public string getValueIdFromTable(Table T)
        {
            string primaryAttributename = T.Attributes.First(a => a.IsPKey).RealName;

            string text = $"Select top {_indexValue+1} {primaryAttributename} from {T.RealName}";

            var command = new SqlCommand(text, _dbConnection);
            var sqlreader = command.ExecuteReader();
            try
            {
                if (!sqlreader.Read())
                    throw new Exception($"LoadDataOneValue[ViewForm] - no data (index was {_indexValue})");

                for (int i = 0; i < _indexValue; i++)
                {
                    sqlreader.Read();
                }

                return sqlreader[primaryAttributename].ToString();
            }
            catch (Exception e)
            {
                _log.Error(e);
                return "0";
            }
            finally
            {
                sqlreader.Close();
            }

        }
    }
}

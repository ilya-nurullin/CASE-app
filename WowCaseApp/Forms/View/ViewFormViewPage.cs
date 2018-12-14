﻿

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using WowCaseApp.Model;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm
    {
        private static int _indexValue=0;
        private static List<SavedControl> _savedControls= new List<SavedControl>();

        public void InitializeViewPage()
        {
            _indexValue = 0;
            //if (!view.Data.Any())
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
            _savedControls.Clear();

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

            RestuctcturePanel();
            LoadData(mainT,childT,mainAttributes, childAttributes);
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

                c.Name = a.RealName;
                c.MouseDown += Control_MouseDown;
                c.MouseMove+= Control_MouseMove;
                c.MouseUp += Control_MouseUp;

                Control label = new Label() {Text = a.Name, Name = a.RealName + "_label"};
                label.MouseDown += Control_MouseDown;
                label.MouseMove += Control_MouseMove;
                label.MouseUp += Control_MouseUp;

                PanelViewPage.Controls.Add(label);
                PanelViewPage.Controls.Add(c);

                _savedControls.Add(new SavedControl(a,label));
                _savedControls.Add(new SavedControl(a,c));
            }
        }
        public void GenerateComponentsManyValues(Table table,IEnumerable<Attribute> attributes)
        {
            if (attributes.Any())
            {
                Control label = new Label(); // {Name = table.Name + "_label"};
                label.MouseDown += Control_MouseDown;
                label.MouseMove += Control_MouseMove;
                label.MouseUp += Control_MouseUp;

                PanelViewPage.Controls.Add(label);

                Control dgv = new DataGridView() { Name = table.Name + "_dgv" };
                dgv.MouseDown += Control_MouseDown;
                dgv.MouseMove += Control_MouseMove;
                dgv.MouseUp += Control_MouseUp;

                PanelViewPage.Controls.Add(dgv);
                
                _savedControls.Add(new SavedControl(null, label));
                _savedControls.Add(new SavedControl(null, dgv));
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

        public void RestuctcturePanel()
        {
            int previousY = 0;

            foreach (Control c in PanelViewPage.Controls)
            {
                c.Location = new Point(0, previousY);
                previousY += c.Height;
            }
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

        public void SavePanel()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream m = new MemoryStream())
            {
                bf.Serialize(m,_savedControls);
                view.Data = m.ToArray();
                _cont.SaveChanges();
            }
        }

        public void LoadPanel()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream m = new MemoryStream(view.Data))
            {
                _savedControls = (List<SavedControl>)bf.Deserialize(m);
            }

            PanelViewPage.Controls.Clear();

            foreach (var savedControl in _savedControls)
            {
                Control c = savedControl.toControl();

                PanelViewPage.Controls.Add(c);
            }
        }
   
        // ----------- Перетаскивание----------------
        bool isDown;
        Control curControl;
        private Point previous;
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            curControl = sender as Control;
        }
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown && sender is Control c && curControl.Equals(sender))
            {
                var p =PanelViewPage.PointToClient(Control.MousePosition);
                p.X = p.X > 0 ? p.X : 0;
                p.Y = p.Y > 0 ? p.Y : 0;
                c.Location = p;
            }
        }
        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            curControl = null;
        }
    }
}

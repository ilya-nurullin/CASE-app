

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
        static int _indexValue=0;
        int _size = 0;
        bool _isListBoxCurrentChanged = true;
        static List<SavedControl> _savedControls= new List<SavedControl>();

        void InitializeViewPage()
        {
            _indexValue = 0;
            if (_isListBoxCurrentChanged)
                GenerateView((Table)comboBoxMainTable.SelectedItem, (Table)comboBoxChildTable.SelectedItem, listBoxCurrent.Items.Cast<Attribute>());
            //else LoadViewForm();

            //_isListBoxCurrentChanged = false;
        }

        void GenerateView(Table mainT, Table childT, IEnumerable<Attribute> currentAttribs)
        {
            _isListBoxCurrentChanged = false;
            if (!currentAttribs.Any())
            {
                _isListBoxCurrentChanged = true;
                MessageBox.Show("Нечего показывать");
                tabControl.SelectedIndex = 0;
                return;
            }


            var mainAttributes = currentAttribs.Intersect(mainT.Attributes);
            var childAttributes = currentAttribs.Except(mainT.Attributes);

            PanelViewPage.Controls.Clear();
            _savedControls.Clear();

            GenerateComponentsOneValue(mainT, mainAttributes);
            // main is a Parent
            if (mainT.ChildTables.Contains(childT))
            {
                GenerateComponentsManyValues(childT, childAttributes);
            }
            else
            {
                GenerateComponentsOneValue(childT, childAttributes);
            }

            RestuctcturePanel();
            LoadData(mainT,childT,mainAttributes, childAttributes);
        }
        void GenerateComponentsOneValue(Table table, IEnumerable<Attribute> attributes)
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
                        ((CheckBox) c).CheckedChanged += (o, e) =>
                        {
                            ((CheckBox) o).Text = ((CheckBox) o).Checked.ToString();
                        };
                        break;

                }

                c.Name = $"{table.RealName}.{a.RealName}";
                c.MouseDown += Control_MouseDown;
                c.MouseMove+= Control_MouseMove;
                c.MouseUp += Control_MouseUp;
                c.Enabled = radioButton2.Checked;

                Control label = new Label() {Text = a.Name, Name = $"{table.RealName}.{a.RealName}_label"};
                label.MouseDown += Control_MouseDown;
                label.MouseMove += Control_MouseMove;
                label.MouseUp += Control_MouseUp;
                label.BackColor = Color.Transparent;

                PanelViewPage.Controls.Add(label);
                PanelViewPage.Controls.Add(c);

                _savedControls.Add(new SavedControl(a,label));
                _savedControls.Add(new SavedControl(a,c));
            }
        }
        void GenerateComponentsManyValues(Table table,IEnumerable<Attribute> attributes)
        {
            if (attributes.Any())
            {
                Control label = new Label() {Name = table.RealName + "_label"};
                label.Text = table.Name;
                label.MouseDown += Control_MouseDown;
                label.MouseMove += Control_MouseMove;
                label.MouseUp += Control_MouseUp;
                label.BackColor = Color.Transparent;

                PanelViewPage.Controls.Add(label);

                Control dgv = new DataGridView()
                {
                    Name = table.RealName + "_dgv",
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                    RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
                    AllowUserToResizeRows = false,
                    AllowUserToResizeColumns = false,
                    Enabled = false,
                    //ReadOnly = true
                };
                dgv.MouseDown += Control_MouseDown;
                dgv.MouseMove += Control_MouseMove;
                dgv.MouseUp += Control_MouseUp;

                PanelViewPage.Controls.Add(dgv);
                
                _savedControls.Add(new SavedControl(null, label));
                _savedControls.Add(new SavedControl(null, dgv));
            }
        }

        void RestuctcturePanel()
        {
            int previousY = 0;

            foreach (Control c in PanelViewPage.Controls)
            {
                c.Location = new Point(0, previousY);
                previousY += c.Height;
            }
        }

        void LoadData()
        {
            var mainT = (Table)comboBoxMainTable.SelectedItem;
            var childT = (Table)comboBoxChildTable.SelectedItem;
            var currentAttribs = listBoxCurrent.Items.Cast<Attribute>();

            var mainAttributes = currentAttribs.Intersect(mainT.Attributes);
            var childAttributes = currentAttribs.Except(mainT.Attributes);

            LoadData(mainT,childT,mainAttributes,childAttributes);
        }
        void LoadData(Table mainT, Table childT, IEnumerable<Attribute> mainAttributes, IEnumerable<Attribute> childAttributes)
        {
            _size = getSizeTable(mainT);

            countLabel.Text = $"{(_size == 0?0:_indexValue + 1)}/{_size}";

            foreach (var a in mainAttributes)
            {
                LoadDataOneValue(mainT, a, PanelViewPage.Controls[$"{mainT.RealName}.{a.RealName}"]);
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
        void LoadDataOneValue(Table sourceTable, Attribute attribute, Control control)
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
        void LoadDataManyValue(Table mainT, Table sourceTable, IEnumerable<Attribute> attributes, DataGridView dgv)
        {
            string attribs = "";

            foreach (var a in attributes)
                attribs += a.RealName + ", ";

            attribs = attribs.Any()? attribs.Trim(',', ' '):"*";

            var foreignAttribs = sourceTable.Attributes.Where(x => x.Type == mainT.RealName);
            var tableId = getValueIdFromTable(mainT);

            string filter = "";
            foreach (var fa in foreignAttribs)
                filter += $"{fa.RealName} = '{tableId}' &&";

            filter = filter.TrimEnd(' ', '&');
            if (filter != "")
                filter = "WHERE " + filter;

            string text = $"Select {attribs} from {sourceTable.RealName} {filter}";

            var command = new SqlCommand(text, _dbConnection);

            SqlDataAdapter sqlDataAdapter =new SqlDataAdapter(command);
            DataSet ds =new DataSet();
            sqlDataAdapter.Fill(ds, sourceTable.RealName);

            dgv.DataSource = new DataView(ds.Tables[0]);
            if (dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)> 0)
                dgv.Width = Math.Min(dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dgv.RowHeadersWidth,
                    this.Width);

            foreach (DataGridViewColumn col in dgv.Columns)
                col.HeaderText = attributes.First(x => x.RealName == col.DataPropertyName).Name;

        }

        DialogResult UpdateData()
        {
            var mainT = (Table)comboBoxMainTable.SelectedItem;
            var childT = (Table)comboBoxChildTable.SelectedItem;
            var currentAttribs = listBoxCurrent.Items.Cast<Attribute>();

            var mainAttributes = currentAttribs.Intersect(mainT.Attributes);
            var childAttributes = currentAttribs.Except(mainT.Attributes);

            try
            {
                UpdateData(mainT, childT, mainAttributes, childAttributes);

            }
            catch (Exception e)
            {
                return MessageBox.Show("Ошибка в некоторых данных. \nНеобходимо исправить. \n(Yes - исправить, No - откатить)", "Ошибка данных", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

            return DialogResult.OK;
        }
        void UpdateData(Table mainT, Table childT, IEnumerable<Attribute> mainAttributes,IEnumerable<Attribute> childAttributes)
        {
            string attribs = "";
            foreach (var a in mainAttributes)
                if (!a.IsPKey)
                    if (PanelViewPage.Controls[$"{mainT.RealName}.{a.RealName}"] is DateTimePicker c)
                        attribs += $"{a.RealName} = '{c.Value.ToShortDateString()}'";
                    else attribs += $"{a.RealName} = '{PanelViewPage.Controls[$"{mainT.RealName}.{a.RealName}"].Text}',";

            attribs = attribs.TrimEnd(',',' ');

            UpdateDataInDB(mainT.RealName, attribs, $"{mainT.Attributes.First(x=>x.IsPKey).RealName} = {getValueIdFromTable(mainT)}");

            // main is a Parent
            if (mainT.ChildTables.Contains(childT))
            {
                //TODO
                //var dgv = (DataGridView) PanelViewPage.Controls[childT.RealName + "_dgv"];

                //var dv = (DataView)dgv.DataSource;
                //var dt = dv.Table;
                //var dtc = dt.Columns;
                //var dtr = dt.Rows;

                //attribs = "";

                //foreach (DataColumn dc in dtc)
                //{
                //    attribs += $"{a.RealName} = '{PanelViewPage.Controls[a.RealName].Text}',";
                //}

                //UpdateDataManyValue(mainT, childT, childAttributes, );
            }
            else
            {
                if (childT==null) return;
                attribs = "";
                foreach (var a in childAttributes)
                    if(!a.IsPKey)
                    attribs += $"{a.RealName} = '{PanelViewPage.Controls[a.RealName].Text}',";

                attribs = attribs.TrimEnd(',', ' ');

                UpdateDataInDB(childT.RealName, attribs, $"{childT.Attributes.First(x => x.IsPKey)} = {getValueIdFromTable(childT)}");
            }
        }
        void UpdateDataInDB(string sourcetable, string values, string where)
        {
            string sql = $"UPDATE {sourcetable} " +
                         $"SET {values} " +
                         $"WHERE {where}";

            SqlExecutor.ExecuteNonQuery(_dbConnection, sql);
        }

        string getValueIdFromTable(Table T)
        {
            string primaryAttributename = T.Attributes.First(a => a.IsPKey).RealName;

            string text = $"Select top {_indexValue+1} {primaryAttributename} from {T.RealName} order by {primaryAttributename}";

            var command = new SqlCommand(text, _dbConnection);
            var sqlreader = command.ExecuteReader();
            try
            {
                if (!sqlreader.Read())
                    throw new Exception($"getValueIdFromTable[ViewForm] - no data (index was {_indexValue})");

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
        int getSizeTable(Table T)
        {
            string text = $"SELECT Count(*) FROM {T.RealName}";

            var command = new SqlCommand(text, _dbConnection);
            var sqlreader = command.ExecuteReader();
            try
            {
                if (!sqlreader.Read())
                    throw new Exception($"getSizeTable[ViewForm] - no data (index was {_indexValue})");

                //sqlreader.Read();
                
                return sqlreader.GetInt32(0);
            }
            catch (Exception e)
            {
                _log.Error(e);
                return 0;
            }
            finally
            {
                sqlreader.Close();
            }
        }

        void SaveViewForm()
        {
            foreach (var sc in _savedControls)
                sc.Update();

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream m = new MemoryStream())
            {
                bf.Serialize(m,_savedControls);
                bf.Serialize(m, comboBoxMainTable.SelectedItem);
                bf.Serialize(m, comboBoxChildTable.SelectedItem??new object());
                bf.Serialize(m, listBoxCurrent.Items.Cast<Attribute>().ToList());
                view.Data = m.ToArray();
                _cont.SaveChanges();
            }
        }
        void LoadViewForm()
        {
            _isListBoxCurrentChanged = false;
            InitializeAttributePage();

            BinaryFormatter bf = new BinaryFormatter();

            Table mainT =null, childT = null;
            try
            {
                using (MemoryStream m = new MemoryStream(view.Data))
                {
                    _savedControls = (List<SavedControl>) bf.Deserialize(m);
                    mainT = _cont.TableSet.Find((bf.Deserialize(m) as Table)?.Id);
                    childT = _cont.TableSet.Find((bf.Deserialize(m) as Table)?.Id);
                    listBoxCurrent.Items.Clear();
                    if (bf.Deserialize(m) is List<Attribute> atributes)
                    foreach (var a in  atributes )
                    {
                        var attr = _cont.AttributeSet.Find(a.Id);
                        if (attr != null)
                        listBoxCurrent.Items.Add(attr);
                    }

                    comboBoxMainTable.SelectedItem = mainT;
                    ChangeTableComboBox();
                    comboBoxChildTable.SelectedItem = childT;
                }
            

            ShowAttributesInStock();


            PanelViewPage.Controls.Clear();

            var currentAttribs = listBoxCurrent.Items.Cast<Attribute>();

            foreach (var savedControl in _savedControls)
            {
                Attribute a = _cont.AttributeSet.Find(savedControl.Attribute.Id);

                Table t = null;

                if (mainT.Attributes.Contains(a))
                    t = mainT;
                if (childT != null && childT.Attributes.Contains(a))
                    t = childT;

                Control c = savedControl.toControl();
                c.MouseDown += Control_MouseDown;
                c.MouseMove += Control_MouseMove;
                c.MouseUp += Control_MouseUp;
                c.Enabled = radioButton2.Checked;
                c.Name = $"{t.RealName}.{a.RealName}";

                if (c is CheckBox ch)
                    ch.CheckedChanged += (o, e) => { ch.Text = ch.Checked.ToString(); };

                if (c is Label label)
                    label.Name += "_label";

                if (c is DataGridView gridView)
                {
                    gridView.ColumnHeadersHeightSizeMode =
                        DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    gridView.AllowUserToResizeRows = false;
                    gridView.AllowUserToResizeColumns = false;
                    gridView.Enabled = false;
                    gridView.Name = $"{childT.RealName}_dgv";
                }

                savedControl.Control = c;
                PanelViewPage.Controls.Add(c);
            }

            _isListBoxCurrentChanged = false;
            LoadData();
            tabControl.SelectTab(1);

            }
            catch (Exception e)
            {
                _log.Error(e);
            }
        }

        void buttonPrevVal_Click(object sender, EventArgs e)
        {
            if (_indexValue == 0)
                return;

            var dr = UpdateData();
            if (dr == DialogResult.Yes)
                return;
            if (dr == DialogResult.OK)
                _indexValue--;

            LoadData();
        }
        void buttonNextVal_Click(object sender, EventArgs e)
        {
            if (_indexValue >= _size - 1)
                return;

            var dr = UpdateData();
            if (dr == DialogResult.Yes)
                return;
            if (dr == DialogResult.OK)
                _indexValue++;

            LoadData();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            bool readOnly = radioButton1.Checked;

            foreach (Control c in PanelViewPage.Controls)
            {
                c.Enabled = !readOnly;

                string tName = c.Name.Remove(c.Name.IndexOf('.'));
                string aName = c.Name.Replace(tName,"").Replace("_label","").Replace("_dgv","").Trim('.',' ');

                if (_cont.TableSet.First(x => x.RealName == tName).Attributes.First(x => x.RealName == aName).IsPKey)
                    if (!(c is Label))
                        ((TextBox) c).ReadOnly = true;

                if (c is DataGridView)
                    c.Enabled = false;

                if (c is Label)
                    c.Enabled = true;
                }

            if (_size == 0) return;

            if (readOnly)
            {
                var dr =UpdateData();
                if (dr == DialogResult.Yes)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                if (dr == DialogResult.No)
                    LoadData();
            }

            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

        // ----------- Перетаскивание----------------
        bool _isMouseButtonDown;
        Control curControl;
        Point previous;
        void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _isMouseButtonDown = true;
            curControl = sender as Control;
        }
        void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (_isMouseButtonDown && sender is Control c && curControl.Equals(sender))
            {
                var p =PanelViewPage.PointToClient(Control.MousePosition);
                p.X = p.X > 0 ? p.X : 0;
                p.Y = p.Y > 0 ? p.Y : 0;
                c.Location = p;
            }
        }
        void Control_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _isMouseButtonDown = false;
            curControl = null;
        }
    }
}

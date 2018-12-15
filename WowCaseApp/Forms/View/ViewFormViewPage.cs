

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
            else LoadViewForm();

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
                        break;

                }

                c.Name = $"{table.RealName}.{a.RealName}";
                c.MouseDown += Control_MouseDown;
                c.MouseMove+= Control_MouseMove;
                c.MouseUp += Control_MouseUp;

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

                Control dgv = new DataGridView() { Name = table.RealName + "_dgv" };
                dgv.MouseDown += Control_MouseDown;
                dgv.MouseMove += Control_MouseMove;
                dgv.MouseUp += Control_MouseUp;

                PanelViewPage.Controls.Add(dgv);
                
                _savedControls.Add(new SavedControl(null, label));
                _savedControls.Add(new SavedControl(null, dgv));
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

            countLabel.Text = $"{_indexValue + 1}/{_size}";

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
            {
                attribs += a.RealName + ", ";
            }

            attribs = attribs.Any()? attribs.Trim(',', ' '):"*";

            string text = $"Select {attribs} from {sourceTable.RealName}";

            var command = new SqlCommand(text, _dbConnection);

            SqlDataAdapter sqlDataAdapter =new SqlDataAdapter(command);

            DataSet ds =new DataSet();

            sqlDataAdapter.Fill(ds, sourceTable.RealName);

            // where {mainT.RealName}_FK = {getValueIdFromTable(mainT)}
            var foreignAttribs = attributes.Where(x => x.Type == mainT.RealName);

            var tableId = getValueIdFromTable(mainT);
            string filter = "";
            foreach (var fa in foreignAttribs)
            {
                filter += $"{fa.RealName} = {tableId} &&";
            }

            filter = filter.TrimEnd(' ', '&');
            dgv.DataSource = new DataView(ds.Tables[0], filter, "", DataViewRowState.CurrentRows);
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

        string getValueIdFromTable(Table T)
        {
            string primaryAttributename = T.Attributes.First(a => a.IsPKey).RealName;

            string text = $"Select top {_indexValue+1} {primaryAttributename} from {T.RealName}";

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

        void SavePanel()
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
            try
            {
                using (MemoryStream m = new MemoryStream(view.Data))
                {
                    _savedControls = (List<SavedControl>) bf.Deserialize(m);
                    var maint = (Table)bf.Deserialize(m);
                    var childT = (Table)bf.Deserialize(m);
                    listBoxCurrent.Items.Clear();
                    foreach (var a in (List<Attribute>) bf.Deserialize(m))
                    {
                        listBoxCurrent.Items.Add(_cont.AttributeSet.Find(a.Id));
                    }

                    comboBoxMainTable.SelectedItem = _cont.TableSet.Find(maint.Id);
                    ChangeTableComboBox();
                    comboBoxChildTable.SelectedItem = _cont.TableSet.Find(childT.Id);
                }
            }
            catch (Exception e)
            {
                _log.Error(e);
            }

            ShowAttributesInStock();


            PanelViewPage.Controls.Clear();

            foreach (var savedControl in _savedControls)
            {
                Control c = savedControl.toControl();
                c.MouseDown += Control_MouseDown;
                c.MouseMove += Control_MouseMove;
                c.MouseUp += Control_MouseUp;

                PanelViewPage.Controls.Add(c);
            }

            _isListBoxCurrentChanged = false;
            LoadData();
            tabControl.SelectTab(1);
        }

        void buttonPrevVal_Click(object sender, EventArgs e)
        {
            if (_indexValue == 0)
                return;

            _indexValue--;
            LoadData();
        }
        void buttonNextVal_Click(object sender, EventArgs e)
        {
            if (_indexValue == _size - 1)
                return;

            _indexValue++;
            LoadData();
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

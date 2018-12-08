using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WowCaseApp.Model;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm
    {
        void InitializeAttributePage()
        {
            _cont = new MetaDataDBContainer();

            //Table tb = new Table() { Name = "LadaChild" };
            //var tbl =(from x in _cont.TableSet where x.Name == "Lada" select x).First();
            //tbl.Tables.Add(tb);
            //tb.Tables.Add(tbl);
            //_cont.TableSet.Add(tb);

            //var a = new Attribute("Name", "String", tb);
            //_cont.AttributeSet.Add(a);
            //tb.Attributes.Add(a);

            //a = new Attribute("Count", "Int32", tb);
            //_cont.AttributeSet.Add(a);
            //tb.Attributes.Add(a);

            //_cont.SaveChanges();


            comboBoxTables.Items.Clear();

            foreach (var t in _cont.TableSet)
            {
                comboBoxTables.Items.Add(t);
            }

            if (comboBoxTables.Items.Count > 0)
            {
                comboBoxTables.SelectedIndex = 0;
                ShowAttributesInStock();
            }

        }

        void ShowAttributesInStock()
        {
            var t = (Table)comboBoxTables.SelectedItem;

            var attribs = t.Attributes.Except(listBoxCurrent.Items.Cast<Model.Attribute>().ToList()).ToList();

            listBoxStock.Items.Clear();

            foreach (var a in attribs)
                listBoxStock.Items.Add(a);
        }

        void ChangeTableComboBox()
        {
            //var list = listBoxCurrent.Items.Cast<Model.Attribute>();
            //if (!list.Any())
            //{
            //    Table table = (Table)comboBoxTables.SelectedItem;
            //    comboBoxTables.Items.Clear();

            //    foreach (var tb in _cont.TableSet)
            //    {
            //        comboBoxTables.Items.Add(tb);
            //    }
            //    comboBoxTables.SelectedItem = table;
            //    return;
            //}

            ////comboBoxTables.Select();
            //Table t = (Table)comboBoxTables.SelectedItem;
            //List<Table> tableCurrAttList = new List<Table>();
            //comboBoxTables.Items.Clear();

            //var tablelists = t.ChildTables.ToList();
            //foreach (var attr in listBoxCurrent.Items.Cast<Attribute>())
            //    tableCurrAttList.Add(attr);
            //tablelists = tablelists.Intersect(tableCurrAttList.Distinct()).ToList();
            //if (tablelists.Count == 0)
            //{
            //    tablelists = t.Tables.Intersect(_cont.TableSet).ToList();
            //    //tablelists.Add(t);
            //}
            //tablelists.Add(t);

            //foreach (var tbl in tablelists)
            //    comboBoxTables.Items.Add(tbl);

            //comboBoxTables.SelectedItem = t;
        }

        void MoveAttributesFromStockToCurrent(IEnumerable<Attribute> list)
        {
            foreach (var attr in list)
                listBoxCurrent.Items.Add(attr);
        }
        void MoveAttributesFromCurrentToStock(IEnumerable<Attribute> list)
        {
            var arr = list.ToArray();
            foreach (var attr in arr)
                listBoxCurrent.Items.Remove(attr);
        }

        private void buttonToCurrent_Click(object sender, EventArgs e)
        {
            MoveAttributesFromStockToCurrent(listBoxStock.SelectedItems.Cast<Model.Attribute>());
            listBoxStock.ClearSelected();
            listBoxStock_Click(listBoxStock, null);
            ChangeTableComboBox();
        }

        private void buttonToCurrentAll_Click(object sender, EventArgs e)
        {
            MoveAttributesFromStockToCurrent(listBoxStock.Items.Cast<Model.Attribute>());
            listBoxStock.ClearSelected();
            listBoxStock_Click(listBoxStock, null);
            ChangeTableComboBox();
        }

        private void buttonToStock_Click(object sender, EventArgs e)
        {
            MoveAttributesFromCurrentToStock(listBoxCurrent.SelectedItems.Cast<Model.Attribute>());
            listBoxCurrent.ClearSelected();
            listBoxCurrent_Click(listBoxCurrent, null);

            ChangeTableComboBox();
        }

        private void buttontoStockAll_Click(object sender, EventArgs e)
        {
            MoveAttributesFromCurrentToStock(listBoxCurrent.Items.Cast<Model.Attribute>());
            listBoxCurrent.ClearSelected();
            listBoxCurrent_Click(listBoxCurrent, null);
            ChangeTableComboBox();
        }

        private void listBoxCurrent_Click(object sender, EventArgs e)
        {
            buttonToStock.Enabled = ((ListBox)sender).SelectedItems.Count > 0;
        }

        private void listBoxStock_Click(object sender, EventArgs e)
        {
            buttonToCurrent.Enabled = ((ListBox)sender).SelectedItems.Count > 0;
        }


        private void comboBoxTables_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowAttributesInStock();
        }
    }
}

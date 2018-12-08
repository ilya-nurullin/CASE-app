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

            Table tb = new Table("LadaChild", "LadaChild");
            

            _cont.SaveChanges();


            comboBoxMainTable.Items.Clear();

            foreach (var t in _cont.TableSet)
            {
                comboBoxMainTable.Items.Add(t);
            }

            if (comboBoxMainTable.Items.Count > 0)
            {
                comboBoxMainTable.SelectedIndex = 0;
                ShowAttributesInStock();
            }

        }

        void ShowAttributesInStock()
        {
            if (comboBoxMainTable.SelectedItem ==null)
                return;

            var t = (Table)comboBoxMainTable.SelectedItem;

            var attribs = t.Attributes.Except(listBoxCurrent.Items.Cast<Model.Attribute>());

            if (comboBoxChildTable.SelectedItem == null)
                return;

            t = (Table)comboBoxChildTable.SelectedItem;

            attribs = attribs.Union(t.Attributes.Except(listBoxCurrent.Items.Cast<Model.Attribute>())).ToList();
            
            listBoxStock.Items.Clear();

            foreach (var a in attribs)
                listBoxStock.Items.Add(a);
        }

        void ChangeMainTableComboBox()
        {
            var list = listBoxCurrent.Items.Cast<Model.Attribute>();
            if (comboBoxMainTable.SelectedItem == null)
                return;

            if (!list.Any())
            {
                Table table = (Table)comboBoxMainTable.SelectedItem;
                comboBoxMainTable.Items.Clear();
                comboBoxChildTable.Items.Clear();

                foreach (var tb in _cont.TableSet)
                {
                    comboBoxMainTable.Items.Add(tb);
                }
                comboBoxMainTable.SelectedItem = table;
                return;
            }

            //comboBoxTables.Select();
            Table t = (Table)comboBoxMainTable.SelectedItem;

            List<Table> tablelists = new List<Table>();

            if (list.Except(t.Attributes).Any())
            {
            }
            else
            {
                tablelists = t.ChildTables.ToList();
            }

            comboBoxMainTable.Items.Clear();
            comboBoxChildTable.Items.Clear();
            // todo доделать

            foreach (var tbl in tablelists)
                comboBoxChildTable.Items.Add(tbl);

            comboBoxMainTable.SelectedItem = t;
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

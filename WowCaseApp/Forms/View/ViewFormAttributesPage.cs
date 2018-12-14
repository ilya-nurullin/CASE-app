using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WowCaseApp.Model;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm
    {
        void InitializeAttributePage()
        {
            //Table tb = new Table("LadaChild", "LadaChild");

            //_cont.TableSet.Add(tb);

            //_cont.SaveChanges();
            
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

            if (comboBoxChildTable.SelectedItem != null)
            {
                t = (Table) comboBoxChildTable.SelectedItem;

                attribs = attribs.Union(t.Attributes.Except(listBoxCurrent.Items.Cast<Model.Attribute>())).ToList();
            }

            listBoxStock.Items.Clear();

            foreach (var a in attribs)
                listBoxStock.Items.Add(a);
        }

        void ChangeTableComboBox()
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

                comboBoxMainTable.Text = "";
                comboBoxChildTable.Text = "";

                comboBoxMainTable.SelectedItem = table;
                return;
            }

            Table t = (Table)comboBoxMainTable.SelectedItem;

            List<Table> childTablelists = new List<Table>();

            // есть атрибуты кроме главной таблицы
            if (list.Except(t.Attributes).Any())
            {
                var childAttribute = list.Except(t.Attributes).First();

                Table chT= new Table();

                foreach (var tChild in t.ChildTables)
                {
                    if (tChild.Attributes.Contains(childAttribute))
                        chT = tChild;
                }

                // Если атрибуты только не главной таблицы
                if (!list.Intersect(t.Attributes).Any())
                {
                    t = chT;
                    childTablelists = t.ChildTables.ToList();
                }
                else
                {
                    childTablelists.Add(chT);
                }

            }
            else
            {
                childTablelists = t.ChildTables.ToList();
            }

            comboBoxMainTable.Items.Clear();
            comboBoxChildTable.Items.Clear();

            comboBoxMainTable.Text = "";
            comboBoxChildTable.Text = "";

            comboBoxMainTable.Items.Add(t);
            foreach (var tbl in childTablelists)
                comboBoxChildTable.Items.Add(tbl);


            comboBoxMainTable.SelectedItem = t;
            comboBoxChildTable.SelectedIndex = childTablelists.Any()?0:-1;

            ShowAttributesInStock();
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
            listBoxStock_Click(null, null);
            ChangeTableComboBox();
        }
        private void buttonToCurrentAll_Click(object sender, EventArgs e)
        {
            MoveAttributesFromStockToCurrent(listBoxStock.Items.Cast<Model.Attribute>());
            listBoxStock.ClearSelected();
            listBoxStock_Click(null, null);
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
            buttonToStock.Enabled = listBoxCurrent.SelectedItems.Count > 0;

            UpdateUpDownButtons();
        }
        private void listBoxStock_Click(object sender, EventArgs e)
        {
            buttonToCurrent.Enabled = listBoxStock.SelectedItems.Count > 0;
        }
        
        private void comboBoxTables_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowAttributesInStock();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            MoveItemInCurrentListBox(-1);
            UpdateUpDownButtons();
        }
        private void downButton_Click(object sender, EventArgs e)
        {
            MoveItemInCurrentListBox(1);
            UpdateUpDownButtons();
        }

        private void UpdateUpDownButtons()
        {
            int max = -1, min = listBoxCurrent.Items.Count;
            foreach (var si in listBoxCurrent.SelectedItems)
            {
                int index = listBoxCurrent.Items.IndexOf(si);
                max = index > max ? index : max;
                min = index < min ? index : min;
            }
            upButton.Enabled = listBoxCurrent.SelectedItems.Count > 0 && min > 0;
            downButton.Enabled = listBoxCurrent.SelectedItems.Count > 0 && max < listBoxCurrent.Items.Count - 1;
        }

        private void MoveItemInCurrentListBox(int direction)
        {
            if (listBoxCurrent.SelectedItem == null || listBoxCurrent.SelectedIndex < 0)
                return;

            var arr = new object[listBoxCurrent.SelectedItems.Count];
            listBoxCurrent.SelectedItems.CopyTo(arr, 0);
            if (direction > 0)
                arr = arr.Reverse().ToArray();
            foreach (var selectedItem in arr)
            {
                int newIndex = listBoxCurrent.Items.IndexOf(selectedItem) + direction;

                if (newIndex < 0 || newIndex >= listBoxCurrent.Items.Count)
                    return; 
                
                listBoxCurrent.Items.Remove(selectedItem);
                listBoxCurrent.Items.Insert(newIndex, selectedItem);
                listBoxCurrent.SetSelected(newIndex, true);
            }
        }
    }
}

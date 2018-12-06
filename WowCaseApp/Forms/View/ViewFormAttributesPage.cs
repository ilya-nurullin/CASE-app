using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowCaseApp.Model;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm
    {
        void ShowAttributesInStock()
        {
            var t = (Table)comboBoxTables.SelectedItem;

            var attribs = t.Attributes.Except(listBoxCurrent.Items.Cast<Model.Attribute>().ToList()).ToList();

            listBoxStock.Items.Clear();

            foreach (var a in attribs)
                listBoxStock.Items.Add(a);
        }


        void MoveAttributesFromStockToCurrent(IEnumerable<Model.Attribute> list)
        {
            foreach (var attr in list)
            {
                listBoxStock.Items.Remove(attr);
                listBoxCurrent.Items.Add(attr);
            }
        }
        void MoveAttributesFromCurrentToStock(IEnumerable<Model.Attribute> list)
        {
            foreach (var attr in list)
            {
                listBoxCurrent.Items.Remove(attr);
                listBoxStock.Items.Add(attr);
            }
        }

        private void buttonToCurrent_Click(object sender, EventArgs e)
        {
            MoveAttributesFromStockToCurrent(listBoxStock.SelectedItems.Cast<Model.Attribute>());
        }

        private void buttonToCurrentAll_Click(object sender, EventArgs e)
        {
            MoveAttributesFromStockToCurrent(listBoxStock.Items.Cast<Model.Attribute>());
        }

        private void buttonToStock_Click(object sender, EventArgs e)
        {
            MoveAttributesFromCurrentToStock(listBoxCurrent.SelectedItems.Cast<Model.Attribute>());
        }

        private void buttontoStockAll_Click(object sender, EventArgs e)
        {
            MoveAttributesFromCurrentToStock(listBoxCurrent.Items.Cast<Model.Attribute>());
        }
    }
}

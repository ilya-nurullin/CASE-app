using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowCaseApp.Model;
using Form = System.Windows.Forms.Form;
using Attribute = WowCaseApp.Model.Attribute;

namespace WowCaseApp
{
    public partial class ViewForm : Form
    {
        private MetaDataDBContainer _cont;


        public ViewForm(MetaDataDBContainer cont)
        {
            InitializeComponent();

            _cont = cont;

            Initialize();
        }

        void Initialize()
        {
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


        //----------------------------Аттрибуты---------------------------------------\\

        void ShowAttributesInStock()
        {
            var t = (Table) comboBoxTables.SelectedItem;

            var attribs = t.Attributes.Except(listBoxCurrent.Items.Cast<Attribute>().ToList()).ToList();

            listBoxStock.Items.Clear();

            foreach (var a in attribs)
                listBoxStock.Items.Add(a);
        }
        

        void MoveAttributesFromStockToCurrent(IEnumerable<Attribute> list)
        {
            foreach (var attr in list)
            {
                listBoxStock.Items.Remove(attr);
                listBoxCurrent.Items.Add(attr);
            }
        }
        void MoveAttributesFromCurrentToStock(IEnumerable<Attribute> list)
        {
            foreach (var attr in list)
            {
                listBoxCurrent.Items.Remove(attr);
                listBoxStock.Items.Add(attr);
            }
        }

        private void buttonToCurrent_Click(object sender, EventArgs e)
        {
            MoveAttributesFromStockToCurrent(listBoxStock.SelectedItems.Cast<Attribute>());
        }

        private void buttonToCurrentAll_Click(object sender, EventArgs e)
        {
            MoveAttributesFromStockToCurrent(listBoxStock.Items.Cast<Attribute>());
        }

        private void buttonToStock_Click(object sender, EventArgs e)
        {
            MoveAttributesFromCurrentToStock(listBoxCurrent.SelectedItems.Cast<Attribute>());
        }

        private void buttontoStockAll_Click(object sender, EventArgs e)
        {
            MoveAttributesFromCurrentToStock(listBoxCurrent.Items.Cast<Attribute>());
        }

        //----------------------------Аттрибуты---------------------------------------\\
    }
}

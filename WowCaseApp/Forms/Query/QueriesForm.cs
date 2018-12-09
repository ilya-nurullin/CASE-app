using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WowCaseApp.Model;

namespace WowCaseApp
{
    public partial class QueriesForm : Form
    {
        private MetaDataDBContainer _cont = new MetaDataDBContainer();
        public QueriesForm()
        {
            InitializeComponent();
            cmbTables.SelectedIndex = 0;
            // cmbTables.DataSource = _cont.TableSet;
            // cmbItems1.DataSource = listBoxSelected.Items;
            /*cmbJoins.SelectedIndex = 0;
            cmbOperations.SelectedIndex = 0;*/
        }
        private void UpdateDataSourse()
        {
            cmbItems1.DataSource = null;
            cmbItems1.DataSource = listBoxSelected.Items;
            cmbItems2.DataSource = null;
            cmbItems2.DataSource = listBoxSelected.Items;
            cmbItems3.DataSource = null;
            cmbItems3.DataSource = listBoxSelected.Items;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listBoxSelected.Items.Clear();


            UpdateDataSourse();



        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            listBoxSelected.Items.AddRangeDistinct(listBoxAvailable.Items, cmbTables.SelectedItem.ToString());
            UpdateDataSourse();



        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxSelected.SelectedItem != null)
                listBoxSelected.Items.Remove(listBoxSelected.SelectedItem);
            UpdateDataSourse();



        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            try
            {

                var a = cmbTables.SelectedItem.ToString() + "." + listBoxAvailable.SelectedItem.ToString();

                if (listBoxAvailable.SelectedItem != null && cmbTables.SelectedItem != null && !listBoxSelected.Items.Contains(a))
                {
                    listBoxSelected.Items.Add(a);
                }

            }
            catch { }

            UpdateDataSourse();



        }

        private void btnAddNewJoin_Click(object sender, EventArgs e)
        {


        }


        private void CreateQuery_Click(object sender, EventArgs e)
        {
            try
            {
                var elementsForQuery = listBoxSelected.Items.Cast<string>().ToArray();


                string Tables = String.Join(",", elementsForQuery.Select(x => x.Substring(0, x.IndexOf("."))).Distinct());

                string Elements = String.Join(",", elementsForQuery);

                string Where1 = cmbItems1.Text.ToString() +" "+ cmbOperations1.Text.ToString() +" "+ txbValues1.Text.ToString() + " "+ cmbJoins1.Text.ToString()  ;
                string Where2 = cmbItems2.Text.ToString() + " " + cmbOperations2.Text.ToString() + " " + txbValues2.Text.ToString() + " " + cmbJoins2.Text.ToString();
                string Where3 = cmbItems3.Text.ToString() + " " + cmbOperations3.Text.ToString() + " " + txbValues3.Text.ToString() + " " + cmbJoins3.Text.ToString();



                string Select = $"SELECT {Elements} FROM {Tables} WHERE {Where1} {Where2} {Where3}";
                
                MessageBox.Show(Select);
            }
            catch (Exception a)
            {
                MessageBox.Show($"Неверный запрос. Ошибка в запросе. ");
            }
        }



    }

    public static class Extension
    {
        public static void AddRangeDistinct(this ListBox.ObjectCollection lb, ListBox.ObjectCollection lbAdd, string SelectedTables)
        {
            foreach (var temp in lbAdd)
            {

                var a = SelectedTables + "." + temp.ToString();
                if (!lb.Contains(a))
                {


                    lb.Add(a);
                }
            }

        }
    }
    
}

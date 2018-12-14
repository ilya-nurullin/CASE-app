using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WowCaseApp.Forms.Query;
using WowCaseApp.Model;

namespace WowCaseApp
{
    public partial class QueriesForm : Form
    {
        private readonly MetaDataDBContainer metaDbContainer;
        private readonly SqlConnection dbConnection;
        private static readonly ILog log = LogManager.GetLogger(typeof(NewTableForm));
        private readonly SqlExecutor sqlExecutor;

        public QueriesForm(MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection)
        {
            InitializeComponent();
          //  cmbTables.SelectedIndex = 0;
            log.Debug("QueriesForm opened");
            this.metaDbContainer = metaDataDbContainer;
            this.dbConnection = dbConnection;
            sqlExecutor = new SqlExecutor(dbConnection);
            cmbTables.DataSource = metaDataDbContainer.TableSet.Select(x=>x.Name).ToList();
            cmbTables.SelectedIndex = 0;
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

                //Convert TableNames to TableRealNames as String
                string Tables = String.Join(",", elementsForQuery.Select(x => x.Substring(0, x.IndexOf("."))).Distinct().ToList().Select(c => { c = metaDbContainer.TableSet.Where(y => y.Name == c).Select(z => z.RealName).FirstOrDefault(); return c; }).ToList());



                //Convert TableName.Attrib to TableRealName.AttribRealName as String
                string Elements = String.Join(",", elementsForQuery.Distinct().ToList().Select(c => { c = metaDbContainer.TableSet.Where(y => y.Name == c.Substring(0, c.IndexOf("."))).Select(z => z.RealName).FirstOrDefault()+"."+ metaDbContainer.AttributeSet.Where(y => y.Name == c.Substring(c.IndexOf(".")+1)).Select(z => z.RealName).FirstOrDefault(); return c; }).ToList());




                /* string Where1 = cmbItems1.Text.ToString() +" "+ cmbOperations1.Text.ToString() +" "+ txbValues1.Text.ToString() + " "+ cmbJoins1.Text.ToString()  ;
                 string Where2 = cmbItems2.Text.ToString() + " " + cmbOperations2.Text.ToString() + " " + txbValues2.Text.ToString() + " " + cmbJoins2.Text.ToString();
                 string Where3 = cmbItems3.Text.ToString() + " " + cmbOperations3.Text.ToString() + " " + txbValues3.Text.ToString() + " " + cmbJoins3.Text.ToString();

     */

                //With WHERE Clause
                // string Select = $"SELECT {Elements} FROM {Tables} WHERE {Where1} {Where2} {Where3}";

                //Without WHERE Clause
                 string Select =$"SELECT {Elements} FROM {Tables}";
                
                
              // HandMade Tryier
              //  string Select = $"SELECT t14122018_105044.col1 FROM t14122018_105044";

                //sqlExecutor.ExecuteNonQuery(Select);
                var cmd = new SqlCommand(Select, dbConnection);
                var readed = cmd.ExecuteReader();
                while (readed.Read())
                {
                    MessageBox.Show(readed[0].ToString());
                }
                MessageBox.Show(Select);

            }
            catch (Exception a)
            {
                MessageBox.Show($"Неверный запрос. Ошибка в запросе. ", a.InnerException.ToString());
            }
        }

        private void btnAddJoin_Click(object sender, EventArgs e)
        {
            var elementsForQuery = listBoxSelected.Items.Cast<string>().ToArray();


            string Tables = String.Join(",", elementsForQuery.Select(x => x.Substring(0, x.IndexOf("."))).Distinct());
            JoinForm joinForm = new JoinForm(Tables);
            joinForm.ShowDialog();
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAvailable.DataSource = metaDbContainer.TableSet.Where(x => x.Name == cmbTables.SelectedItem).FirstOrDefault().Attributes.Select(y=>y.Name).ToList();
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

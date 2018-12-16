using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            cmbTables.DataSource = metaDataDbContainer.TableSet.Select(x => x.Name).ToList();
            cmbTables.SelectedIndex = 0;

            btnAddJoin.Enabled = false; CreateQuery.Enabled = false;


        }
        private void UpdateDataSourse()
        {
            var items = listBoxSelected.Items;
            cmbItems1.DataSource = new BindingSource(items, string.Empty);
            cmbItems2.DataSource = new BindingSource(items, string.Empty);
            cmbItems3.DataSource = new BindingSource(items, string.Empty);

            if (listBoxSelected.Items.Count != 0)
            {
                if (listBoxSelected.Items.Count > 1)
                { btnAddJoin.Enabled = true; }
                CreateQuery.Enabled = true;
            }
            else { btnAddJoin.Enabled = false; CreateQuery.Enabled = false; }
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




        private void CreateQuery_Click(object sender, EventArgs e)
        {
            try
            {

                //Convert TableNames to TableRealNames as String
                string Tables = listBoxSelected.getRealNamesTables(metaDbContainer);



                //Convert TableName.Attrib to TableRealName.AttribRealName as String
                string Elements = listBoxSelected.getRealNamesAttributes(metaDbContainer);


                string Where1 = cmbItems1.getRealNameTableAttribute(metaDbContainer) + " " + cmbOperations1.Text.ToString() + " " + txbValues1.Text.ToString() + " " + cmbJoins1.Text.ToString();
                string Where2 = cmbItems2.getRealNameTableAttribute(metaDbContainer) + " " + cmbOperations2.Text.ToString() + " " + txbValues2.Text.ToString() + " " + cmbJoins2.Text.ToString();
                string Where3 = cmbItems3.getRealNameTableAttribute(metaDbContainer) + " " + cmbOperations3.Text.ToString() + " " + txbValues3.Text.ToString() + " " + cmbJoins3.Text.ToString();

                //All joined tables . Distinct()
                string[] JoinedTables = null;

                string[] FactTables = null;


                string Select = $"SELECT {Elements} ";
                if (listBoxJoins.Items.Count != 0)
                {

                    JoinedTables = listBoxJoins.Items.Cast<string>().Select(x => (/*x.Split(' ')[3].Substring(0, x.Split(' ')[3].IndexOf('.')) + "|" +*/x.Split(' ')[5].Substring(0, x.Split(' ')[5].IndexOf('.'))).Split('|')).ToArray()[0].getRealNamesTables(metaDbContainer).Split(',');// + ","+x.Split(' ')[5].Take(x.Split(' ')[5].IndexOf(".")).ToString()).ToArray();

                    //Tables without joins
                    FactTables = Tables.Split(',').Except(JoinedTables).ToArray();

                }

                //WITHOUT JOINS
                if (listBoxJoins.Items.Count == 0)
                {
                    Select += $"FROM { Tables}";
                }
                //JOINS ONLY
                else if (FactTables.Count() == 0)
                {
                    Select += $"FROM { listBoxJoins.getJoins(metaDbContainer).joinToString()}";

                }
                //JOINS + JUST TABLE SELECT
                else
                {
                    //туть может быть ошибка

                    Select += $"FROM {FactTables.joinToString()} { listBoxJoins.getJoins(metaDbContainer).joinToString(" ")}";
                }


                if (txbValues1.Text != string.Empty || txbValues2.Text != string.Empty || txbValues3.Text != string.Empty)
                {

                    string pattern = @"[>|>|=|!|IS]";
                    Regex regex = new Regex(pattern);
                    if (!Regex.IsMatch(Where1, pattern, RegexOptions.IgnoreCase))
                    { Where1 = ""; }
                    if (!Regex.IsMatch(Where2, pattern, RegexOptions.IgnoreCase))
                    { Where2 = ""; }
                    if (!Regex.IsMatch(Where3, pattern, RegexOptions.IgnoreCase))
                    { Where3 = ""; }
                    Select += $" WHERE {Where1} {Where2} {Where3}";

                }

                //Without WHERE Clause
                //
                // string Select =$"SELECT {Elements} FROM {Tables}";


                // HandMade Tryier
                //
                //  string Select = $"SELECT t14122018_105044.col1 FROM t14122018_105044";

                //If need to read by ExecReader
                //
                //var cmd = new SqlCommand(Select, dbConnection);
                //var readed = cmd.ExecuteReader();
                //   foreach (readed.FieldCount)
                //while (readed.Read())
                //{
                //    MessageBox.Show(readed[0].ToString());
                //}
                //MessageBox.Show(Select);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(Select, dbConnection);
                da.Fill(ds);

                dgvResult.DataSource = ds.Tables[0];
                tabPageResult.Show();
                tabControlQuery.SelectedIndex = 1;


            }
            catch (Exception a)
            {
                MessageBox.Show($"Неверный запрос. Ошибка в запросе. ");
            }
        }

        private void btnAddJoin_Click(object sender, EventArgs e)
        {

            var elementsForQuery = listBoxSelected.Items.Cast<string>().ToArray();


            string Tables = String.Join(",", elementsForQuery.Select(x => x.Substring(0, x.IndexOf("."))).Distinct());
            JoinForm joinForm = new JoinForm(metaDbContainer, dbConnection, Tables);
            joinForm.ShowDialog();

            if (joinForm.Status)
            {
                string newJoin = $"{joinForm.getOp} : {joinForm.getT1String}.{joinForm.getA1String} {joinForm.getOn} {joinForm.getT2String}.{joinForm.getA2String}";
                listBoxJoins.Items.Add(newJoin);

            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAvailable.DataSource = metaDbContainer.TableSet.Where(x => x.Name == cmbTables.SelectedItem.ToString()).FirstOrDefault().Attributes.Select(y => y.Name).ToList();
        }

        private void Query_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteJoin_Click(object sender, EventArgs e)
        {
            if (listBoxJoins.SelectedItem != null)
            {
                listBoxJoins.Items.Remove(listBoxJoins.SelectedItem);
            }
        }

        private void btnClearJoin_Click(object sender, EventArgs e)
        {
            listBoxJoins.Items.Clear();

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

        public static string getRealNameTable(this string Name, MetaDataDBContainer metaDbContainer)
        {
            return metaDbContainer.TableSet.Where(x => x.Name == Name).Select(y => y.RealName).FirstOrDefault();
        }
        public static string getRealNameAttribute(this string Name, MetaDataDBContainer metaDbContainer)
        {
            return metaDbContainer.AttributeSet.Where(x => x.Name == Name).Select(y => y.RealName).FirstOrDefault();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name">*table.attr*</param>
        /// <param name="metaDbContainer"></param>
        /// <returns></returns>
        public static string getRealNameTableAttribute(this string Name, MetaDataDBContainer metaDbContainer)
        {

            string table = Name.Split('.')[0];
            string attr = Name.Split('.')[1];

            return table.getRealNameTable(metaDbContainer) + "." + attr.getRealNameAttribute(metaDbContainer);
        }
        public static string getRealNamesTables(this string[] listBoxSelected, MetaDataDBContainer metaDbContainer)
        {
            var elementsForQuery = listBoxSelected;

            //Convert TableNames to TableRealNames as String
            string Tables = String.Join(",", elementsForQuery.Distinct().ToList().Select(c => { c = metaDbContainer.TableSet.Where(y => y.Name == c).Select(z => z.RealName).FirstOrDefault(); return c; }).ToList());
            return Tables;

        }
        public static string getRealNamesTables(this ListBox listBoxSelected, MetaDataDBContainer metaDbContainer)
        {
            var elementsForQuery = listBoxSelected.Items.Cast<string>().ToArray();

            //Convert TableNames to TableRealNames as String
            string Tables = String.Join(",", elementsForQuery.Select(x => x.Substring(0, x.IndexOf("."))).Distinct().ToList().Select(c => { c = metaDbContainer.TableSet.Where(y => y.Name == c).Select(z => z.RealName).FirstOrDefault(); return c; }).ToList());
            return Tables;

        }
        public static string getRealNamesAttributes(this ListBox listBoxSelected, MetaDataDBContainer metaDbContainer)
        {
            var elementsForQuery = listBoxSelected.Items.Cast<string>().ToArray();

            //Convert TableNames to TableRealNames as String
            string Elements = String.Join(",", elementsForQuery.Distinct().ToList().Select(c => { c = metaDbContainer.TableSet.Where(y => y.Name == c.Substring(0, c.IndexOf("."))).Select(z => z.RealName).FirstOrDefault() + "." + metaDbContainer.AttributeSet.Where(y => y.Name == c.Substring(c.IndexOf(".") + 1)).Select(z => z.RealName).FirstOrDefault(); return c; }).ToList());
            return Elements;

        }
        public static string getRealNameTableAttribute(this ComboBox cmbItems1, MetaDataDBContainer metaDbContainer)
        {

            string Result = metaDbContainer.TableSet.Where(y => y.Name == cmbItems1.Text.ToString().Substring(0, cmbItems1.Text.ToString().IndexOf("."))).Select(z => z.RealName).FirstOrDefault() + "." + metaDbContainer.AttributeSet.Where(y => y.Name == cmbItems1.Text.ToString().Substring(cmbItems1.Text.ToString().IndexOf(".") + 1)).Select(z => z.RealName).FirstOrDefault();


            return Result;

        }
        public static string[] getJoins(this ListBox listBoxJoins, MetaDataDBContainer metaDbContainer)
        {

            string[] Result = listBoxJoins.Items.Cast<string>().Select(x => x.Split(' ')[0] + " " + x.Split(' ')[1] + " " + String.Join("", x.Split(' ')[5].TakeWhile(sep => sep != '.')).getRealNameTable(metaDbContainer) + " ON (" + x.Split(' ')[3].getRealNameTableAttribute(metaDbContainer) + " " + x.Split(' ')[4] + " " + x.Split(' ')[5].getRealNameTableAttribute(metaDbContainer) + ")").ToArray();


            return Result;

        }
        public static string joinToString(this string[] mas, string sep = " , ")
        {
            string Result = String.Join(sep, mas);


            return Result;

        }
    }

}

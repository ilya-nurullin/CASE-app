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
        string QueryName;
        bool needToAdd = false;
        string QueryText;
        public QueriesForm(MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection, string QueryName)
        {
            
                InitializeComponent();
                //  cmbTables.SelectedIndex = 0;
                log.Debug("QueriesForm opened");
                this.metaDbContainer = metaDataDbContainer;
                this.dbConnection = dbConnection;
                sqlExecutor = new SqlExecutor(dbConnection);
                cmbTables.DataSource = metaDataDbContainer.TableSet.Select(x => x.Name).ToList();
                cmbTables.SelectedIndex = 0;
            this.QueryName = QueryName;

            needToAdd = true;
            btnAddJoin.Enabled = false; CreateQuery.Enabled = false;


        }
        public QueriesForm(MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection, string QueryName, string QueryParametrs)
        {

            InitializeComponent();
            //  cmbTables.SelectedIndex = 0;
            log.Debug("QueriesForm opened");
            this.metaDbContainer = metaDataDbContainer;
            this.dbConnection = dbConnection;
            sqlExecutor = new SqlExecutor(dbConnection);
            cmbTables.DataSource = metaDataDbContainer.TableSet.Select(x => x.Name).ToList();
            cmbTables.SelectedIndex = 0;
            this.QueryName = QueryName;
            this.QueryText = QueryParametrs;
            needToAdd = false;

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
                string Where3 = cmbItems3.getRealNameTableAttribute(metaDbContainer) + " " + cmbOperations3.Text.ToString() + " " + txbValues3.Text.ToString() + " " ;

                //All joined tables . Distinct()
                string[] JoinedTables = new string [0];

                string[] FactTables = new string[0];


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

                    string pattern = @"[>|<|=|!|IS]";
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

       

        private void QueriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Сохранить?", "Закрытие формы",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            if (result == DialogResult.Yes)
            {


                Query query = new Model.Query(this.QueryName);
                //add selected attr + joins
                var selectedAttributes = listBoxSelected.Items.Cast<string>().ToArray();
                var joinedTables = listBoxJoins.Items.Cast<string>().ToArray();

                query.QueryText = "" + string.Join(",", selectedAttributes) + "|" + string.Join(",", joinedTables);

                //add where clause
                query.QueryText += "|" + cmbItems1.SelectedIndex + "," + cmbOperations1.SelectedIndex + "," + txbValues1.Text + "," + cmbJoins1.SelectedIndex;
                query.QueryText += "|" + cmbItems2.SelectedIndex + "," + cmbOperations2.SelectedIndex + "," + txbValues2.Text + "," + cmbJoins2.SelectedIndex;
                query.QueryText += "|" + cmbItems3.SelectedIndex + "," + cmbOperations3.SelectedIndex + "," + txbValues3.Text + "," ;

                if (needToAdd)
                { metaDbContainer.QuerySet.Add(query); metaDbContainer.SaveChanges(); }

                else
                {
                    var oldQuery = metaDbContainer.QuerySet.Where(x => x.Name == query.Name).FirstOrDefault();
                    metaDbContainer.QuerySet.Remove(oldQuery);
                    metaDbContainer.QuerySet.Add(query);
                    metaDbContainer.SaveChanges();

                }

            }
            ((MainForm)Parent.Parent).LoadTreeView();

        }

        private void QueriesForm_Load(object sender, EventArgs e)
        {
            if (!this.needToAdd) { 
            var parametrs = this.QueryText.Split('|');
            if (parametrs[0] != "") listBoxSelected.Items.AddRange(parametrs[0].Split(','));
            if (parametrs[1] != "") listBoxJoins.Items.AddRange(parametrs[1].Split(','));
            UpdateDataSourse();

            var where1Val = parametrs[2].Split(',');

                if (where1Val[0] != "-1") cmbItems1.SelectedIndex =  int.Parse(where1Val[0]);
                if (where1Val[1] != "-1") cmbOperations1.SelectedIndex = int.Parse(where1Val[1]);
                txbValues1.Text = where1Val[2];
                if (where1Val[3] != "-1") cmbJoins1.SelectedIndex = int.Parse(where1Val[3]);

            var where2Val = parametrs[3].Split(',');
                if (where2Val[0] != "-1") cmbItems2.SelectedIndex = int.Parse(where2Val[0]);
                if (where2Val[1] != "-1") cmbOperations2.SelectedIndex = int.Parse(where2Val[1]);
                txbValues2.Text = where2Val[2];
                if (where2Val[3] != "-1") cmbJoins2.SelectedIndex = int.Parse(where2Val[3]);
            var where3Val = parametrs[4].Split(',');
                if (where3Val[0] != "-1") cmbItems3.SelectedIndex = int.Parse(where3Val[0]);
                if (where3Val[1] != "-1") cmbOperations3.SelectedIndex = int.Parse(where3Val[1]);
                txbValues3.Text = where3Val[2];
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

            var distinctElementsForQUery = elementsForQuery.Select(x=>  x.Substring(x.IndexOf('.')+1)).Distinct().ToArray();

       
            //Convert TableNames to TableRealNames as String
            string Elements = String.Join(",", elementsForQuery.Distinct().ToList().Select(c => { c = metaDbContainer.TableSet.Where(y => y.Name == c.Substring(0, c.IndexOf("."))).Select(z => z.RealName).FirstOrDefault() + "." + metaDbContainer.AttributeSet.Where(y => y.Name == c.Substring(c.IndexOf(".") + 1)).Select(z => z.RealName+ " as '"+ z.Name.ToString()).FirstOrDefault()+"'"; return c; }).ToList());
            if (distinctElementsForQUery.Count() != elementsForQuery.Count()) { 

            Regex r = new Regex(Regex.Escape("'") + "(.*?)" + Regex.Escape("'"));
            MatchCollection matches = r.Matches(Elements);
                
               string ElementsNew = "";
                foreach(string str in Elements.Split(','))
                {
                    var ss = elementsForQuery.Except(distinctElementsForQUery).ToArray(); //попробовать реплейснуть после точки
                    var a =r.Match(str).ToString().Replace("'","");
                    if (elementsForQuery.Except(distinctElementsForQUery).Contains(a))
                    {
                        string tmp_substr = str.Split('.')[0];
                        string tmp = metaDbContainer.TableSet.Where(x => x.RealName == tmp_substr).FirstOrDefault().Name + "." + a;
                        ElementsNew += str.Replace(a, tmp)+",";
                    }
                }

                ElementsNew = ElementsNew.Substring(0, ElementsNew.Length - 1);
                return ElementsNew;
            }
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

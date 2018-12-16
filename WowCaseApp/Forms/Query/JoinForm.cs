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
using WowCaseApp.Model;

namespace WowCaseApp.Forms.Query
{
    public partial class JoinForm : Form
    {
        private string joinString;
        private string T1String;
        private string T2String;
        private string A1String;
        private string A2String;
        private string onString;
        private string joinTypeString;
        public bool Status = false;
        public string Join
        {
            get { return joinString; }
        }
        public string getT1String
        {
            get { return T1String; }
        }
        public string getT2String
        {
            get { return T2String; }
        }
        public string getA1String
        {
            get { return A1String; }
        }
        public string getA2String
        {
            get { return A2String; }
        }
            public string getOn
        {
            get { return onString; }
        }
        public string getOp
        {
            get { return joinTypeString; }
        }
        private readonly MetaDataDBContainer metaDbContainer;
        private readonly SqlConnection dbConnection;
        List<string> selectedTables ;
        public JoinForm(MetaDataDBContainer metaDataDbContainer, SqlConnection dbConnection,string tablesFrom)
        {
            selectedTables = tablesFrom.Split(',').ToList();
            InitializeComponent();
            this.metaDbContainer = metaDataDbContainer;
            this.dbConnection = dbConnection;
            cmbT1.DataSource = new BindingSource(selectedTables, string.Empty);
            cmbT1.SelectedIndex = 0;
            cmbT2.DataSource = new BindingSource(selectedTables, string.Empty);
            cmbT2.SelectedIndex = 1;
            cmbT1.DataSource = new BindingSource(selectedTables, string.Empty);
            cmbOn.SelectedIndex = 0;
            cmbJoinTypes.SelectedIndex = 0;
        
         

        }
        private void CreateJoin_Click(object sender, EventArgs e)
        {

            // table 1 join table 2 on (atr1 <>= atr2)
            T1String = cmbT1.SelectedItem.ToString();
            joinTypeString = cmbJoinTypes.SelectedItem.ToString();
            T2String = cmbT2.SelectedItem.ToString();


            A1String = cmbA1.SelectedItem.ToString();
            onString = cmbOn.SelectedItem.ToString();
            A2String = cmbA2.SelectedItem.ToString();

            
            joinString = $"{T1String} {joinTypeString}  { T1String} ON ({A1String} {onString} {A2String})";
            Status = true;
            this.Close();

        }

        private void cmbT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbA1.DataSource = new BindingSource(metaDbContainer.TableSet.Where(x=>x.Name==cmbT1.Text ).FirstOrDefault().Attributes.Select(a=>a.Name), string.Empty);
        }

        private void cmbT2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbA2.DataSource = new BindingSource(metaDbContainer.TableSet.Where(x => x.Name == cmbT2.Text).FirstOrDefault().Attributes.Select(a => a.Name), string.Empty);

        }
    }
}

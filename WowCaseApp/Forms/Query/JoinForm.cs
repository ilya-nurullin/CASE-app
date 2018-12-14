using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowCaseApp.Forms.Query
{
    public partial class JoinForm : Form
    {

      List<string> selectedTables ;
        public JoinForm(string tablesFrom)
        {
            selectedTables = tablesFrom.Split(',').ToList();
            InitializeComponent();
            cmbT1.DataSource = selectedTables;
            cmbJoinTypes.SelectedIndex = 0;

        }
        private void CreateJoin_Click(object sender, EventArgs e)
        {

        }
    }
}

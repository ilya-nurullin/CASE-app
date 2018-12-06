using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowCaseApp
{
    public partial class QueriesForm : Form
    {
        public QueriesForm()
        {
            InitializeComponent();
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listBoxSelected.Items.Clear();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            listBoxSelected.Items.AddRangeDistinct(listBoxAvailable.Items);

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxSelected.SelectedItem != null)
                listBoxSelected.Items.Remove(listBoxSelected.SelectedItem);
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            var a = cmbTables.SelectedItem.ToString() + "." + listBoxAvailable.SelectedItem.ToString();

            if (listBoxAvailable.SelectedItem != null && !listBoxSelected.Items.Contains(a))
            {
                listBoxSelected.Items.Add(a);
            }

        }

        private void btnAddNewJoin_Click(object sender, EventArgs e)
        {
            if (this.Height <= btnAddNewJoin.Location.Y+btnAddNewJoin.Height+50) { }
     else
            btnAddNewJoin.Location = new Point(btnAddNewJoin.Location.X, btnAddNewJoin.Location.Y + 10);
            
        }
    }

    public static class Extension
    {
        public static void AddRangeDistinct(this ListBox.ObjectCollection lb, ListBox.ObjectCollection lbAdd)
        {
            foreach (var temp in lbAdd)
            {
                
                
                if (!lb.Contains(temp)) lb.Add(temp);
            }

        }
    }
}

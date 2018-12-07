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
            listBoxSelected.Items.AddRangeDistinct(listBoxAvailable.Items, cmbTables.SelectedItem.ToString());

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxSelected.SelectedItem != null)
                listBoxSelected.Items.Remove(listBoxSelected.SelectedItem);
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            try {
                var a = cmbTables.SelectedItem.ToString() + "." + listBoxAvailable.SelectedItem.ToString();

                if (listBoxAvailable.SelectedItem != null && cmbTables.SelectedItem != null && !listBoxSelected.Items.Contains(a))
                {
                    listBoxSelected.Items.Add(a);
                }
            }
            catch  { }

        }

        private void btnAddNewJoin_Click(object sender, EventArgs e)
        {
            if (this.Height <= btnAddNewJoin.Location.Y+btnAddNewJoin.Height+50) { }
     else
            {
                //GroupBox groupBoxAdded =  new GroupBox();

                //groupBoxAdded.Controls.Add(this.comboBox4);
                //groupBoxAdded.Controls.Add(this.comboBox3);
                //groupBoxAdded.Controls.Add(this.comboBox2);
                //groupBoxAdded.Controls.Add(this.comboBox1);
                //groupBoxAdded.Location = new System.Drawing.Point(57, 337);
                // groupBoxAdded.Size = new System.Drawing.Size(595, 141);
                //groupBoxAdded.TabIndex = 12;
                //groupBoxAdded.TabStop = false;
               
                //groupBoxAdded.Visible = true;
                //groupBoxAdded.Name = "groupBox"+MyGroupBox.getNewId();
                //groupBoxAdded.Text= "Добавление группировки" + MyGroupBox.id;
                //groupBoxAdded.Location=  MyGroupBox.getNewLocation();
                //this.Controls.Add(groupBoxAdded);
                
            btnAddNewJoin.Location = new Point(btnAddNewJoin.Location.X, btnAddNewJoin.Location.Y + 10);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private GroupBox CreateNewJoin()
        {
            return null;
        }

        private void CreateQuery_Click(object sender, EventArgs e)
        {
            var elementsForQuery = listBoxSelected.Items.Cast<string>().ToArray();
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
    public class MyGroupBox : GroupBox
    {
        public static int id = 0;
        public static Point curLocation= new Point(57,162);

        public static int getNewId()
        {
            return ++id;
        }
       
        public static Point getNewLocation()
        {

         
            curLocation.Y += 200;

            return curLocation;

           
        }

    }
}

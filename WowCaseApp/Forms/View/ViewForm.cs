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

namespace WowCaseApp.Forms.View
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
    }
}

using System;
using System.IO;
using System.Windows.Forms;
using log4net;
using WowCaseApp.Model;
using Form = System.Windows.Forms.Form;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MainForm));


        private MetaDataDBContainer _cont;


        public ViewForm()
        {
            InitializeComponent();

            try
            {
                InitializeAttributePage();
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка");
                log.Error(e);
                //SaveError(e);
            }
        }

        private void tabControl_Selected(object sender, System.Windows.Forms.TabControlEventArgs e)
        {
            switch (tabControl.SelectedTab.Tag)
            {
                case "Attributes":
                    InitializeAttributePage();
                    break;
                case "Form":
                    //InitializeAttributePage();
                    break;
                case "Table":
                    //InitializeAttributePage();
                    break;
            }

            
        }
    }
}

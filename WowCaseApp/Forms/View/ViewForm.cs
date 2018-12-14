using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using log4net;
using WowCaseApp.Model;
using View = WowCaseApp.Model.View;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(ViewForm));
        private static SqlConnection _dbConnection;

        private MetaDataDBContainer _cont;
        private Model.View view;


        public ViewForm()
        {
            InitializeComponent();

            try
            {
                _cont = new MetaDataDBContainer();
                view = new Model.View("NewView");
                _cont.ViewSet.Add(view);
                _cont.SaveChanges();

                InitializeAttributePage();
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка");
                _log.Error(e);
                //SaveError(e);
            }
        }

        public ViewForm(MetaDataDBContainer Container, SqlConnection dbConnection, string ViewName)
        {
            InitializeComponent();

            try
            {
                _dbConnection = dbConnection;
                _cont = Container;
                view = new Model.View(ViewName);
                _cont.ViewSet.Add(view);
                _cont.SaveChanges();

                InitializeAttributePage();
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка");
                _log.Error(e);
                //SaveError(e);
            }
        }

        public ViewForm(MetaDataDBContainer Container, SqlConnection dbConnection, Model.View View)
        {
            InitializeComponent();

            try
            {
                _dbConnection = dbConnection;
                _cont = Container;
                view = View;

                InitializeAttributePage();
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка");
                _log.Error(e);
                //SaveError(e);
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl.SelectedTab.Tag)
            {
                case "Attributes":
                    //InitializeAttributePage();
                    break;
                case "Form":
                    InitializeViewPage();
                    break;
                case "Table":
                    //InitializeAttributePage();
                    break;
            }

            
        }

        private void ViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить?", "Закрытие формы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            SavePanel();
            _cont.SaveChanges();
        }
    }
}

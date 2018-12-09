using System;
using System.IO;
using System.Windows.Forms;
using log4net;
using WowCaseApp.Model;
using View = WowCaseApp.Model.View;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ViewForm));


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
                log.Error(e);
                //SaveError(e);
            }
        }

        public ViewForm(MetaDataDBContainer Container, string ViewName)
        {
            InitializeComponent();

            try
            {
                _cont = Container;
                view = new Model.View(ViewName);
                _cont.ViewSet.Add(view);
                _cont.SaveChanges();

                InitializeAttributePage();
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка");
                log.Error(e);
                //SaveError(e);
            }
        }

        public ViewForm(MetaDataDBContainer Container, Model.View View)
        {
            InitializeComponent();

            try
            {
                _cont = Container;
                view = View;

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
    }
}

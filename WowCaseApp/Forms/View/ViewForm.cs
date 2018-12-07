using System;
using System.IO;
using System.Windows.Forms;
using WowCaseApp.Model;
using Form = System.Windows.Forms.Form;

namespace WowCaseApp.Forms.View
{
    public partial class ViewForm : Form
    {
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
                MessageBox.Show("Ошибка сохранена");
                SaveError(e);
            }
        }

        void SaveError(Exception e)
        {
            if (!Directory.Exists("./logs"))
                Directory.CreateDirectory("logs");

            DateTime now = DateTime.Now;
            string fileName = $"log-{now:dd.MM.yyyy}-{now:HH.mm.ss}.txt";

            var fs =File.Create("./logs/" + fileName);
            fs.Close();

            using (var sw = new StreamWriter("./logs/" + fileName))
            {
                sw.WriteLine(e.ToString());
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

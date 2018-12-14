using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowCaseApp.Forms
{
    public partial class GetStringForm : Form
    {
        public GetStringForm()
        {
            InitializeComponent();
            label.Text = "";
        }

        public GetStringForm(string Title, string Label):this()
        {
            this.Text = Title;
            label.Text = Label;
        }

        private string _value;

        public string Value => _value;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Trim() == "")
            {
                MessageBox.Show("Поле не может быть пустым");
                return;
            }

            _value = textBox.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

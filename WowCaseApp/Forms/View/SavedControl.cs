
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WowCaseApp.Forms.View
{
    [System.Serializable]
    enum ControlType
    {
        Control,
        Label,
        DataGridView
    }

    [System.Serializable]
    class SavedControl
    {
        public Model.Attribute Attribute;

        public ControlType Type;
        public string Value;

        public int X;
        public int Y;
        public int Width;
        public int Height;

        [NonSerialized]
        public Control Control;

        public SavedControl(Model.Attribute attribute, Control control)
        {
            Attribute = attribute;

            Control = control;

            Type = ControlType.Control;

            if (control is Label label)
            {
                Type = ControlType.Label;
                Value = label.Text;
            }

            if (control is DataGridView dgv)
            {
                Type = ControlType.DataGridView;
                Value = dgv.Name;
            }

            X = control.Location.X;
            Y = control.Location.Y;
            Width = control.Width;
            Height = control.Height;
        }

        public void Update()
        {
            X = Control.Location.X;
            Y = Control.Location.Y;
            Width = Control.Width;
            Height = Control.Height;
        }
    }

    static class SaveControlExt
    {
        public static Control toControl(this SavedControl control, string anotherType ="")
        {
            Control c = new Control();
            // {Width = control.Width, Height = control.Height, Location = new System.Drawing.Point(control.X,control.Y)}

            if (control.Type.Equals(ControlType.Label))
                return new Label()
                {
                    //Name =$"{control.Attribute.RealName}_label",
                    Text =  control.Value,
                    Width = control.Width,
                    Height = control.Height,
                    Location = new Point(control.X, control.Y)
                };
            
            if (control.Type.Equals(ControlType.DataGridView))
                return new DataGridView()
                {
                    Name = control.Value,
                    Width = control.Width,
                    Height = control.Height,
                    Location = new Point(control.X, control.Y)
                };

            string type = anotherType==""?control.Attribute.Type:anotherType;

            switch (type)
            {
                case "Автоинкремент":
                case "Целое число со знаком":
                case "Дробное число":
                    c = new TextBox();
                    break;

                case "Строка":
                case "Текст":
                    c = new TextBox();
                    break;

                case "Дата":
                case "Дата и время":
                    c = new DateTimePicker();
                    break;

                case "Да/нет":
                    c = new CheckBox();
                    break;

            }

            c.Width = control.Width;
            c.Height = control.Height;
            c.Location = new Point(control.X, control.Y);

            return c;
        }
    }
}

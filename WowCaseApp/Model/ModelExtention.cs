
using System;

namespace WowCaseApp.Model
{
    partial class Attribute
    {
        public Attribute(string name, string type, Table table, bool isIndexed = false, bool isNulable = true, bool isPKey = false, bool isFKey = false)
        {
            Name = name;
            Type = type;
            Table = table;
            IsIndexed = isIndexed;
            IsNullable = isNulable;
            IsPKey = isPKey;
            IsFKey = isFKey;
        }

        public override string ToString()
        {
            return $"{Table.Name}.{Name}";
        }
    }

    partial class AttributeInForm
    {
        public AttributeInForm(Attribute origin, Form form, int pointX, int pointY, int width, int height)
        {
            Origin = origin;
            Form = form;
            PointX = pointX;
            PointY = pointY;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return Origin.ToString();
        }
    }

    partial class AttributeInReport
    {
        public AttributeInReport(Attribute origin, Report report, int pointX, int pointY, int width, int height)
        {
            Origin = origin;
            Report = report;
            PointX = pointX;
            PointY = pointY;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return Origin.ToString();
        }
    }

    partial class Form
    {
        public Form(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class Query
    {
        public Query(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class Report
    {
        public Report(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class Table
    {
        public Table(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

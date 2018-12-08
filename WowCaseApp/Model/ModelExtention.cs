
using System;

namespace WowCaseApp.Model
{
    partial class Attribute
    {
        public Attribute(string name, string realname, string type, Table table, bool isIndexed = false, bool isNulable = true, bool isPKey = false, bool isFKey = false)
        {
            Name = name;
            RealName = realname;
            Type = type;
            IsIndexed = isIndexed;
            IsNullable = isNulable;
            IsPKey = isPKey;
            IsFKey = isFKey;
        }

        public override string ToString()
        {
            return $"{Name}";
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
        public Table(string name, string realname)
        {
            Name = name;
            RealName = realname;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

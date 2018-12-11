
using System;

namespace WowCaseApp.Model
{
    partial class Attribute
    {
        public Attribute() { }

        public Attribute(string name, string realname, string type, bool isIndexed = false, bool isNullable = true, bool isPKey = false, bool isFKey = false)
        {
            Name = name;
            RealName = realname;
            Type = type;
            IsIndexed = isIndexed;
            IsNullable = isNullable;
            IsPKey = isPKey;
            IsFKey = isFKey;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class View
    {
        public View() { }

        public View(string name)
        {
            Name = name;
            Data = "";
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class Query
    {
        public Query() { }

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
        public Report() { }

        public Report(string name)
        {
            Name = name;
            Data = "";
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

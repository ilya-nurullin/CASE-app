
using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void Remove(MetaDataDBContainer container, int id)
        {
            Attribute a = container.AttributeSet.Find(id);
            container.AttributeSet.Remove(a);
            container.SaveChanges();
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
            Data = new byte[0];
        }

        public static void Remove(MetaDataDBContainer container, string name)
        {
            View v = container.ViewSet.First(x => x.Name == name);
            container.ViewSet.Remove(v);
            container.SaveChanges();
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

        public static void Remove(MetaDataDBContainer container, string name)
        {
            Query q = container.QuerySet.First(x => x.Name == name);
            container.QuerySet.Remove(q);
            container.SaveChanges();
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
            Data = new byte[0];
        }

        public static void Remove(MetaDataDBContainer container, string name)
        {
            Report r = container.ReportSet.First(x => x.Name == name);
            container.ReportSet.Remove(r);
            container.SaveChanges();
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
            Attributes = new List<Attribute>();
            ChildTables = new List<Table>();
            ParentTables = new List<Table>();
        }

        public static void Remove(MetaDataDBContainer container, string name)
        {
            Table table = container.TableSet.First(x => x.RealName == name);

            var attr = table.Attributes.ToArray();

            foreach (var a in attr)
            {
                Attribute.Remove(container,a.Id);
            }

            foreach (var t in table.ChildTables.Union(table.ParentTables))
            {
                t.ChildTables.Remove(t);
                t.ParentTables.Remove(t);
            }

            container.TableSet.Remove(table);
            container.SaveChanges();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

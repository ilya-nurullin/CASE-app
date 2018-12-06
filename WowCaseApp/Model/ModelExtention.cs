using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowCaseApp.Model
{
    partial class Attribute
    {
        public override string ToString()
        {
            return $"{Table.Name}.{Name}";
        }
    }

    partial class AttributeInForm
    {
        public override string ToString()
        {
            return Origin.ToString();
        }
    }

    partial class AttributeInReport
    {
        public override string ToString()
        {
            return Origin.ToString();
        }
    }

    partial class Form
    {
        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class Query
    {
        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class Report
    {
        public override string ToString()
        {
            return $"{Name}";
        }
    }

    partial class Table
    {
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

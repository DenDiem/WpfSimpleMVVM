using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSimpleMVVM.Exeptions
{
    class DateExeption : ArgumentException
    {
        public string Value { get; }
        public DateExeption(string message, string val)
            : base(message)
        {
            Value = val;
        }
    }
}

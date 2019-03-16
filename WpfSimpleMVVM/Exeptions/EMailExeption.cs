using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSimpleMVVM.Exeptions
{
    class EMailExeption : ArgumentException
    {
        public EMailExeption(string message)
            : base(message)
        {

        }
    }
}

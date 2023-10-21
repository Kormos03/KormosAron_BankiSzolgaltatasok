using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public abstract class BankiSzolgaltatas
    {
        public Tulajdonos tulajdonos;
        protected BankiSzolgaltatas(Tulajdonos tulajdonos)
        {
            Tulajdonos = tulajdonos;
        }

        public Tulajdonos Tulajdonos { get; }
    }
}

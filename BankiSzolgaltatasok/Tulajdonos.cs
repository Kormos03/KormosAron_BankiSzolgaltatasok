using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public sealed class Tulajdonos      //sealed: nem lehet származtatni
    {
        private string nev;

        public Tulajdonos(string nev)
        {
            Nev = nev;
        }

        public string Nev { get => nev; set => nev = value; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class HitelSzamla : Szamla
    {
        private double hitelKeret;
        public HitelSzamla(Tulajdonos tulajdonos, double hitelkeret) : base(tulajdonos)
        {
            this.hitelKeret = hitelkeret;
        }

        public double HitelKeret { get => hitelKeret; }

        public override bool Kivesz(int osszeg)
        {
            if (hitelKeret >= osszeg)
            {
                this.AktualisEgyenleg -= osszeg;
                return true;
            }
            else
            {
                return false;
                throw new Exception("Nem sikerült a felvétel!");
            }
        }
    }
}
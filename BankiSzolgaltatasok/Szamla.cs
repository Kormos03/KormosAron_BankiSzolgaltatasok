using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Szamla : BankiSzolgaltatas
    {
        protected double aktualisEgyenleg;
        private Szamla szamla;
        public Szamla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
            this.tulajdonos = tulajdonos;
            Szamla szamla = new Szamla(tulajdonos);
        }

        public double AktualisEgyenleg { get => aktualisEgyenleg; set => aktualisEgyenleg = value; }

        public double Befizet(int osszeg)
        {
            return AktualisEgyenleg + osszeg;
        }

        public virtual bool Kivesz(int osszeg)
        {
            return true;
        }

        public Kartya UjKartya(string leendokartyaszam)
        {
            Kartya kartya = new Kartya(this.tulajdonos,this.szamla,leendokartyaszam);
            return kartya;
        }
    }
}

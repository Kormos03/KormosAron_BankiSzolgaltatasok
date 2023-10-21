using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Kartya : BankiSzolgaltatas
    {
        private string kartyaSzam;
        private Szamla mogottesSzamla;
        
        public Kartya(Tulajdonos tulajdonos, Szamla szamla, string kartyaszam) : base(tulajdonos)
        {
            this.kartyaSzam = kartyaszam;
           mogottesSzamla = new Szamla(tulajdonos);
        }

        public string KartyaSzam { get => kartyaSzam;}
        public Szamla MogottesSzamla { get => mogottesSzamla;}

        public bool Vasarlas(int osszeg)
        {
            if (MogottesSzamla.AktualisEgyenleg >= osszeg)
            {
                MogottesSzamla.AktualisEgyenleg -= osszeg;
                return true;
            }
            else
            {
                Console.WriteLine("Sikertelen kivétel");
                return false;
            }
        }
    }
}

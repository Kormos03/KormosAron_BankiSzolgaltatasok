using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Bank
    {
        private List<Szamla> szamlak = new List<Szamla>();
        public double OsszHitelkeret
        {
            get 
            {
                double osszeg = 0;

                foreach (Szamla szamla in szamlak)
                {
                    if (szamla is HitelSzamla hitelSzamla)
                    {
                        osszeg += hitelSzamla.HitelKeret;
                    }
                }

                return osszeg;
            }
        }

        public Szamla SzamlaNyitas(Tulajdonos tulajdonos, double hitelkeret)
        {
            if(hitelkeret < 0)
            {
                throw new ArgumentException("A hitelkeret nem lehet negatív");
            }
            else if(hitelkeret > 0)
            {
                HitelSzamla hitelszamla = new HitelSzamla(tulajdonos, hitelkeret);
                szamlak.Add(hitelszamla);
                return hitelszamla;
            }
            else
            {
                MegtakaritasiSzamla megtakaritasiszamla = new MegtakaritasiSzamla(tulajdonos);
                szamlak.Add(megtakaritasiszamla);
                return megtakaritasiszamla;
            }
        }

        public double GetOsszEgyenleg(Tulajdonos tulajdonos)
        {
            double osszeg = 0;
            foreach(Szamla szamla in szamlak)
            {
                if(szamla.Tulajdonos == tulajdonos)
                {
                    osszeg += szamla.AktualisEgyenleg;
                }
            }
            return osszeg;
        }

        public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos) 
        {
            Szamla legnagyobb = new Szamla(tulajdonos);
            foreach(Szamla szamla in szamlak)
            {
                if(szamla.tulajdonos == tulajdonos && szamla.AktualisEgyenleg > legnagyobb.AktualisEgyenleg)
                {
                    legnagyobb = szamla;
                }
            }
            return legnagyobb;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class MegtakaritasiSzamla : Szamla
    {
        private double kamat;
        public static double alapKamat = 1.1; 
        public MegtakaritasiSzamla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
            Kamat = alapKamat;
            Szamla szamla = new Szamla(tulajdonos);
        }

        public double Kamat { get => kamat; set => kamat = value; }

        public override bool Kivesz(int osszeg)
        {
            if (AktualisEgyenleg > osszeg)
            {
                Console.WriteLine("Sikeres kivét");
                AktualisEgyenleg -= osszeg;
                return true;
            }
            else { Console.WriteLine("Sikertelen kivétel"); return false; }
        }

        public void KamatJovairas()
        {
            AktualisEgyenleg *= Kamat;
        }

    }
}

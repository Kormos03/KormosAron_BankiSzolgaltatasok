namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank();
            Tulajdonos tulajdonos = new Tulajdonos("József Markusz");

            Szamla szamla1 = bank.SzamlaNyitas(tulajdonos, 0);
            Szamla szamla2 = bank.SzamlaNyitas(tulajdonos, 1); 
            Szamla szamla3 = bank.SzamlaNyitas(tulajdonos, 0);
            Szamla szamla4 = bank.SzamlaNyitas(tulajdonos, 1);

            szamla1.Befizet(15000);
            szamla2.Befizet(10000);
            szamla3.Befizet(30000);
            szamla4.Befizet(35000);

            bank.GetOsszEgyenleg(tulajdonos);
            bank.GetLegnagyobbEgyenleguSzamla(tulajdonos);
            Console.WriteLine(bank.ToString());
        }
    }
}
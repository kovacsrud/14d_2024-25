namespace Szovegek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Valami,bármi,akármi";
            // Tartalmazás vizsgálata
            Console.WriteLine(szoveg.Contains("ala"));

            if (szoveg.Contains("alax"))
            {
                int lokalis = 13;
                Console.WriteLine("Tartalmazza");
                Console.WriteLine(lokalis);
            } else
            {
                Console.WriteLine("Nem tartalmazza");
            }

            //Kezdete, vége
            Console.WriteLine(szoveg.StartsWith("Val"));
            Console.WriteLine(szoveg.EndsWith("mi"));

            //Karakterek cseréje
            Console.WriteLine(szoveg.Replace('i','y'));
            Console.WriteLine(szoveg.Replace(",",""));

            //Szövegrész kiemelés
            Console.WriteLine(szoveg.Substring(0,3));

            var datum = "2011.03.28";

            var ev = datum.Substring(0, 4);
            var honap=datum.Substring(5,2);
            var nap=datum.Substring(8,2);

            Console.WriteLine($"Ev:{ev},honap:{honap},nap:{nap}");

            var datumElemek = datum.Split('.');

            Console.WriteLine($"Ev:{datumElemek[0]},honap:{datumElemek[1]},nap:{datumElemek[2]}");

            Console.WriteLine(szoveg.ToLower());
            Console.WriteLine(szoveg.ToUpper());

            string szoveg1 = "ValamI";
            string szoveg2 = "vAlaMi";

            if (szoveg1.ToLower()==szoveg2.ToLower())
            {
                Console.WriteLine("Egyenlőek");
            }
            else
            {
                Console.WriteLine("Nem egyenlőek");
            }


        }
    }
}
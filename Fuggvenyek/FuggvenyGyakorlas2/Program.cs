namespace FuggvenyGyakorlas2
{
    internal class Program
    {
        public static double KmhToMs(double kmh)
        {
            return kmh / 3.6;
        }

        public static string Domain(string domain,int szint)
        {
            var szintek=domain.Split('.');
            //Array.Reverse(szintek);
            if (szint>szintek.Length || szint<1 )
            {
                return "Nincs ilyen szint";
            } else
            {
                return szintek[szintek.Length-szint];
            }

        }
        static void Main(string[] args)
        {
            //Írjon függvényt, ami a km/h-ban megadott sebességet átszámolja m/s-ba!
            double sebesseg = 87.67;

            Console.WriteLine(KmhToMs(sebesseg));

            //Írjon függvényt, ami celsius fokban értett hőmérsékletet átvált fahrenheit fokra! F=(C*1.8)+32
            //Írjon függvényt, ami fahrenheit fokban értett hőmérsékletet átvált celsius fokra! C=(F-32)/1.8

            //Írjon függvényt, amelyik egy domain nevet kap paraméterként, valamint egy számot. A szám azt fogja megadni, hogy melyik szintű domain nevet adja vissza a függvény.
            //pl. taszi.edupage.org  -org a top level domain(1), edupage(2), taszi(3)
            //Ha olyan szintet adnak meg, ami nincs, akkor a visszatérési érték "Nincs ilyen szint" szöveg legyen!


            Console.WriteLine(Domain("taszi.edupage.org", 0));
            Console.WriteLine(Domain("taszi.edupage.org",1));
            Console.WriteLine(Domain("taszi.edupage.org", 2));
            Console.WriteLine(Domain("taszi.edupage.org", 3));
            Console.WriteLine(Domain("taszi.edupage.org", 4));



        }
    }
}
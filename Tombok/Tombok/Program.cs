namespace Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tömbök 
            //A tömb azonos típusú adatokat tartalmazó adatszerkezet. Deklaráláskor meg kell adni az elemek számát, ez később már nem változtatható.
            //5 elemű tömb, deklaráláskor csak az elemek számát adjuk meg
            int[] szamok = new int[5];

            Random rand= new Random();

            //Az elemek felsorolásával is létrehozhatunk tömböt
            int[] szamok2 = { 12, 45, 67, 89, 12, 99, 116 };

            //Console.WriteLine(szamok[2]);
            //Console.WriteLine(szamok2[2]);

            //szamok[2] = 111;
            //szamok2[3] = 344;

            //Console.WriteLine(szamok[2]);
            //Console.WriteLine(szamok2[3]);

            //Ciklusok: elöltesztelő, hátultesztelő, növekményes (előírt lépésszámú)
            for(int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(10,100);
                Console.WriteLine(szamok[i]);
            }

            Console.WriteLine("------------Visszafelé---------------");
            for (int i = szamok.Length-1; i >=0; i--)
            {
                Console.WriteLine(szamok[i]);
            }

            //Elöltesztelő ciklus, amíg a belépési feltétel teljesül, addig végrehajtja a kódblokk utasításait

            int szamlalo = 0;
            while (szamlalo<szamok.Length)
            {
                Console.WriteLine(szamok[szamlalo]);
                szamlalo++;
            }

            //Visszafelé?
            szamlalo=szamok.Length-1;
            while (szamlalo>=0)
            {
                Console.WriteLine(szamok[szamlalo]);
                szamlalo--;
            }

            //Hátultesztelő ciklus
            Console.WriteLine("--------Hátultesztelő---------------");
            szamlalo = 0;
            do
            {
                Console.WriteLine(szamok[szamlalo]);
                szamlalo++;
            } while (szamlalo<szamok.Length);

            Console.WriteLine("--------Foreach---------------");
            //Foreach, nem lehet módosítani az elemeket
            foreach (int i in szamok)
            {
                Console.WriteLine(i) ;
            }

        }
    }
}
namespace Valtozok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine("C# alapok");

            // Változók
            // Egész számok
            // Nem egész (lebegőpontos)
            // Karakter
            // Szöveg
            // Logikai érték true/false

            //Egész számok méret, előjeles vagy előjel nélküli

            int elso = 112;
            Console.WriteLine(elso);
            elso = 223;
            Console.WriteLine(elso);
            int masodik = 445;
            masodik = 119;
            Console.WriteLine($"A masodik változó értéke:{masodik}");
            Console.WriteLine($"Int min:{int.MinValue}, int max:{int.MaxValue}");
            uint harmadik = 123;
            Console.WriteLine($"Uint min:{uint.MinValue}, uint max:{uint.MaxValue}");
            long negyedik = 14124344234234;
            Console.WriteLine($"Long min:{long.MinValue}, long max:{long.MaxValue}");
            Console.WriteLine($"Ulong min:{ulong.MinValue},ulong max:{ulong.MaxValue}");
            byte bajt = 255;
            Int128 nagySzam = 24342342; //előjel nélküli: UInt128
            short rovid = 6678;
            Console.WriteLine($"Short min:{short.MinValue},short max:{short.MaxValue}");

            //Nem egész, azaz lebegőpontos számok

            float lebego1 = 124.123456789123456789123456789f;
            double lebego2 = 124.123456789123456789123456789; //legtöbbet használt
            decimal lebego3 = 124.123456789123456789123456789m;


            Console.WriteLine(lebego1);
            Console.WriteLine(lebego2);
            Console.WriteLine(lebego3);

            //Karakter típus
            char karakter = 'h';

            //Logikai típus
            bool logikai = true;

            //Szöveg azaz string

            string szoveg = "Valami";
            szoveg = "Bármi";

            Console.WriteLine(szoveg[4]);
            Console.WriteLine(szoveg.Length);

            //a szöveg típus egy ún. nem megváltoztatható típus

            

        }
    }
}
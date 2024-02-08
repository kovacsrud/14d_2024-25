using System.ComponentModel;

namespace Fuggvenyek
{
    internal class Program
    {

        //Függvény overloading=> több függvényt írunk ugyanazzal a névvel, de eltérő paraméterlistával
        public static void Kiir()
        {
            //a szoveg lokális változó
            string szoveg = "Valami";
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
        }

        //public static void Kiir(string szoveg)
        //{
        //    Console.WriteLine(szoveg);
        //}

        /// <summary>
        /// A függvény a szoveg-nél megadott szoveget írja ki annyiszor amennyi a hanyszor értéke
        /// </summary>
        /// <param name="szoveg">A kíírandó szöveg</param>
        /// <param name="hanyszor">Hányszor kell kiírni a kiírandó szöveget</param>
        public static void Kiir(string szoveg,int hanyszor=3)
        {
            for (int i = 0; i < hanyszor; i++)
            {
                Console.WriteLine(szoveg);
            }
        }

        //Visszatérési értékkel rendelkező függvény
        public static int Osszead(int a,int b)
        {
            return a + b;
        }

        public static double Osszead(double a,double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //Amit itt deklarlálunk, az globális változó, az egész programban elérhető
            Kiir();
            Kiir("Paraméter", 2);
            Kiir("Valami", 2);
            Kiir("Háromszor");
            Console.WriteLine(Osszead(11.3345, 22.778));
            var osszeg = Osszead(134.789, 458.11267);
            var masikOsszeg = Osszead(201, 688);

            Console.WriteLine(osszeg);
            Console.WriteLine(masikOsszeg);

            string[] szovegek = { "Egy", "valami", "Zénó", "Opel", "Kórház utca" };
            Tomblista(szovegek);
            
            string[] masszovegek = { "Kettő", "Bármi", "Ubul", "Fiat", "autópálya" };
                        
            Tomblista(masszovegek);

            int[] szamok = { 33, 44, 89, 3345, 67, 33, 6674, 22 };

            Tomblista(szamok);

            bool[] logikai= { true, false, true, false, false };

            Tomblista(logikai);

        }

        //Generikus típus a paraméter listában
        private static void Tomblista<T>(T[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
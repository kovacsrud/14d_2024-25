namespace ErtekEsRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int c, d = 0;

            c = a++; //Először felhasználja a értékét, majd utána növeli.
            d = ++b; //Először b értékének a növelése, majd az értékadás.

            Console.WriteLine($"C:{c},D:{d}");

            int[] szamok = {12,34,23,56,79 };
            int[] szamok2 = {12,67,89,99 };

            szamok2[1] = 101;

            foreach(int i in szamok)
            {
                Console.WriteLine(i);
            }


        }
    }
}
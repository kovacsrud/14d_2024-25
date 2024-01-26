namespace Muveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 82;

            double c = (double)b / a;

            Console.WriteLine($"C értéke:{c:0.00}");

            //Maradékképzés
            c = b % a;

            Console.WriteLine($"C értéke:{c}");

            //Felhasználó input
            Console.Write("A értéke:");
            a =Convert.ToInt32(Console.ReadLine());

            Console.Write("B értéke:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Az eredmény:{a*b}");


            var szam = 233.678;


        }
    }
}
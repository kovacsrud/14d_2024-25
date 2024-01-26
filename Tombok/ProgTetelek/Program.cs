namespace ProgTetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            
            int[] szamok = new int[rand.Next(20,100+1)];
            

            for(int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-100,100+1);
            }

            //Programozási tételek megszámlálás, gyűjtés, min, max

            //Megszámlálás
            int darab = 0;
            for(int i = 0;i < szamok.Length; i++)
            {
                darab++;
            }

            Console.WriteLine($"Elemek száma:{darab}");

            //Összeg gyűjtése
            int osszeg = 0;
            for (int i = 0;i<szamok.Length ; i++)
            {
                osszeg += szamok[i];
            }

            Console.WriteLine($"Elemek összege:{osszeg}");

            //min,max
            int min = szamok[0];
            int max = szamok[0];
            for (int i = 0;i<szamok.Length ; i++)
            {
                if (szamok[i] < min) {
                    min = szamok[i];
                }
                if (szamok[i] > max) {
                    max = szamok[i]; 
                }
            }

            Console.WriteLine($"Min:{min},Max:{max}");

            Console.WriteLine($"Db:{szamok.Length},Összeg:{szamok.Sum()},Min:{szamok.Min()},Max:{szamok.Max()}");

            Console.ReadKey();


        }
    }
}
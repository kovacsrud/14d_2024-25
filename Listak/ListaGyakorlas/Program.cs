namespace ListaGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsen egész számokat tartalmazó listát! Töltse fel véletlen számokkal! A lista elemszámát is véletlen számmal határozza meg! Adja meg a lista elemeinek az összegét, átlagát, legkisebb, legnagyobb elemet!

            Random random = new Random();

            List<int> szamok = new List<int>();

            for (int i = 0; i < random.Next(50,500); i++)
            {
                szamok.Add(random.Next(1,1000+1));
            }

            Console.WriteLine($"A lista elemszáma:{szamok.Count}");
            Console.WriteLine($"Összeg:{szamok.Sum()},Átlag:{szamok.Average():0.00},Min:{szamok.Min()},Max:{szamok.Max()}");

            //Készítse el a lottó sorsolásának megoldását listákkal! 
            //Készítsen két listát, az egyik modellezze a sorsoló gömböt, a másikba a kisorsolt számok kerüljenek! A sorsolás után "tegyük vissza" a kivett számokat!

            List<int> gomb= new List<int>();
            List<int> kisorsolt= new List<int>();

            for (int i = 0; i < 90; i++)
            {
                gomb.Add(i + 1);
            }

            for (int i = 0; i < 5; i++)
            {
                var index=random.Next(0,gomb.Count);
                kisorsolt.Add(gomb[index]);
                gomb.RemoveAt(index);
            }
            

            foreach (int i in kisorsolt)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();

            foreach (var i in gomb)
            {
                Console.Write(i + " ");
            }

            gomb.AddRange(kisorsolt);

            Console.WriteLine();

            foreach (var i in gomb)
            {
                Console.Write(i + " ");
            }

        }
    }
}
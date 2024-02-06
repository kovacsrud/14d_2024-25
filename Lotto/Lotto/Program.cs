namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Hány számot húzunk?");
            int hanySzam=Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számból sorsolunk?");
            int osszSzam=Convert.ToInt32(Console.ReadLine());

            int[] tippek=new int[hanySzam];
            int[] nyeroszamok=new int[hanySzam];

            //Tippek bekérése
            // 1 és osszSzam kozott kell lennie
            // nem szerepelhet a tippek között
            for(int i=0;i<hanySzam;i++)
            {
                Console.Write($"{i+1}.tipp:");
                int temp=Convert.ToInt32(Console.ReadLine());

                while(temp<1 || temp>osszSzam || tippek.Contains(temp))
                {
                    Console.Write("Hibás tipp, újra:");
                    temp=Convert.ToInt32(Console.ReadLine());
                }
                tippek[i]=temp;

            };

            Array.Sort(tippek);

            foreach(int i in tippek)
            {
                Console.Write($"{i} ");
            };
            Console.WriteLine();

            int hetek = 0;
            int talalat = 0;

            while (talalat!=5)
            {

            talalat = 0;

            //Innen futtatjuk ciklusban az ismételt sorsolást
            //Sorsolás
            for(int i=0;i< hanySzam;i++)
            {
                int temp=rand.Next(1,osszSzam+1);
                while(nyeroszamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                };
                nyeroszamok[i]=temp;
            };

            //Array.Sort(nyeroszamok);

            //foreach (int i in nyeroszamok)
            //{
            //    Console.Write($"{i} ");
            //};
            //Találatok számának meghatározása
            

            for (int i = 0; i < tippek.Length; i++)
            {
                for (int j = 0; j < nyeroszamok.Length; j++)
                {
                    if (tippek[i] == nyeroszamok[j])
                    {
                        talalat++;
                    }
                }
            }

                //Console.WriteLine($"Találatok száma:{talalat}");

                //talalat = 0;

                //for (int i = 0; i < tippek.Length; i++)
                //{
                //    if (tippek.Contains(nyeroszamok[i]))
                //    {
                //        talalat++;
                //    }
                //}

                if (talalat>1)
                {
                    Console.WriteLine($"Találatok száma:{talalat}");
                }

            
            hetek++;

                //ciklus vége
            }
            //Hány évbe telt
            Console.WriteLine($"{hetek/52} évbe telt");

        }
    }
}
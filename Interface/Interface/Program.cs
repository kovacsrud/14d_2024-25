namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kor kor1 = new Kor(23.56);
            Kor kor2 = new Kor(45.78);
            Kor kor3 = new Kor(110);
            Kor kor4 = new Kor(98.662);

            Teglalap t1 = new Teglalap(10, 8);
            Teglalap t2 = new Teglalap(26, 45);
            Teglalap t3 = new Teglalap(110.89, 86.1);
            Teglalap t4 = new Teglalap(56.78, 99.5);

            List<Kor> korok= new List<Kor>();
            korok.Add(kor1);
            
            List<ISikidom> sikidomok = new List<ISikidom>();
            sikidomok.Add(kor1);
            sikidomok.Add(kor2);
            sikidomok.Add(kor3);
            sikidomok.Add(kor4);
            sikidomok.Add(t1);
            sikidomok.Add(t2);
            sikidomok.Add(t3);
            sikidomok.Add(t4);

            //Mennyi a síkidomok összes területe/kerülete?

            var osszKerulet = sikidomok.Sum(x => x.Kerulet());
            var osszTerulet=sikidomok.Sum(x=>x.Terulet());

            Console.WriteLine($"Össz kerület:{osszKerulet:0.00} Össz. terület:{osszTerulet:0.00}");

            //Mennyi a körök összes területe/kerülete?
            var korSumKerulet = sikidomok.FindAll(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Kerulet());

            Console.WriteLine($"Körök össz. kerülete:{korSumKerulet:0.00}");

            var korSumTerulet = sikidomok.FindAll(x => x.GetType() == typeof(Kor)).Sum(x => x.Terulet());

            Console.WriteLine($"Körök össz. területe:{korSumTerulet:0.00}");

                        

            foreach (var i in sikidomok)
            {
                //Az adott típus propertijei?
                if (i.GetType() == typeof(Kor))
                {
                    //((Kor)i).Sugar
                    //(i as Kor)
                    Kor kor = (Kor)i;
                    //Console.WriteLine(((Kor)i).Sugar);
                    //vagy
                    Console.WriteLine(kor.Sugar);
                }

                if (i.GetType()==typeof(Teglalap))
                {
                    Teglalap t= (Teglalap)i;
                    Console.WriteLine($"A:{t.Aoldal} B:{t.Boldal}");
                }

            }




        }
    }
}

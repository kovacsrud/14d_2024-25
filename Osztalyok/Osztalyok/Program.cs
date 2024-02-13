namespace Osztalyok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Osztály: adatok és metódusok(függvények) összessége. Egy önálló egység a programban, amelyből
            //több példányt is készíthetünk

            //Szemely osztály példányosítása
            Szemely ubul = new Szemely("Nagy","Ubul",1991,"Bélmegyer");
            Szemely elek=new Szemely();

            Szemely anna = new Szemely {
                Vezeteknev="Kovács",
                Keresztnev="Anna",
                Lakhely="Miskolc"
            };

            //ubul.vezeteknev = "Kiss";
            //ubul.keresztnev = "Ubul";
            //ubul.szuletesiEv = 1998;
            //ubul.lakhely = "Kétegyháza";

            Szemely agnes=new Szemely("Kis","Ágnes",2001,"Keszthely");
            //agnes.vezeteknev = "Kósa";
            //agnes.keresztnev = "Ágnes";
            //agnes.lakhely = "Orosháza";
            //agnes.szuletesiEv = 1986;

            //Console.WriteLine(agnes.keresztnev);
            //Console.WriteLine(agnes.vezeteknev);
            //Console.WriteLine(ubul.vezeteknev);
            //Console.WriteLine(ubul.keresztnev);
            

            Console.WriteLine($"{agnes.Vezeteknev} {agnes.Keresztnev}");


            //polimorfizmus: ugyanaz a metódushívás eltérő eredményt eredményez két különböző példánynál
            Console.WriteLine(ubul.Eletkor());
            agnes.SetSzuletesiEv(1988);
            Console.WriteLine(agnes.Eletkor());
            Console.WriteLine(agnes.GetSzuletesiEv());

            //Készítsen osztályt Auto néven! 
            //A következő property-k legyenek az osztályban:
            //Marka,Tipus,GyartasiEv,Szin,FutottKM
            //Csak paraméteres konstruktorral lehessen példányosítani!
            //A FutottKm ne lehessen negatív
            //A GyartasiEv ne lehessen kisebb mint 1990, ne lehessen nagyobb mint az aktualis év

            //Autó lista létrehozása
            Random random = new Random();
            List<string> markak = new List<string>() {"Opel","Ford","BMW","Fiat","Citroen","Peugeot","VolksWagen","Mazda","Skoda"};
            List<string> tipusok = new List<string>() {"Focus","Mondeo","Fabia","Xsara","Bravo","407","320d","Premacy" };
            List<string> szinek = new List<string>() { "piros","kék","zöld","sárga","fekete","fehér","szürke"};

            List<Auto> autok=new List<Auto>();

            for(int i = 0; i < 1000; i++)
            {
                var markaIndex = random.Next(0, markak.Count);
                var tipusIndex = random.Next(0, tipusok.Count);
                var szinIndex = random.Next(0, szinek.Count);
                var futottKm = random.Next(100, 300000+1);
                var gyartasiev=random.Next(1990,DateTime.Now.Year+1);

                autok.Add(new Auto
                {
                    Marka = markak[markaIndex],
                    Tipus = tipusok[tipusIndex],
                    Szin = szinek[szinIndex],
                    FutottKM = futottKm,
                    GyartasiEv = gyartasiev
                });

            }

            Console.WriteLine($"Autók száma:{autok.Count}");

            var fordFocusok = autok.FindAll(x=>x.Marka=="Ford" && x.Tipus=="Focus");

            Console.WriteLine($"Focusok száma:{fordFocusok.Count}");

            foreach(var ford in fordFocusok)
            {
                Console.WriteLine($"{ford.Szin},{ford.FutottKM},{ford.GyartasiEv}");
            }

            Console.WriteLine("----------------------------------");
            var fordMondeok = autok.Where(x => x.Marka == "Ford" && x.Tipus == "Mondeo");


            //foreach (var ford in fordMondeok)
            //{
            //    Console.WriteLine($"{ford.Szin},{ford.FutottKM},{ford.GyartasiEv}");
            //}

            if (autok.Any(x=>x.Marka.ToLower()=="BMW".ToLower() && x.Tipus.ToLower() =="Fabia".ToLower() ))
            {
                Console.WriteLine("Van ilyen!");
            } else
            {
                Console.WriteLine("Nincs ilyen!");
            }

            var atlagFutott = autok.Average(x=>x.FutottKM);
            var minFutott = autok.Min(x => x.FutottKM);
            var maxFutott = autok.Max(x => x.FutottKM);

            Console.WriteLine($"Átlagos futás:{atlagFutott},Min:{minFutott},Max:{maxFutott}");


            //Hány darab van márkánként az autókból?
            //Összesítési feladat

            var stat = autok.ToLookup(x=>x.Marka);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key},{i.Count()},{i.Average(x=>x.FutottKM)}");
            }

            //Hány darab van márkánként és típusonként?
            var statTipus = autok.ToLookup(x => new {x.Marka,x.Tipus});

            foreach (var i in statTipus)
            {
                Console.WriteLine($"{i.Key.Marka} {i.Key.Tipus},{i.Count()}");
            }
            
            

        }
    }
}
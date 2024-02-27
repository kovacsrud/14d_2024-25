namespace Szotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> romaiSzamok=new Dictionary<string, int>
            {
                {"I",1 },{"II",2},{"III",3},{"IV",4},{"V",5},{"VI",6},{"VII",7}
            };

            //A kulcs megadásával megkapjuk a hozzá tartozó értéket
            Console.WriteLine(romaiSzamok["I"]);

            //új kulcs-érték pár hozzáadása a szótárhoz
            romaiSzamok.Add("VIII", 8);

            //új kulcs-érték pár hozzáadása a szótárhoz
            romaiSzamok["IX"] = 9;

            //elem vizsgálatok
            Console.WriteLine(romaiSzamok.Count);
            //a megadott kulcs megtalálható-e a szótárban
            Console.WriteLine(romaiSzamok.ContainsKey("IX"));
            //A megadott érték megtalálható-e a szótárban
            Console.WriteLine(romaiSzamok.ContainsValue(11));

            //Szótár elemeinek a kiíratása
            foreach (KeyValuePair<string,int> i in romaiSzamok)
            {
                Console.WriteLine($"Kulcs:{i.Key}, Érték:{i.Value}");
            }

            //Generáljunk 1000 db egész, pozitív véletlen számot, szótár felhasználásával készítsünk statisztikát arról, hogy melyik számból hány darab van!
            Random random = new Random();

            Dictionary<int, int> randomSzamok = new Dictionary<int, int>();

            for (int i = 0; i < 1000; i++)
            {
                int szam=random.Next(1,100+1);
                if (!randomSzamok.ContainsKey(szam))
                {
                    randomSzamok[szam] = 1;
                } else
                {
                    //randomSzamok[szam]++;
                    randomSzamok[szam] = randomSzamok[szam]+1;
                }
                
            }

            //kulcs szerint rendezetten

            var rendezettSzamok = randomSzamok.OrderBy(x => x.Key);

            //érték szerint rendezetten

            var ertekSzerintRendezettSzamok = randomSzamok.OrderByDescending(x => x.Value);
            
            foreach (var i in ertekSzerintRendezettSzamok)
            {
                Console.WriteLine($"{i.Key}:{i.Value}");
            }

            //A 11 értékhez tartozó kulcsok?

            var tizenegy = randomSzamok.Where(x => x.Value == 11);
            Console.WriteLine("-------------------------");

            foreach (var i in tizenegy)
            {
                Console.Write($"{i.Key} ");
            }


        }
    }
}

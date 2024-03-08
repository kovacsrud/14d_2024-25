using System.Text;

namespace Idojarasadatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IdojarasAdat> idojarasAdatok=new List<IdojarasAdat> ();

            try
            {
                var sorok = File.ReadAllLines("idojaras.csv");

                for (int i = 1; i < sorok.Length; i++)
                {
                    idojarasAdatok.Add(new IdojarasAdat(sorok[i], ';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Sorok száma:{idojarasAdatok.Count}");

            //Szűrjük ki a 2007 májusi adatokat, és listázzuk ki.
            var majus2007 = idojarasAdatok.FindAll(x => x.Ev == 2007 && x.Honap == 5).OrderBy(x=>x.Nap).ThenByDescending(x=>x.Ora);

            foreach (var a in majus2007)
            {
                Console.WriteLine($"{a.Nap} {a.Ora} {a.Homerseklet:0.00},{a.Szelsebesseg:0.00},{a.Paratartalom:0.00}");
            }

            //Volt-e olyan nap, amikor a hőmérséklet 40 fok fölé ment?

            var negyvenfole = idojarasAdatok.Find(x => x.Homerseklet > 40);

            //A kérdőjel használatával az adott változó akár null értékű is lehet
            Console.WriteLine(negyvenfole?.Ev);

            if (negyvenfole != null)
            {
                Console.WriteLine($"{negyvenfole.Ev}.{negyvenfole.Honap}.{negyvenfole.Nap}");
            } else
            {
                Console.WriteLine("Nincs ilyen nap");
            }

            //Ha csak arra kell válaszolni, hogy volt-e ilyen nap.
            if (idojarasAdatok.Any(x=>x.Homerseklet>40))
            {
                Console.WriteLine("Volt ilyen nap");
            } else
            {
                Console.WriteLine("Nem volt ilyen nap");
            }

            //Melyik volt a legmelegebb nap?
            var maxho = idojarasAdatok.Max(y => y.Homerseklet);

            var legmelegebb = idojarasAdatok.Find(x=>x.Homerseklet==maxho);

            Console.WriteLine($"{legmelegebb.Ev}.{legmelegebb.Honap}.{legmelegebb.Nap} {legmelegebb.Ora} {legmelegebb.Homerseklet}");

            //Melyik volt a leghidegebb nap?
            var minho = idojarasAdatok.Min(y => y.Homerseklet);
            var leghidegebb = idojarasAdatok.Find(x => x.Homerseklet ==minho);

            Console.WriteLine($"{leghidegebb.Ev}.{leghidegebb.Honap}.{leghidegebb.Nap} {leghidegebb.Ora} {leghidegebb.Homerseklet}");

            //Mennyi volt az adott évek átlaghőmérséklete? (ToLookup)

            var stat = idojarasAdatok.ToLookup(x => x.Ev).OrderBy(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Average(x=>x.Homerseklet):0.00},{i.Min(x=>x.Homerseklet):0.00},{i.Max(x=>x.Homerseklet):0.00}");
            }

            //Mennyi volt az adott hónapok átlaghőmérséklete

            var honapStat = idojarasAdatok.ToLookup(x=>new {x.Ev,x.Honap}).OrderBy(x=>x.Key.Ev).ThenBy(x=>x.Key.Honap);

            foreach (var i in honapStat)
            {
                Console.WriteLine($"{i.Key.Ev}.{i.Key.Honap} - {i.Average(x=>x.Homerseklet):0.00},{i.Min(x=>x.Homerseklet):0.00},{i.Max(x=>x.Homerseklet)}");
            }


            //Mennyi volt az adott napok átlaghőmérséklete, az eredményt írjuk fájlba!
            var napStat = idojarasAdatok.ToLookup(x => new { x.Ev, x.Honap, x.Nap }).OrderBy(x => x.Key.Ev).ThenBy(x => x.Key.Honap).ThenBy(x => x.Key.Nap);

            try
            {
                FileStream fajl = new FileStream("nap_statisztika.txt", FileMode.Create);

                using (StreamWriter writer=new StreamWriter(fajl,Encoding.Default))
                {
                    writer.WriteLine($"Ev;Honap;Nap;AtlagHomerseklet;MinHomerseklet;MaxHomerseklet");
                    foreach (var i in napStat)
                    {
                        writer.WriteLine($"{i.Key.Ev};{i.Key.Honap};{i.Key.Nap};{i.Average(x=>x.Homerseklet)};{i.Min(x=>x.Homerseklet)};{i.Max(x=>x.Homerseklet)}");
                    }
                }

                Console.WriteLine("A fájlba írás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

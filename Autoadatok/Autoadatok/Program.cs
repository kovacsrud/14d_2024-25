namespace Autoadatok
{
    internal class Program
    {
        public static List<Auto> AutoadatList { get; set; }=new List<Auto>();
        public static List<Pilota> Pilotak {  get; set; } =new List<Pilota>();
        static void Main(string[] args)
        {
                                                       

            try
            {                
                AutoadatList= new AutoadatLista("autoadat.csv", ';').AutoLista;
                Pilotak= new Pilotak("pilotak.csv",';').PilotaLista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                        
            Console.WriteLine(AutoadatList.Count);

            //Hány benzines autó van a listában?
            Console.WriteLine($"Benzines autók száma:{AutoadatList.FindAll(x=>x.Uzem.ToLower()=="benzin".ToLower()).Count} db.");

           //Mennyi dízel autó van a listában?
            Console.WriteLine($"Dízel autók száma:{AutoadatList.FindAll(x => x.Uzem.ToLower() == "Dízel".ToLower()).Count} db.");

            //Mennyi a dízel illetve a benzines autók átlagos futásteljesítménye (futott km)
            Console.WriteLine($"Benzinesek átlagos futása:{AutoadatList.FindAll(x=>x.Uzem.ToLower()=="benzin").Average(x=>x.FutottKm):0.00}");

            Console.WriteLine($"Dízelek átlagos futása:{AutoadatList.FindAll(x => x.Uzem.ToLower() == "dízel").Average(x => x.FutottKm):0.00}");


            //Mennyi 1600 hengerűrtartalom feletti dízel autó van?
            Console.WriteLine($"1600 feletti dízelek:{AutoadatList.FindAll(x=>x.Hengerurtartalom>1600 && x.Uzem.ToLower()=="dízel").Count} .db");

            //Szűrjük ki és jelenítsük meg a klímával rendelkező autókat!
            var klimasok = AutoadatList.FindAll(x => x.Tipus.ToLower().Replace("í", "i").Contains("klim"));

            foreach(Auto auto in klimasok)
            {
                Console.WriteLine($"{auto.Tipus}");
            }

            Console.WriteLine($"Darabszám:{klimasok.Count}");

            //Az benzines, vagy a dízel autók átlagára a nagyobb?

            foreach(var i in Pilotak)
            {
                Console.WriteLine($"{i.Nev},{i.SzuletesiDatum},{i.SzuletesiDatumDO}");
            }

            //Ki a legidősebb a pilóták közül?
            var mindate = Pilotak.Min(x => x.SzuletesiDatum);
            Console.WriteLine($"A legidősebb:{Pilotak.Find(x=>x.SzuletesiDatum==mindate).SzuletesiDatumDO}");

            //Ki a legidősebb/legfiatalabb pilóta a mezőnyben? (van rajtszáma)
            var aktivPilotak = Pilotak.FindAll(x => x.Rajtszam >-1);

            var minDatum = aktivPilotak.Min(x => x.SzuletesiDatum);
            var maxDatum = aktivPilotak.Max(x => x.SzuletesiDatum);

            var legfiatalabb = aktivPilotak.Find(x => x.SzuletesiDatum == maxDatum);
            var legidosebb = aktivPilotak.Find(x => x.SzuletesiDatum == minDatum);

            Console.WriteLine($"Legidosebb:{legidosebb.Nev}-{legidosebb.SzuletesiDatumDO},legfiatalabb:{legfiatalabb.Nev}-{legfiatalabb.SzuletesiDatumDO}");

            //Kinek van a legnagyobb/legkisebb rajtszáma az aktív pilóták közül?

            //Írjuk ki fájlba az aktív pilóták adatait, aktivpilotak.csv néven!

            //Írjuk ki fájlba az 1945 és 1965 között született pilóták adatait, pilotak_45-65.csv néven!





        }

    }
    
}

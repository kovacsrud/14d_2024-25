using System.Text;

namespace FajlolvasasFeldolgozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hegycsucs> hegycsucsok= new List<Hegycsucs>();
            try
            {
                var sorok = File.ReadAllLines("hegyek.txt",Encoding.Default);

                for (int i = 0; i < sorok.Length; i++)
                {
                    hegycsucsok.Add(new Hegycsucs(sorok[i], ';'));
                }
                Console.WriteLine($"{hegycsucsok.Count} sor beolvasva.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //foreach (var h in hegycsucsok)
            //{
            //    Console.WriteLine($"{h.Hegyseg},{h.HegycsucsNeve},{h.CsucsMagassaga}");
            //}
            //Melyik a legmagasabb hegycsúcs?

            var legMagasabb=hegycsucsok.Max(x=>x.CsucsMagassaga);
            var legmagasabbCsucs = hegycsucsok.Find(x => x.CsucsMagassaga == legMagasabb);

            Console.WriteLine($"{legmagasabbCsucs.HegycsucsNeve},{legmagasabbCsucs.Hegyseg},{legmagasabbCsucs.CsucsMagassaga} m");

            //Legalacsonyabb hegycsúcs

            var legalacsonyabbCsucs = hegycsucsok.Find(x => x.CsucsMagassaga == hegycsucsok.Min(x => x.CsucsMagassaga));

            Console.WriteLine($"{legalacsonyabbCsucs.HegycsucsNeve},{legalacsonyabbCsucs.Hegyseg},{legalacsonyabbCsucs.CsucsMagassaga}");

            //Hány hegycsúcs van a Mátrában?

            Console.WriteLine(hegycsucsok.FindAll(x=>x.Hegyseg=="Mátra").Count);

            //Hány hegycsúcs tartozik az egyes hegységekhez

            var stat = hegycsucsok.ToLookup(x => x.Hegyseg).OrderBy(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key},{i.Count()}, legmagasabb:{i.Max(x=>x.CsucsMagassaga)}, legalacsonyabb:{i.Min(x=>x.CsucsMagassaga)}");
            }

            //Bükk-vidék adatait írjuk ki egy új fájlba

            var bukkVidek = hegycsucsok.FindAll(x => x.Hegyseg == "Bükk-vidék");

            

            try
            {
                FileStream file = new FileStream("bukkvidek.txt", FileMode.Create);


                using (StreamWriter writer = new StreamWriter(file, Encoding.Default))
                {
                    writer.WriteLine($"Hegycsucs;Hegyseg;Csucsmagassag");

                    foreach (var i in bukkVidek)
                    {
                        writer.WriteLine($"{i.HegycsucsNeve};{i.Hegyseg};{i.CsucsMagassaga}");
                    }
                }
                                             

                Console.WriteLine("Fájlba írás kész!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //string fájlba íratása
            string szoveg = "Valami, bármi, akármi...";
            File.WriteAllText("valami.txt", szoveg);

            


        }
    }
}

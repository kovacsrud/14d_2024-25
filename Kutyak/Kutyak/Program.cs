using System.Text;

namespace Kutyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kutyanev> Kutyanevek=new List<Kutyanev>();
            List<Kutyafajta> Kutyafajtak=new List<Kutyafajta>();
            List<Rendeles> Rendelesek=new List<Rendeles>();

            try
            {
                Kutyanevek = new KutyanevLista("kutyanevek.csv", ';').Kutyanevek;
                Kutyafajtak = new KutyafajtaLista("kutyafajtak.csv", ';').Kutyafajtak;
                Rendelesek = new RendelesLista("kutyak.csv", ';').Rendelesek;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Kutyanevek:{Kutyanevek.Count} db, Kutyafajták:{Kutyafajtak.Count} db, Rendelési adatok:{Rendelesek.Count} db");

            var atlagEletkor = Rendelesek.Average(x=>x.Eletkor);
            Console.WriteLine($"Kutyák átlagéletkora:{atlagEletkor:0.00}");

            var rendelesek_kutyanevek = Rendelesek.Join(Kutyanevek,
                r=>r.NevId,
                kn=>kn.Id,
                (r,kn)=>new {r.Id,r.NevId,r.FajtaId,r.Eletkor,r.UtolsoEll,kn.KutyaNev });

            //foreach (var i in rendelesek_kutyanevek)
            //{
            //    Console.WriteLine($"{i.Eletkor},{i.KutyaNev}");
            //}

            var rendelesek_kutyanevek_kutyafajtak = rendelesek_kutyanevek.Join(Kutyafajtak,
                rk=>rk.FajtaId,
                kf=>kf.Id,
                (rk,kf)=>new {rk.Id,rk.Eletkor,rk.UtolsoEll,rk.KutyaNev,kf.FajtaNev,kf.FajtaEredetiNev}
                );

            //foreach (var i in rendelesek_kutyanevek_kutyafajtak)
            //{
            //    var datum = $"{i.UtolsoEll.Year}.{i.UtolsoEll.Month}.{i.UtolsoEll.Day}";

            //    Console.WriteLine($"{i.KutyaNev},{i.FajtaNev},{i.Eletkor},{datum}");
            //}

            //Legidősebb kutya neve, fajtája, kora

            var legidosebb = rendelesek_kutyanevek_kutyafajtak.Max(x=>x.Eletkor);

            var legidosebbKutya = rendelesek_kutyanevek_kutyafajtak.Where(x => x.Eletkor == legidosebb);

            Console.WriteLine($"A legidősebb kutya:{legidosebbKutya.First().KutyaNev}, Fajtája:{legidosebbKutya.First().FajtaNev},Életkora:{legidosebbKutya.First().Eletkor}");

            var maxLeterhelt = rendelesek_kutyanevek_kutyafajtak.ToLookup(x=>new {x.UtolsoEll.Year,x.UtolsoEll.Month,x.UtolsoEll.Day }).OrderByDescending(x=>x.Count());

            Console.WriteLine($"A legtöbben voltak:{maxLeterhelt.First().Key.Year}.{maxLeterhelt.First().Key.Month}.{maxLeterhelt.First().Key.Day}, {maxLeterhelt.First().Count()} kutya ellátva");

            //2018.01.10-én fajtánként hány kutya volt a rendelőben?
            var adottNap = rendelesek_kutyanevek_kutyafajtak.Where(x => x.UtolsoEll == new DateTime(2018,1,10));

            var adottNapStat = adottNap.ToLookup(x=>x.FajtaNev);

            foreach (var i in adottNapStat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()}");
            }

            var nevStat = rendelesek_kutyanevek_kutyafajtak.ToLookup(x => x.KutyaNev).OrderByDescending(x=>x.Count());

            try
            {
                FileStream fajl = new FileStream("nevstatisztika.txt", FileMode.Create);

                using (StreamWriter writer=new StreamWriter(fajl,Encoding.Default))
                {
                    foreach (var i in nevStat)
                    {
                        writer.WriteLine($"{i.Key};{i.Count()}");
                    }
                }

                Console.WriteLine("Fájlba írás kész!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

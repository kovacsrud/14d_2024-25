namespace Listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista deklarációja
            //A lista dinamikus adatszerkezet, annyi eleme van, amennyit hozzáadunk.
            List<int> szamok=new List<int>();
            Console.WriteLine($"Elemek száma:{szamok.Count}");

            //Elemek hozzáadása
            szamok.Add(122);
            szamok.Add(218);
            szamok.Add(556);
            szamok.Add(999);
            szamok.Add(999);

            Console.WriteLine($"Elemek száma:{szamok.Count}");

            for(int i = 0; i < szamok.Count; i++)
            {
                
                if (i == 1)
                {
                    szamok[i] = 999;
                }
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();
            //Csak létező indexen lévő érték módosítható!
            //szamok[3] = 1199;

            //Az adott érték első előfordulását távolítja el
            //szamok.Remove(999);

            //Az adott érték összes előfordulásának eltávolítása
            //szamok.RemoveAll(x => x == 999);

            //szamok.RemoveAt(0);
           

            List<int> masikSzamok= new List<int>();
            masikSzamok.Add(411);
            masikSzamok.Add(1888);
            masikSzamok.Add(4122);
            masikSzamok.Add(566);

            //Lista hozzáadása egy másik listához
            szamok.AddRange(masikSzamok);

            foreach (int i in szamok)
            {
                Console.Write(i + " ");
            }

            //Keresés a listában
            int keresett = 999;

            for(int i = 0;i < szamok.Count; i++)
            {
                if (szamok[i] == keresett)
                {
                    Console.WriteLine($"A keresett szám:{keresett} benne van a listában!");
                    break;
                }
            }

            //Ugyanez a nyelv eszközével
            if (szamok.Any(x=>x==keresett))
            {
                Console.WriteLine("Benne van!");
            } else
            {
                Console.WriteLine("Nincs benne!");
            }

            //Keresések a listában
            keresett = 500;
            //Find: az első előfordulást találja meg, FindAll: az összes előfordulást
            var result=szamok.FindAll(x=>x>keresett);

            //Console.WriteLine($"Keresett:{result}");
            foreach (int i in result)
            {
                Console.WriteLine(i + " ");
            }

            //FindIndex:Az első előfordulás indexét találja meg
            keresett=412;
            var resultIndex = szamok.FindIndex(x => x == keresett);
            Console.WriteLine($"A keresett index:{resultIndex}");

        }
    }
}
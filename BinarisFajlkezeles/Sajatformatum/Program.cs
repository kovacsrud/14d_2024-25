using System.Text;

namespace Sajatformatum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajlnev = "szinek.txt";
            var szovegfajl=File.ReadAllBytes(fajlnev);
            var fajlnevBin=Encoding.UTF8.GetBytes(fajlnev);

            Console.WriteLine(szovegfajl.Length);
            Console.WriteLine(fajlnevBin.Length);
            //saját fileformátum:filenév hossza ?/filenév változó/fájl hossza ?/fájl adatok változó

            var fajlnevHosszBin = BitConverter.GetBytes(fajlnevBin.Length);
            var fajlhosszBin=BitConverter.GetBytes(szovegfajl.Length);

            Console.WriteLine(fajlnevHosszBin.Length);
            Console.WriteLine(fajlhosszBin.Length);

            var binData=new byte[fajlnevHosszBin.Length+fajlhosszBin.Length+fajlnevBin.Length+szovegfajl.Length];

            Console.WriteLine(binData.Length);

            using (MemoryStream ms=new MemoryStream(binData))
            {
                using (BinaryWriter bw=new BinaryWriter(ms))
                {
                    bw.Write(fajlnevHosszBin);
                    bw.Write(fajlnevBin);
                    bw.Write(fajlhosszBin);
                    bw.Write(szovegfajl);

                }
                File.WriteAllBytes("szinek.bin",ms.ToArray());
                Console.WriteLine("Adatok fájlba írva");
            }

            var binVissza = File.ReadAllBytes("szinek.bin");
            //saját fileformátum:filenév hossza ?/filenév változó/fájl hossza ?/fájl adatok változó
            using (MemoryStream ms=new MemoryStream(binVissza))
            {
                using (BinaryReader br=new BinaryReader(ms))
                {
                    var filenevHosszBin=br.ReadBytes(4);
                    var filenevHossz = BitConverter.ToInt32(filenevHosszBin);
                    Console.WriteLine(filenevHossz);
                    br.ReadBytes(filenevHossz);
                    var fileHosszBin = br.ReadBytes(4);
                    var fileHossz=BitConverter.ToInt32(fileHosszBin);
                    Console.WriteLine(fileHossz);
                    var fileAdatok=br.ReadBytes(fileHossz);
                    File.WriteAllBytes("szinek_masolat.txt",fileAdatok);

                }
            }
        }
    }
}

using System.Collections.Concurrent;
using System.Text;

namespace BinarisFajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var szovegFajl = File.ReadAllBytes("szinek.txt");

            foreach (var bajt in szovegFajl)
            {
                //Console.Write(bajt+" ");
                //Console.Write(Convert.ToString(bajt,2).PadLeft(8,'0')+" ");
            }

            //Console.WriteLine(Encoding.UTF8.GetString(szovegFajl));

            var zipFajl = File.ReadAllBytes("MonthyHallGame.zip");

            //Console.WriteLine(Encoding.UTF8.GetString(zipFajl));

            using (MemoryStream ms=new MemoryStream(zipFajl))
            {
                using (BinaryReader br=new BinaryReader(ms))
                {
                    var signature=br.ReadBytes(4);
                    //Console.WriteLine(BitConverter.ToInt32(signature));
                    Console.WriteLine($"Signature:{BitConverter.ToString(signature)}");   
                    var version=br.ReadBytes(2);
                    //Console.WriteLine(BitConverter.ToString(version));
                    Console.WriteLine($"Version:{BitConverter.ToInt16(version)}");
                    var flags=br.ReadBytes(2);
                    Console.WriteLine($"Flags:{BitConverter.ToString(version)}");
                    var compression=br.ReadBytes(2);
                    Console.WriteLine($"Compression:{BitConverter.ToString(compression)}");
                    var modtime=br.ReadBytes(2);
                    Console.WriteLine($"Modification time:{BitConverter.ToString(modtime)}");
                    var moddate = br.ReadBytes(2);
                    Console.WriteLine($"Modification date:{BitConverter.ToString(moddate)}");
                    var crc=br.ReadBytes(4);
                    Console.WriteLine($"CRC:{BitConverter.ToString(crc)}");
                    var compressed=br.ReadBytes(4);
                    Console.WriteLine($"Compressed:{BitConverter.ToString(compressed)}");
                    var uncompressed = br.ReadBytes(4);
                    Console.WriteLine($"Uncompressed:{BitConverter.ToString(uncompressed)}");
                    var filenameLength = br.ReadBytes(2);
                    Console.WriteLine($"File name length:{BitConverter.ToInt16(filenameLength)}");
                    var extraLength = br.ReadBytes(2);
                    Console.WriteLine($"Extra length:{BitConverter.ToInt16(extraLength)}");
                    var filename=br.ReadBytes(BitConverter.ToInt16(filenameLength));
                    Console.WriteLine($"Fajlnev:{Encoding.UTF8.GetString(filename)}");

                }
            }

        }
    }
}

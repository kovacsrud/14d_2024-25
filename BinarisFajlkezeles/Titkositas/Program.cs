using System.Security.Cryptography;
using System.Text;
namespace Titkositas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titkosítás");

            string fajlnev = "titkos.txt";
            string kulcs = "Titok_12";
            string titkositando = "Szigorúan titkos tartalom";

            Aes aes=Aes.Create();
            SHA256 sha256 = SHA256.Create();

            byte[] binKulcs = sha256.ComputeHash(Encoding.UTF8.GetBytes(kulcs));
            byte[] tartalomHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(titkositando));
            byte[] titkositandoBin = Encoding.UTF8.GetBytes(titkositando);
            byte[] fajlnevBin=Encoding.UTF8.GetBytes(fajlnev);
            Console.WriteLine($"Fájlnév hossza (byte):{fajlnevBin.Length}");
            int fajlnevHossz=fajlnevBin.Length;
            aes.Key = binKulcs;
            aes.GenerateIV();
            
            //Szükséges információk
            //iv- init vektor/eredeti fájlnév/tartalom hash/titkosított tartalom

            //Fájlformátum
            //iv -16byte//fájlnév hossza 4byte//fájlnév -változó//tartalom hash -32byte//tartalom hossza 4-byte//tartalom -változó
            
            //Kódolás

            ICryptoTransform titkosito = aes.CreateEncryptor(binKulcs,aes.IV);
            byte[] titkositott = titkosito.TransformFinalBlock(titkositandoBin, 0, titkositandoBin.Length);

            string kodoltSzoveg = Encoding.UTF8.GetString(titkositott);

            Console.WriteLine(kodoltSzoveg);
            int tartalomHossz=titkositott.Length;

            var kodoltAdatok = new byte[aes.IV.Length+fajlnevHossz+fajlnevBin.Length+tartalomHash.Length+tartalomHossz+titkositott.Length];

            using (MemoryStream ms=new MemoryStream(kodoltAdatok))
            {
                using (BinaryWriter writer=new BinaryWriter(ms))
                {
                    writer.Write(aes.IV);
                    writer.Write(fajlnevHossz);
                    writer.Write(fajlnevBin);
                    writer.Write(tartalomHash);
                    writer.Write(tartalomHossz);
                    writer.Write(titkositott);
                }
                File.WriteAllBytes("titkositott.bin", kodoltAdatok);
                Console.WriteLine("Fájl kiírva!");
            }

            byte[] titkositottFajl = File.ReadAllBytes("titkositott.bin");
            byte[] initVektor;
            byte[] visszaFajlnev;
            byte[] visszaTartalomHash;
            byte[] visszaTartalom;

            //Fájlformátum
            //iv -16byte//fájlnév hossza 4byte//fájlnév -változó//tartalom hash -32byte//tartalom hossza 4-byte//tartalom -változó

            using (MemoryStream ms=new MemoryStream(titkositottFajl))
            {
                using (BinaryReader reader=new BinaryReader(ms))
                {
                    initVektor=reader.ReadBytes(16);
                    byte[] fajlnevMeret=reader.ReadBytes(4);
                    visszaFajlnev=reader.ReadBytes(BitConverter.ToInt32(fajlnevMeret));
                    visszaTartalomHash=reader.ReadBytes(32);
                    byte[] tartalomHossza=reader.ReadBytes(4);
                    visszaTartalom = reader.ReadBytes(BitConverter.ToInt32(tartalomHossza));
                }
            }

            //Dekódolás fájlból
            ICryptoTransform fajlDekodolo = aes.CreateDecryptor(binKulcs, initVektor);
            byte[] fajlbolDekodolt = fajlDekodolo.TransformFinalBlock(visszaTartalom,0,visszaTartalom.Length);

            string fajlbolDekodoltSzoveg=Encoding.UTF8.GetString(fajlbolDekodolt);

            

            byte[] ellenorzoHash = sha256.ComputeHash(fajlbolDekodolt);

            if (Encoding.UTF8.GetString(ellenorzoHash)==Encoding.UTF8.GetString(visszaTartalomHash))
            {
                Console.WriteLine("A jelszó megfelelő!");
                Console.WriteLine(fajlbolDekodoltSzoveg);
                File.WriteAllBytes(Encoding.UTF8.GetString(visszaFajlnev),fajlbolDekodolt);
            } else
            {
                Console.WriteLine("Hibás jelszó!");
            }



            //Dekódolás
            ICryptoTransform dekodolo=aes.CreateDecryptor(binKulcs, aes.IV);
            byte[] dekodolt=dekodolo.TransformFinalBlock(titkositott,0,titkositott.Length);

            string dekodoltSzoveg = Encoding.UTF8.GetString(dekodolt);

            


        }
    }
}

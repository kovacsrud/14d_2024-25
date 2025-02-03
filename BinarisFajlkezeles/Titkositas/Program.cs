using System.Security.Cryptography;
using System.Text;
namespace Titkositas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titkosítás");

            string kulcs = "Titok_12";
            string titkositando = "Szigorúan titkos tartalom";

            Aes aes=Aes.Create();
            SHA256 sha256 = SHA256.Create();

            byte[] binKulcs = sha256.ComputeHash(Encoding.UTF8.GetBytes(kulcs));
            byte[] titkositandoBin = Encoding.UTF8.GetBytes(titkositando);
            aes.Key = binKulcs;
            aes.GenerateIV();
            
            

            ICryptoTransform titkosito = aes.CreateEncryptor(binKulcs,aes.IV);
            byte[] titkositott = titkosito.TransformFinalBlock(titkositandoBin, 0, titkositandoBin.Length);

            string kodoltSzoveg = Encoding.UTF8.GetString(titkositott);

            Console.WriteLine(kodoltSzoveg);

        }
    }
}

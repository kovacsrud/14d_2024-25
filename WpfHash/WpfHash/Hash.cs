using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace WpfHash
{
    public class Hash
    {
        public string Md5Hash(string szoveg)
        {
            //MD5CryptoServiceProvider md5Hash = new MD5CryptoServiceProvider();

            HashAlgorithm md5Hash = MD5.Create();

            byte[] data=null;

            if (File.Exists(szoveg))
            {
                //Fájl betöltés és hash
                data= File.ReadAllBytes(szoveg);
                
            } else
            {
                //Szövegből hash
                data = new UTF8Encoding().GetBytes(szoveg);
            }

            //byte[] 

            return ByteToHash(md5Hash.ComputeHash(data));
        }

        public string SHA1Hash(string szoveg)
        {
            //SHA1CryptoServiceProvider sha1Hash= new SHA1CryptoServiceProvider();

            HashAlgorithm sha1Hash = SHA1.Create();

            byte[] data = null;

            if (File.Exists(szoveg))
            {
                //Fájl betöltés és hash
                data = File.ReadAllBytes(szoveg);

            }
            else
            {
                //Szövegből hash
                data = new UTF8Encoding().GetBytes(szoveg);
            }

            //byte[] 

            return ByteToHash(sha1Hash.ComputeHash(data));

        }

        private string ByteToHash(byte[] data)
        {
            StringBuilder hash = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                hash.Append(data[i].ToString("x2"));
            }

            return hash.ToString();
        }

    }
}

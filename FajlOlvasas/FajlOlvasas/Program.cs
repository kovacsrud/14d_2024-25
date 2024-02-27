using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;

namespace FajlOlvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nem annyira szép, de működik
            //StreamReader reader=null;
			try
			{
                FileStream fajl = new FileStream("hegyek.txt", FileMode.Open);
                //StreamReader reader=new StreamReader(fajl,Encoding.Default);


                //Using blokk használata, a legjobb megoldás
                using (StreamReader reader = new StreamReader(fajl, Encoding.Default))
                {                   
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                }

                //reader.ReadLine();
                //while (!reader.EndOfStream)
                //{
                //    Console.WriteLine(reader.ReadLine());
                //}


                //reader.Close();

            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //fájl bezárása
                //reader.Close();
            }
        }
    }
}

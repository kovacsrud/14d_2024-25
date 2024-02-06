using System.Xml.Linq;

namespace KetdimenziosTomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] szamok1=new int[10,20];

            int[,] szamok2 = new int[,] {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12}
            };

            for (int i = 0; i < szamok1.GetLength(0); i++)
            {
                for (int j = 0; j < szamok1.GetLength(1); j++)
                {
                    szamok1[i, j] = rnd.Next(10, 100);
                }

            }

            for (int i = 0;i < szamok1.GetLength(0); i++)
            {
                for(int j = 0;j<szamok1.GetLength(1); j++)
                {
                    Console.Write(szamok1[i, j]+" ");
                }
                Console.WriteLine();
            }

        }


    }
}
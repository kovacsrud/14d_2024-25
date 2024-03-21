namespace Sorozat
{
    internal class Program
    {
        public static string Generator(string elsoElem,int futas)
        {
            string eredmeny = "";

            for (int i = 0;i<=futas;i++)
            {
                string tempStr = "";

                char[] temp=elsoElem.ToCharArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    double ertek = Convert.ToDouble(Char.GetNumericValue(temp[j])) * 2;
                    tempStr += ertek.ToString();
                }
                elsoElem = tempStr;
                eredmeny = tempStr;
            }

            return eredmeny;
        }

        static void Main(string[] args)
        {
            string keresettElem = Generator("1", 21);
            Console.WriteLine($"A 21.elem:{keresettElem}");
            Console.WriteLine($"Számjegyek száma:{keresettElem.Length}");
        }
    }
}

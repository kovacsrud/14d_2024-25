namespace SzemelyiSzam
{
    internal class Program
    {
        public static bool Ellenorzes(string szemelyiSzam)
        {
            int osszeg = 0;
            int szorzo = 10;
            bool helyesErtek=false;

            for (int i = 0; i <szemelyiSzam.Length-1; i++)
            {
                osszeg += szorzo * (int)Char.GetNumericValue(szemelyiSzam[i]);
                szorzo--;
            }

            var ellenorzoSzam = osszeg % 11;

            if (ellenorzoSzam == Char.GetNumericValue(szemelyiSzam.Last()))
            {
                helyesErtek = true;
            }



            return helyesErtek;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //1-980227-1258
            //2-990926-7743
            //2-991025-3713
            //4-000405-6342
            //3-010416-2982
            //2-990630-5121
            Console.WriteLine(Ellenorzes("19802271258"));
            Console.WriteLine(Ellenorzes("29909267743"));
            Console.WriteLine(Ellenorzes("29910253713"));
            Console.WriteLine(Ellenorzes("40004056342"));

        }
    }
}
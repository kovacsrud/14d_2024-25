namespace FuggvenyGyakorlas
{
    internal class Program
    {

        public static int BetuSzamol(string szoveg,char betu)
        {
            int db = 0;

            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == betu || szoveg[i] == betu)
                {
                    db++;
                }
            }


            return db;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Írjon függvényt, amely a kapott string-ben megszámolja az 'a' betűk számát (írásmódtól függetlenül) és visszatérési értékként visszaadja azt

            Console.WriteLine(BetuSzamol("valami,bármi akármi",'a'));
            Console.WriteLine(BetuSzamol("valami,bármi akármi", 'm'));

        }
    }
}
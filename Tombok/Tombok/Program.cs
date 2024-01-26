namespace Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tömbök 
            //A tömb azonos típusú adatokat tartalmazó adatszerkezet. Deklaráláskor meg kell adni az elemek számát, ez később már nem változtatható.
            //5 elemű tömb, deklaráláskor csak az elemek számát adjuk meg
            int[] szamok = new int[5];

            //Az elemek felsorolásával is létrehozhatunk tömböt
            int[] szamok2 = { 12, 45, 67, 89, 12, 99, 116 };

            //Console.WriteLine(szamok[2]);
            //Console.WriteLine(szamok2[2]);

            //szamok[2] = 111;
            //szamok2[3] = 344;

            //Console.WriteLine(szamok[2]);
            //Console.WriteLine(szamok2[3]);

            //Ciklusok: elöltesztelő, hátultesztelő, növekményes (előírt lépésszámú)
            for(int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = 10+i;
                Console.WriteLine(szamok[i]);
            }


        }
    }
}
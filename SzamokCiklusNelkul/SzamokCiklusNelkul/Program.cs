namespace SzamokCiklusNelkul
{
    internal class Program
    {
     
        //rekurzív függvény, saját magát hívja meg
        static void Kiir(int szam,int hatar)
        {
            Console.WriteLine(szam);
            szam++;
            if (szam <= hatar)
            {
                Kiir(szam,hatar);
            }

        }
        static void Main(string[] args)
        {

            //Jelenítse meg 1-től 10-ig a számokat, ciklus nélkül!
            Kiir(1,100);
           

            Console.ReadKey();
        }
    }
}

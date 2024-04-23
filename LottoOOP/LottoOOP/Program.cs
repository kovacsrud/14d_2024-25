namespace LottoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lottojatek otoslotto = new Lottojatek(5, 90);
            otoslotto.Jatek();

            Lottojatek skandinav = new Lottojatek(7, 45);
            skandinav.Jatek();
          


            Console.ReadKey();
        }
    }
}

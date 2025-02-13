namespace FajlTitkosito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fájlok titkosítása/visszafejtése");
            Encoder.Encoding("proba.txt", "proba.bin", "Titok_12");

            Console.WriteLine(Encoder.Message);
        }
    }
}

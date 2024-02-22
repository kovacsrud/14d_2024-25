namespace Oroklodes_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sportolo sportolo = new Sportolo("futás","Elek",90,180,2004);

            Nyugdijas nyugdijas = new Nyugdijas(230000, "Ödön", 110, 178, 1947);


            Console.WriteLine(sportolo.ToString());
            Console.WriteLine(nyugdijas.ToString());

            List<Ember> emberek = new List<Ember>();

            emberek.Add(sportolo);
            emberek.Add(nyugdijas);

            foreach (var i in emberek)
            {
                Console.WriteLine($"{i.Nev}");
            }





        }
    }
}

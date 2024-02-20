namespace Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Ember ember = new Ember {
                Nev = "Nagy Imre",
                Magassag = 181,
                Suly=89
            };

            Sportolo sportolo = new Sportolo {
                Nev="Kelemen Ubul",
                Magassag=176,
                Suly=69,
                Sportag="futás"
            };

            sportolo.Mozog();
            sportolo.Alszik();
            sportolo.Edzes();
            ember.Alszik();

            Nyugdijas nyugdijas = new Nyugdijas { 
                Nev = "Klári néni",
                Nyugdij=250000,
                Magassag=166,
                MiVoltAFoglalkozasa="adminisztrátor",
                Suly=56
            };

            nyugdijas.Mozog();

            Console.WriteLine(ember.ToString());
            Console.WriteLine(nyugdijas.ToString());
            Console.WriteLine(sportolo.ToString());

        }
    }
}

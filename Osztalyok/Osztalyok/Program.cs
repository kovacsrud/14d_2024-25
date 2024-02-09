namespace Osztalyok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Osztály: adatok és metódusok(függvények) összessége. Egy önálló egység a programban, amelyből
            //több példányt is készíthetünk

            //Szemely osztály példányosítása
            Szemely ubul = new Szemely("Nagy","Ubul",1991,"Bélmegyer");
            Szemely elek=new Szemely();

            Szemely anna = new Szemely {
                Vezeteknev="Kovács",
                Keresztnev="Anna",
                Lakhely="Miskolc"
            };

            //ubul.vezeteknev = "Kiss";
            //ubul.keresztnev = "Ubul";
            //ubul.szuletesiEv = 1998;
            //ubul.lakhely = "Kétegyháza";

            Szemely agnes=new Szemely("Kis","Ágnes",2001,"Keszthely");
            //agnes.vezeteknev = "Kósa";
            //agnes.keresztnev = "Ágnes";
            //agnes.lakhely = "Orosháza";
            //agnes.szuletesiEv = 1986;

            //Console.WriteLine(agnes.keresztnev);
            //Console.WriteLine(agnes.vezeteknev);
            //Console.WriteLine(ubul.vezeteknev);
            //Console.WriteLine(ubul.keresztnev);
            

            Console.WriteLine($"{agnes.Vezeteknev} {agnes.Keresztnev}");


            //polimorfizmus: ugyanaz a metódushívás eltérő eredményt eredményez két különböző példánynál
            Console.WriteLine(ubul.Eletkor());
            agnes.SetSzuletesiEv(1988);
            Console.WriteLine(agnes.Eletkor());
            Console.WriteLine(agnes.GetSzuletesiEv());

            //Készítsen osztályt Auto néven! 
            //A következő property-k legyenek az osztályban:
            //Marka,Tipus,GyartasiEv,Szin,FutottKM
            //Csak paraméteres konstruktorral lehessen példányosítani!
            //A FutottKm ne lehessen negatív
            //A GyartasiEv ne lehessen kisebb mint 1990, ne lehessen nagyobb mint az aktualis év


        }
    }
}
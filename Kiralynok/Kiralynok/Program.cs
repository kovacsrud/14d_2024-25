namespace Kiralynok
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Tabla tabla = new Tabla("*");
            tabla.Megjelenit();
            tabla.Elhelyez(8);
            Console.WriteLine("-----------------");
            tabla.Megjelenit();
            //Console.WriteLine(tabla.UresOszlop(2));
            //Console.WriteLine(tabla.UresOszlop(5));
            //Console.WriteLine(tabla.UresSor(2));
            //Console.WriteLine(tabla.UresSor(5));
            Console.WriteLine($"Üres sorok:{tabla.UresSorokSzama},üres oszlopok:{tabla.UresOszlopokSzama}");
            //Console.WriteLine(tabla.ToString());
            tabla.FajlbaIr();


        }
    }
}

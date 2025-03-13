namespace AllatokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Allat> allatok = new List<Allat>();

            allatok.Add(new Madar("A","veréb",2,10));
            allatok.Add(new Madar("B", "keselyű", 6, 120));
            allatok.Add(new Emlos("C", "szurikáta", 1, true));
            allatok.Add(new Emlos("D", "róka", 5, true));
            allatok.Add(new Hullo("E", "vipera", 3, true));
            allatok.Add(new Hullo("F", "piton", 6, false));

            foreach (var i in allatok)
            {
                if(i.GetType() == typeof(Madar))
                {
                    Madar madar = (Madar)i;
                    Console.WriteLine(madar.ToString());
                }
                if (i.GetType() == typeof(Emlos))
                {
                    Emlos emlos = (Emlos)i;
                    Console.WriteLine(emlos.ToString());
                }
                if (i.GetType() == typeof(Hullo))
                {
                    Hullo hullo = (Hullo)i;
                    Console.WriteLine(hullo.ToString());
                }

            }

        }
    }
}

namespace Tomb_feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[100];
            Random rand= new Random();

            for(int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-200,200+1);
            }

            int minPozitiv = int.MaxValue;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]>0 && szamok[i]<minPozitiv)
                {
                    minPozitiv = szamok[i];
                }
            }

            Console.WriteLine($"Legkisebb nem nulla pozitív:{minPozitiv}");

            int dbKettovelOszthato = 0;
            int maxKettovelOszthato = int.MinValue;

            for (int i = 0;i < szamok.Length; i++)
            {
                if (szamok[i]%2==0)
                {
                    dbKettovelOszthato++;
                }
                if (szamok[i]%2==0 && szamok[i]>maxKettovelOszthato)
                {
                    maxKettovelOszthato = szamok[i];
                }
            }

            Console.WriteLine($"Darabszám:{dbKettovelOszthato},Legnagyobb 2-vel osztható:{maxKettovelOszthato}");


        }
    }
}
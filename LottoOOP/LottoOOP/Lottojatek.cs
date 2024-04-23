using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    public class Lottojatek
    {
        private int hanySzam;
        private int osszSzam;
        private int[] tippek;
        private int[] nyeroszamok;
        private int talalat;
        Random rand;

        public Lottojatek(int hanySzam,int osszSzam)
        {
            this.hanySzam = hanySzam;
            this.osszSzam = osszSzam;
            tippek= new int[hanySzam];
            nyeroszamok= new int[hanySzam]; 
            rand = new Random(); 
            talalat = 0;
        }

        public void Jatek()
        {
            talalat = 0;
            Tippeles();
            //TombLista(tippek);
            Sorsolas();
            //TombLista(nyeroszamok);
            Talalatok();
            TalalatKiir();
        }

        private void Tippeles()
        {
            for(int i = 0; i < hanySzam; i++)
            {
                Console.WriteLine($"{i+1}. tipp");
                var temp = Convert.ToInt32(Console.ReadLine());
                while( temp <1 || temp>osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Rossz! Adja meg újra a {i+1}. tippet!:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;

            }
        }

        private void Sorsolas()
        {
            for (int i = 0; i < hanySzam; i++)
            {
                var temp = rand.Next(1, osszSzam + 1);
                while (nyeroszamok.Contains(temp))
                {
                    temp=rand.Next(1,osszSzam + 1);
                }
                nyeroszamok[i] = temp;
            }
        }

        private void Talalatok()
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                if (tippek.Contains(nyeroszamok[i]))
                {
                    talalat++;
                }
            }
        }

        private void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
            Console.WriteLine();
        }

        private void TalalatKiir()
        {
            TombLista(tippek);
            TombLista(nyeroszamok);
            Console.WriteLine($"Találatok száma:{talalat}");
        }



    }
}

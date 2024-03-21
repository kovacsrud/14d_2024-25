using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    public class Tabla
    {
        private string[,] T;
        private string UresCella;

        public int UresOszlopokSzama { get; set; }
        public int UresSorokSzama { get; set; }

        public Tabla(string urescella)
        {
            T = new string[8, 8];
            UresCella = urescella;
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = UresCella;
                }
            }

        }

        public void Megjelenit()
        {
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    Console.Write(T[i,j]);
                }
                Console.WriteLine();
            }
        }

        public void Elhelyez(int elhelyezDb)
        {
            Random random = new Random();
            for (int i = 0;i < elhelyezDb; i++)
            {
                var sor = random.Next(0, 8);
                var oszlop=random.Next(0, 8);
                var aktualisElem = T[sor, oszlop];
                while (aktualisElem == "K")
                {
                    sor= random.Next(0, 8);
                    oszlop=random.Next(0, 8);
                    aktualisElem= T[sor, oszlop];
                }
                T[sor, oszlop] = "K";
            }

            UresSzamol();
        }

        public bool UresOszlop(int oszlop)
        {
            bool IsUresOszlop = true;
            for (int i = 0; i < T.GetLength(1); i++)
            {
                if (T[i,oszlop]=="K")
                {
                    IsUresOszlop = false;
                }
            }

            return IsUresOszlop;
        }

        public bool UresSor(int sor)
        {
            bool IsUresSor = true;
            for(int i = 0; i < T.GetLength(0); i++)
            {
                if (T[sor, i] == "K")
                {
                    IsUresSor=false;
                }
            }

            return IsUresSor;
        }

        public void UresSzamol()
        {
            for (int i = 0;i < T.GetLength(0); i++)
            {
                if (UresSor(i))
                {
                    UresSorokSzama += 1;
                }
            }
            for(int i = 0;i<T.GetLength(1) ; i++)
            {
                if (UresOszlop(i))
                {
                    UresOszlopokSzama += 1;
                }
            }
        }

        public override string ToString()
        {
            string tabla = "";
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    tabla += T[i, j];
                }
                tabla += System.Environment.NewLine;
            }
            tabla += "        " + System.Environment.NewLine;

            return tabla;
        }

        public void FajlbaIr()
        {
            string tablaStr = "";
            for(int i = 0;i<64 ; i++)
            {
                Tabla tabla = new Tabla("*");
                tabla.Elhelyez(i + 1);
                tablaStr += tabla.ToString();
            }

            try
            {
                File.WriteAllText("tablak64.txt", tablaStr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

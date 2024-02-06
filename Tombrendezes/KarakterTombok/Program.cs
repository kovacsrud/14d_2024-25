namespace KarakterTombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Valami,bármi,akármi";

            char[] chSzoveg=szoveg.ToCharArray();

            //Feladat: a B betűt változtassuk nagybetűsre

            for (int i = 0; i < chSzoveg.Length; i++)
            {
                if (chSzoveg[i] == 'b')
                {
                    chSzoveg[i]='B';
                }
            }

            szoveg = new string(chSzoveg);

            Console.WriteLine(szoveg);

            string szoveg2 = "vAlAmi,BáRMi,aKÁrmi";

            Console.WriteLine(szoveg2);
            //Feladat: Alakítsuk a kisbetűsöket nagybetűssé, a nagybetűsöket pedig kisbetűssé
            char[] chSzoveg2 = szoveg2.ToCharArray();

            for(int i = 0;i < chSzoveg2.Length; i++)
            {
                if (Char.IsLower(chSzoveg2[i]))
                {
                    chSzoveg2[i] = Char.ToUpper(chSzoveg2[i]);
                } else
                {
                    chSzoveg2[i] = Char.ToLower(chSzoveg2[i]);
                }
                
            }


            szoveg2=new string(chSzoveg2);

            Console.WriteLine(szoveg2);

            string szamosSzoveg = "Valami 129, bármi 887";
            //Mennyi a szövegben szereplő számok összege?

            char[] szamos=szamosSzoveg.ToCharArray();

            int osszeg = 0;

            for (int i = 0; i < szamos.Length; i++)
            {
                if (Char.IsNumber(szamos[i]))
                {
                    osszeg += (int)Char.GetNumericValue(szamos[i]);
                }
            }

            Console.WriteLine(osszeg);



        }
    }
}
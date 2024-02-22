namespace Kivetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kivétel: a program futásának megállását eredményező esemény
            //A kivétel kezelhető a programban, ha a programban nem történik meg, akkor a fejlesztő környezet vagy az operációs rendszer kezeli le a kivételt.


            bool IsEverythingOk = true;
            do
            {
                
                try
                {
                    Console.Write("Add meg az egyik számot:");
                    int szam1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg a másik számot:");
                    int szam2 = Convert.ToInt32(Console.ReadLine());

                    int c = szam1 / szam2;

                    Console.WriteLine($"Eredmény:{c}");
                    IsEverythingOk = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    IsEverythingOk = false;
                }
                finally
                {
                    Console.WriteLine("A finally ágban lévő kód mindig lefut");
                }

            } while (!IsEverythingOk);


            try
            {
                throw new IndexOutOfRangeException();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Ez egy arithmetic exception:"+ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Paraméter hiba!"+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Utolsó catch:"+ex.Message);
            }
                


            


            


           

        }
    }
}

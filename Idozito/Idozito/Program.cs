using System.Timers;

namespace Idozito
{
    internal class Program
    {
        static int szamlalo = 0;
        static System.Timers.Timer timer = new System.Timers.Timer();
        static void Main(string[] args)
        {
            timer.Interval = 1000;
            timer.Elapsed += Callback;
            timer.Enabled = true;


            Console.ReadLine();
        }

        private static void Callback(object sender, EventArgs e)
        {
            Console.WriteLine(szamlalo);
            szamlalo++;
            if (Console.KeyAvailable == true)
            {
                //timer.Enabled=!timer.Enabled;
                timer.Interval += 100;
                
            }
        }
    }
}

namespace Tombrendezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 28, 3, 56, 8, 19, 228, 110, 452 };

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1;j<numbers.Length;j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            for (int i = 0;i < numbers.Length ; i++)
            {
                Console.Write(numbers[i]+" ");
            }

        }
    }
}
namespace AppearanceCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintCountOfNumber(numbers, X));
        }

        public static int PrintCountOfNumber(int[] numbers, int x)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].ToString().Contains(x.ToString()))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

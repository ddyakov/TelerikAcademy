namespace SortingArray
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
            Console.ReadLine();
            double[] numbers =
                Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(double.Parse)
                       .ToArray();

            Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void Sort(double[] numbers)
        {
            Array.Sort(numbers);
        }
    }
}

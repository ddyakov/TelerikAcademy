namespace LargerThanNeighbours
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (GetNumbersBiggerThanNeighboursCount(numbers) > 0)
            {
                Console.WriteLine(GetNumbersBiggerThanNeighboursCount(numbers));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        private static int GetNumbersBiggerThanNeighboursCount<T>(IList<T> numbers)
            where T : IComparable
        {
            int number = 0;

            for (int i = 1; i < numbers.Count() - 1; i++)
            {
                if (numbers[i - 1].CompareTo(numbers[i]) < 0 && numbers[i + 1].CompareTo(numbers[i]) < 0)
                {
                    number = i;
                    break;
                }
            }

            return number;
        }
    }
}

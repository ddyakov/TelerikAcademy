namespace BinarySearch
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(numbers, x));
        }

        public static int BinarySearch(int[] numbers, int x)
        {
            int low = 0, high = numbers.Length - 1, midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                if (x == numbers[midpoint])
                {
                    return midpoint;
                }
                else if (x < numbers[midpoint])
                {
                    high = midpoint - 1;
                }
                else
                {
                    low = midpoint + 1;
                }
            }

            return -1;            
        }
    }
}

namespace MaximalIncreasingSequence
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int currMax = 0;
            int bestMax = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    currMax++;
                }
                else
                {
                    if (currMax >= bestMax)
                    {
                        bestMax = currMax;
                    }

                    currMax = 1;
                }
            }

            Console.WriteLine(bestMax);
        }
    }
}

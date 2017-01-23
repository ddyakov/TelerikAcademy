namespace SelectionSort
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

            int minNum = 0;

            for (int i = 0; i < n - 1; i++)
            {
                minNum = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minNum])
                    {
                        minNum = j;
                    }
                }
                    
                if (minNum != i)
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[minNum];
                    numbers[minNum] = tmp;
                }
            }

            Console.WriteLine(string.Join("\n", numbers));
        }
    }
}

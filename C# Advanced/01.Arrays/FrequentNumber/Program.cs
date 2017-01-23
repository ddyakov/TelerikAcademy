namespace FrequentNumber
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

            int numCounter = 0;
            int specialNumber = numbers[0];
            int maxRepeat = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int temp = numbers[i];
                numCounter = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (temp == numbers[j])
                    {
                        numCounter++;   
                    }
                }

                if (maxRepeat < numCounter)
                {
                    maxRepeat = numCounter;
                    specialNumber = temp;
                }
            }

            Console.WriteLine("{0} ({1} times)", specialNumber, maxRepeat);
        }
    }
}

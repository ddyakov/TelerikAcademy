namespace MaximalSequence
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int currSequence = 1;
            int maxSequence = 1;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currSequence++;
                }
                else
                {
                    currSequence = 1;
                }

                if (currSequence > maxSequence)
                {
                    maxSequence = currSequence;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}

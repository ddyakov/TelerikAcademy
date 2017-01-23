namespace CompareArrays
{
    using System;

    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] firstArray = new int[N];
            bool equal = false;

            for (int i = 0; i < N; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            int[] secondArray = new int[N];

            for (int i = 0; i < N; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                    break;
                }
            }

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}

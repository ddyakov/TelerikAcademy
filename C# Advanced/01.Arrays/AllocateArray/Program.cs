namespace AllocateArray
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = new int[20];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}

namespace MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            numbers.Sort();
            Console.WriteLine(string.Join("\n", numbers));
        }
    }
}

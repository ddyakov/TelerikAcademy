namespace CompareCharArrays
{
    using System;

    class Program
    {
        static void Main()
        {
            string firstArray = Console.ReadLine();
            string secondArray = Console.ReadLine();
            int length = firstArray.Length;

            if (firstArray.CompareTo(secondArray) > 0)
            {
                Console.WriteLine(">");
            }
            else if (firstArray.CompareTo(secondArray) < 0)
            {
                Console.WriteLine("<");
            }
            else 
            {
                Console.WriteLine("=");
            }
        }
    }
}

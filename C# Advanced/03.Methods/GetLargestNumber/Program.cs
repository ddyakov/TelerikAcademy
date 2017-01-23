namespace GetLargestNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string[] numebrs = Console.ReadLine().Split(' ');
            int firstNumber = int.Parse(numebrs[0]);
            int secondNumber = int.Parse(numebrs[1]);
            int thirdNumber = int.Parse(numebrs[2]);

            GetMax(firstNumber, secondNumber, thirdNumber);
        }

        public static void GetMax(int firstNumber, int secondNumber, int thirdNumber) 
        {
            List<int> numbers = new List<int>();
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);

            Console.WriteLine(numbers.Max());
        }
    }
}

namespace IntegerCalculations
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
            string[] numbers = Console.ReadLine().Split(' ');
            decimal firstNumber = decimal.Parse(numbers[0]);
            decimal secondNumber = decimal.Parse(numbers[1]);
            decimal thirdNumber = decimal.Parse(numbers[2]);
            decimal fourthNumber = decimal.Parse(numbers[3]);
            decimal fifthNumber = decimal.Parse(numbers[4]);

            MinElement(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            MaxElement(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            Average(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            Sum(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            Product(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);

        }

        public static void MinElement(decimal firstNumber, decimal secondNumber,decimal thirdNumber, decimal fourthNumber, decimal fifthNumber)
        {
            List<decimal> numbers = new List<decimal>();
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);
            numbers.Add(fourthNumber);
            numbers.Add(fifthNumber);

            Console.WriteLine(numbers.Min());
        }

        public static void MaxElement(decimal firstNumber, decimal secondNumber, decimal thirdNumber, decimal fourthNumber, decimal fifthNumber)
        {
            List<decimal> numbers = new List<decimal>();
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);
            numbers.Add(fourthNumber);
            numbers.Add(fifthNumber);

            Console.WriteLine(numbers.Max());
        }

        public static void Average(decimal firstNumber, decimal secondNumber, decimal thirdNumber, decimal fourthNumber, decimal fifthNumber)
        {
            List<decimal> numbers = new List<decimal>();
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);
            numbers.Add(fourthNumber);
            numbers.Add(fifthNumber);

            Console.WriteLine("{0:0.00}", numbers.Average());
        }

        public static void Sum(decimal firstNumber, decimal secondNumber, decimal thirdNumber, decimal fourthNumber, decimal fifthNumber)
        {
            List<decimal> numbers = new List<decimal>();
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);
            numbers.Add(fourthNumber);
            numbers.Add(fifthNumber);

            Console.WriteLine(numbers.Sum());
        }

        public static void Product(decimal firstNumber, decimal secondNumber, decimal thirdNumber, decimal fourthNumber, decimal fifthNumber)
        {
            Console.WriteLine(firstNumber * secondNumber * thirdNumber * fourthNumber * fifthNumber);
        }
    }
}

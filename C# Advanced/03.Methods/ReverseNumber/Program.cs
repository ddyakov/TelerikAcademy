namespace ReverseNumber
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
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNumber(number));
        }

        public static decimal ReversedNumber(decimal number)
        {
            return decimal.Parse(string.Join("",number.ToString().Reverse()));
        }
    }
}

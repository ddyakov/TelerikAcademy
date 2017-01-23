using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(n));
        }

        public static BigInteger CalculateFactorial(BigInteger n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }
}

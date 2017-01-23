namespace ComparingFloats
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001d;

            bool compare = (Math.Abs(firstNumber - secondNumber)) < eps;

            Console.WriteLine(compare.ToString().ToLower());
        }
    }
}

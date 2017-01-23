namespace ExchangeVariableValues
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            int c = 0;
            
            c = a;
            a = b;
            b = c;
        }
    }
}

namespace PrintTheASCIITable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char) i);
            }
        }
    }
}

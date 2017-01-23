namespace StringsAndObjects
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concatenation = hello + " " + world;
            string result = (string)concatenation;
            Console.WriteLine(result);
        }
    }
}

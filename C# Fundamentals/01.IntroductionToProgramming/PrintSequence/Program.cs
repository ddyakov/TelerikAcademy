﻿namespace PrintSequence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("-{0}", i);
                }
            }
        }
    }
}

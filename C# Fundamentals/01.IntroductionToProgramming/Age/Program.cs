﻿namespace DateBirthday
{
    using System;

    public class DateBirthday
    {
        public static void Main()
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - birthday.Year;

            if (today < birthday.AddYears(age))
            {
                age--;
            }

            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
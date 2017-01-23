namespace IndexOfLetters
{
    using System;

    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            foreach (var letter in word)
            {
                GetIndexOfLetter(letter);
            }
        }

        public static void GetIndexOfLetter(char letter)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

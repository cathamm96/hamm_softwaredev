using System;

namespace CodeLouPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateAlphabet());
            Console.WriteLine(CreateAlphabet().ToLower());

            Console.WriteLine(CreateAlphabetBackwards());
            Console.WriteLine(CreateAlphabetBackwards().ToLower());

            Console.Write("How many letters would you like to skip: ");
            string userInput = Console.ReadLine();
            int numberToSkip = int.Parse(userInput);
            string skipOver = CreateAlphabetSkipped(numberToSkip);
            Console.WriteLine(skipOver);
        }


        static string CreateAlphabet()
        {
            string alphabet = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet += alpha;
            }
            return alphabet;
        }


        static string CreateAlphabetBackwards()
        {
            string alphabetBackwards = "";
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabetBackwards += alpha;
            }
            return alphabetBackwards;
        }


        static string CreateAlphabetSkipped(int skip)
        {
            string alphabetSkipped = "";
            for (char alpha = 'A'; alpha <= 'Z';)
            {
                alphabetSkipped += alpha;
                for (int i = 1; i <= skip; i++)
                {
                    alpha++;
                }
            }
            return alphabetSkipped;
        }

    }
}

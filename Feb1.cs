using System;

namespace CodeLouPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("\tA-Alphabet");
            Console.WriteLine("\tZ-Alphabet Backwards");
            Console.WriteLine("\tS-Alphabet Skipping Letters");
            Console.WriteLine("Selection: ");
            string userInput = Console.ReadLine();

            switch (userInput.ToUpper())
            {
                case "A":
                    Console.WriteLine(CreateAlphabet());
                    break;
                case "Z":
                    Console.WriteLine(CreateAlphabetBackwards());
                    break;
                case "S":
                    Console.Write("How many would you like to skip: ");
                    userInput = Console.ReadLine();
                    int nSkip = int.Parse(userInput);
                    Console.WriteLine(CreateAlphabetSkipped(nSkip));
                    break;
                default:
                    Console.WriteLine("Invalid Menu Selection!");
                    break;
            }

            Console.Write("\nDid you enjoy playing? (Y)es or (N)o:");
            string enjoyed = Console.ReadLine();
            if (enjoyed.ToUpper() == "Y")
                Console.WriteLine("\nGreat!");
            else
                Console.WriteLine("\nSorry (:");
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

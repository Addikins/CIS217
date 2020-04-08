using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_and_Consonants
{
    class Program
    {


        static void Main(string[] args)
        {
            bool playAgain = false;

            Console.WriteLine("\n\n               ---- Vowels and Consonants Counter ---\n\n");
            Console.WriteLine("This program counts the number of vowels and consonants in a given word.\n" +
                "To begin simply type in a word using only letters A-Z.\n\n");

            do
            {

                char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
                int numberOfConst = 0;
                int numberOfVowels = 0;
                string selection;

                string givenWord = GetUserInput();


                numberOfVowels = CountVowels(givenWord.ToLower(), vowels);
                numberOfConst = CountConsonants(givenWord.ToLower(), numberOfVowels);

                Console.WriteLine(string.Format("'{0}' contains {1} Vowels and {2} Consonants!\n\n", givenWord, numberOfVowels, numberOfConst));

                Console.WriteLine("Would you like to enter another word?");

                do
                {
                    Console.Write("Y/N:");
                    selection = Console.ReadLine();

                    if (selection.ToLower() == "y")
                    { playAgain = true; }
                    else if (selection.ToLower() == "n")
                    { playAgain = false; }

                } while (selection.ToLower() != "y" && selection.ToLower() != "n");

            } while (playAgain);
            Console.WriteLine("\n\n               ---- Thank you for using the Vowels and Consonants Counter! ----\n\n");
        }

        static string GetUserInput()
        {
            string userInput;
            char[] inputInCharacters;
            bool isValidInput;

            do
            {
                isValidInput = true;

                Console.Write("\nPlease enter a word: ");
                userInput = Console.ReadLine();

                inputInCharacters = userInput.ToCharArray();

                foreach (char letter in inputInCharacters)
                {
                    if (char.IsLetter(letter))
                    {
                        continue;
                    }
                    isValidInput = false;
                    Console.WriteLine("Word can only contain letters. No spaces, numbers, or symbols are allowed");
                }

            }
            while (!isValidInput);

            Console.WriteLine("Thank you!\n\n");
            return userInput;
        }

        static int CountConsonants(string word, int vowelCount)
        {
            int constCount = word.Length - vowelCount;

            if (constCount + vowelCount != word.Length)
            {
                Console.WriteLine("There seems to be a problem...");
            }

            return constCount;
        }

        static int CountVowels(string word, char[] vowels)
        {
            int vowelCount = 0;
            char[] letters = word.ToCharArray();

            foreach (char letter in letters)
            {
                foreach (char vowel in vowels)
                {
                    if (letter == vowel)
                    {
                        vowelCount += 1;
                    }
                }
            }
            return vowelCount;
        }
    }
}

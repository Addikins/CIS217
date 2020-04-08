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


            char[] GetUserInput()
            {
                bool isValidInput = true;
                char[] userInput;

                do
                {
                    Console.Write("Please enter a word: ");
                    userInput = Console.ReadLine().ToCharArray();

                    foreach (char letter in userInput)
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

                Console.WriteLine("Thank you!");
                return userInput;
            }
        }
    }
}

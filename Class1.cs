using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangaGubbe
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman!");
            string[] words = new string[4];
            words[0] = "BUSS";
            words[1] = "UGGLA";
            words[2] = "SVAN";
            words[3] = "STEN";

            Random random = new Random();
            var idx = random.Next(words.Length);
            Console.WriteLine(words[idx]);
            string secretWord = words[idx]; 
            char[] guess = new char[secretWord.Length]; 
            Console.WriteLine("Write a letter");

            for (int j = 0; j < secretWord.Length; j++)
            {

                guess[j] = '_';
                Console.Write(guess[j]);

            } 
            
            int p = 0;
            bool hit = false;
            while (p<8)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (playerGuess == secretWord[i])
                    {
                        guess[i] = playerGuess;
                        hit = true;
                    }
                    else if (hit == false)
                    {
                        Console.WriteLine("Try again");
                        p++;
                    }

                }
                Console.WriteLine(guess);

            }
                



                /*string input = Console.ReadLine();
                string inputUpper = input.ToUpper();
                if (inputUpper == secretWord)
                {
                    Console.WriteLine("You won");
                    
                }
                else
                {
                    Console.WriteLine("you lost");
                    i++;
                    
                }*/
        }
    }
}

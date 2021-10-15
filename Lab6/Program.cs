/// Chapter No. 6		Exercise No. 1
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  oct 14, 2021
///
/// Problem Statement:  Create a guessing game. Randomly get a number between 0 and 100, 
/// keep looping until you find the number. For each guess the program should say higher or 
/// lower if incorrect (depending on whether its higher or lower).  If correct you should end the game 
/// and state how many guesses it took to find the right answer.
/// 
/// 
/// 
/// Overall Plan:
/// 1) Create a random number object from the random class
/// 2) Generate a number between 0 - 100 
/// 3) Use that generated number in a loop that will keep looping until the number is guessed correctly 
/// 4) Display message that stats if the guess was less or greater than the number 
/// 5) Once the number has been guessed, end the game and display how many guesses the user attempted.  
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the Random class object 
            Random rand = new Random();

            int num = rand.Next(0, 100);
            int userGuess, i = 1, attempts = 0;

            Console.WriteLine("~~~ Guessing Game ~~~\n  Pick a number between 0 and 100: ");

            do
            {
                Console.Write("\nGuess #" + i + ":  ");
                userGuess = Int32.Parse(Console.ReadLine());

                if (userGuess == num) // if the guess was correct
                    Console.WriteLine("Great Guess! You got it!");

                else if (userGuess < num) //  if the guess was less than the number 
                    Console.WriteLine("Your guess is less than the number. ");

                else if (userGuess > num) // if the guess was greater than the number
                    Console.WriteLine("Your guess is greater than the number. ");

                i++; // increasing the counts 
                attempts++;

            } while (userGuess != num);

            // out of do-while loop 
            Console.WriteLine("It took you " + attempts + " attempts to guess it correctly");

            Console.ReadLine();
        }
    }
}

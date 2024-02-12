using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson7_Loops
{
    internal class Loops
    {
        public void main()
        {
            bool playAgain = true;
            string response;

            do
            {
                Random random = new Random();
                int randomNum = random.Next(0,100);
                int  guesses = 0, guess = 0;

                Console.WriteLine("GUESSING GAME! ");

                for (int lives = 10;  lives > 0; )
                {
                    Console.Write("\nGuess the Number (0-99)  :  ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;

                    if(guess == randomNum)
                    {
                        Console.WriteLine("Congratulations! You got it right! ");
                        Console.WriteLine("Number of guesses: " + guesses);
                        break;
                    } 
                    else if(guess < randomNum)
                    {
                        Console.WriteLine("Higher!");
                        lives--;
                        Console.WriteLine("Lives left: " + lives);
                    } 
                    else if(guess > randomNum)
                    {
                        Console.WriteLine("Lower!");
                        lives--;
                        Console.WriteLine("Lives left: " + lives);
                    }

                    if(lives == 0) Console.WriteLine("You are out of Lives! You lose!");
                }

                while (true) {
                    Console.Write("\nDo you want to play again(Y/N)?  ");
                    response = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    if (response == "Y")
                    {
                        playAgain = true;
                        break;
                    }
                    else if (response == "N")
                    {
                        playAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine("Try Again!");
                    }
                }
            } while (playAgain);

            Console.WriteLine("Thank you for playing!\n");
        }
    }
}

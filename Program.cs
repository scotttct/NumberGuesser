using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Scott Tomassetti";

            // Change Color 
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
            Console.WriteLine("What is your name?");

            //get user input

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}. Let's play a game", inputName);

            //
            while(true)
            {

            //int correctNumber = 7;

            // Create a new random object
            Random random = new Random();

            int correctNumber = random.Next(1, 10);
            int guess = 0;

            Console.WriteLine("Guess a number between 1-10");
                while(guess != correctNumber)
                {

                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("You did not enter a number, please enter a number!");

                        Console.ResetColor();

                        continue;
                    }

                    guess = int.Parse(input);

                    if (guess != correctNumber) { 
                
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong Guess, Try Again");

                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You are Correct! Congrats");

                Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}

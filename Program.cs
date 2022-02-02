using System;

namespace NumberGuesser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String appName = "Number Guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Brad Traversery";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            //write out app info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();

            //ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            String inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            //Init correct number
            //int correctNumber = 7;

            //create a new Random object
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            //Init guess var
            int guess = 0;


            Console.WriteLine("Guess a number between 1 and 10");
            //While guess is not correct

            while(guess != correctNumber)
            {
                String input = Console.ReadLine();
                //make sure its a number
                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    //tell user its not a number
                    Console.WriteLine("Please enter an actual number");

                    Console.ResetColor();

                    //keep going
                    continue;


                }
                //cast to int and put in guess
                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong number, please try again");

                    Console.ResetColor();
                }

            }
            //output success message
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("You are correct");

            Console.ResetColor();

        }
    }
}

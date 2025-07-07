using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            
        

            while (guess != magicNumber)
            {
                Console.Write(" What is your guess? ");
                string userInPut1 = Console.ReadLine();

                bool isValid = int.TryParse(userInPut1, out guess);
                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }

                

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {

                    Console.WriteLine("You guessed it !");

                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing");
    }
}
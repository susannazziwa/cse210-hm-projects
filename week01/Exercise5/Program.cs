using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = promptUserName();

        int favouriteNumber = promptUserNumber();

        int squaredNumber = squareNumber(favouriteNumber);

        DisplayResults(userName, squaredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int promptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int squareNumber(int number)
    {
        return number * number;

    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    

}
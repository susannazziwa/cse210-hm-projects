using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(" What is your first name? ");
        string first = Console.ReadLine();

        Console.Write(" What is your second name? ");
        string second = Console.ReadLine();

        Console.WriteLine($" Your name is {second}, {first} {second}");

    }
}
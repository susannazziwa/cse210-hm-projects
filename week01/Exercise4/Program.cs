using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;

        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The max is: {max}");
    }
}
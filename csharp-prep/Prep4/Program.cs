using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished.\n");
        
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        
        {
            Console.Write("Enter number: ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Step 1 - Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");


        // Step 2 - Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Step 3 - Find the largest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}
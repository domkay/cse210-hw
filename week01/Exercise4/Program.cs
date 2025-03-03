using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        int status = -1;
        int input;
        float numbersAverage;
        int numbersSum = 0;
        int largest = int.MinValue;
        int smallest = int.MaxValue;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (status != 0)
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                status = input;
            }
            else
            {
                numbers.Add(input);
            }
        }
        foreach (int num in numbers)
        {
            numbersSum += num;
            if (num > largest)
            {
                largest = num;
            }

            if (num < smallest)
            {
                smallest = num;
            }
        }
        numbersAverage = (float)numbersSum / numbers.Count();
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"The sum is: {numbersSum}");
        Console.WriteLine($"The average is: {numbersAverage}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
    }
}
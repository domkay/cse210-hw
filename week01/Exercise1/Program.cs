using System;

class Program
{
    static void Main(string[] args)
    {
        String firstname;
        String lastname;
        Console.Write("What is your first name? ");
        firstname = Console.ReadLine();
        Console.Write("What is Your last name? ");
        lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}